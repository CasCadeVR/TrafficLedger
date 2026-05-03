using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace TrafficLedger.Desktop.Infrastructure.Extensions
{
    /// <summary>
    /// Расширения для методов создания привязки 
    /// </summary>
    public static class BindingExtensions
    {
        /// <summary>
        /// Создаёт привязку свойства класса к объекту Control 
        /// </summary>
        public static void AddBindings<TControl, TSource>(this TControl target,
            Expression<Func<TControl, object>> targetProperty,
            TSource source,
            Expression<Func<TSource, object>> sourceProperty,
            ErrorProvider errorProvider = null)
            where TControl : Control
            where TSource : class
        {
            target.DataBindings.Clear();

            var targetName = GetPropertyName(targetProperty);
            var sourceName = GetPropertyName(sourceProperty);

            target.DataBindings.Add(new Binding(targetName, source, sourceName, false, DataSourceUpdateMode.OnPropertyChanged));

            if (errorProvider != null)
            {
                target.Validated += (_, cancelEventArgs) =>
                {
                    var context = new ValidationContext(source);
                    var result = new List<ValidationResult>();
                    errorProvider.SetError(target, string.Empty);

                    if (!Validator.TryValidateObject(source, context, result, true))
                    {
                        foreach (var error in result.Where(x => x.MemberNames.Contains(sourceName)))
                        {
                            errorProvider.SetError(target, error.ErrorMessage);
                        }
                    }
                };
            }
        }

        /// <summary>
        /// Создаёт привязку свойства класса к объекту Control с типизированием
        /// </summary>
        public static void AddBindingWithConversion<TSource, TTarget, TSourceValue, TTargetValue>(
            this TTarget control,
            Expression<Func<TTarget, TTargetValue>> targetProperty,
            TSource source,
            Expression<Func<TSource, TSourceValue>> sourceProperty,
            Func<TSourceValue, TTargetValue> convertToTarget,
            Func<TTargetValue, TSourceValue> convertToSource,
            ErrorProvider errorProvider = null)

            where TTarget : Control
        {
            control.DataBindings.Clear();

            var targetName = GetPropertyName(targetProperty);
            var sourceName = GetPropertyName(sourceProperty);

            var binding = new Binding(targetName, source, sourceName, false, DataSourceUpdateMode.OnPropertyChanged);

            binding.Format += (s, e) => e.Value = convertToTarget((TSourceValue)e.Value);
            binding.Parse += (s, e) => e.Value = convertToSource((TTargetValue)e.Value);

            control.DataBindings.Add(binding);

            if (errorProvider != null)
            {
                control.Validated += (_, cancelEventArgs) =>
                {
                    var context = new ValidationContext(source);
                    var result = new List<ValidationResult>();
                    errorProvider.SetError(control, string.Empty);

                    if (!Validator.TryValidateObject(source, context, result, true))
                    {
                        foreach (var error in result)
                        {
                            errorProvider.SetError(control, error.ErrorMessage);
                        }
                    }
                };
            }
        }

        private static string GetPropertyName<TItem, TMember>(Expression<Func<TItem, TMember>> targetMember)
        {
            if (targetMember.Body is MemberExpression memberExpression)
            {
                return memberExpression.Member.Name;
            }

            if (targetMember.Body is UnaryExpression unaryExpression)
            {
                var operand = unaryExpression.Operand as MemberExpression;

                if (operand != null)
                {
                    return operand.Member.Name;
                }
            }

            throw new InvalidOperationException("Ошибка типа выражения. Ожидалось MemberExpression или UnaryExpression");
        }
    }
}