using System.ComponentModel.DataAnnotations;
using TrafficLedger.Desktop.Infrastructure.Navigation;

namespace TrafficLedger.Desktop.Contracts.Views.PanelViews
{
    /// <summary>
    /// Текущая модель типа <see cref="TModel"/>
    /// </summary>
    public class BaseCreateView<TModel> : BasePanelView
        where TModel : class, new()
    {
        /// <summary>
        /// Текущая модель типа <see cref="TModel"/>
        /// </summary>
        protected TModel CurrentModel { get; set; } = new TModel();

        /// <inheritdoc cref="ErrorProvider"/>
        protected ErrorProvider errorProvider = new ErrorProvider();

        /// <summary>
        /// Текущий идентификатор модели <see cref="TModel"/>
        /// </summary>
        protected Guid EntityId { get; set; } = Guid.Empty;

        /// <summary>
        /// Загрузить модель
        /// </summary>
        protected virtual Task LoadModelAsync() { throw new NotImplementedException(); }

        /// <summary>
        /// Подключить соединение данных с <see cref="Control"/>ами
        /// </summary>
        protected virtual void SetupBindings() { throw new NotImplementedException(); }

        /// <summary>
        /// Заполнить поля по умолчанию
        /// </summary>
        protected virtual void FillControls() { throw new NotImplementedException(); }

        /// <summary>
        /// Метод при сохранении модели
        /// </summary>
        protected virtual Task OnSaveAsync() { throw new NotImplementedException(); }

        /// <summary>
        /// Обработчик ошибок
        /// </summary>
        protected virtual void HandleError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Обработчик валидации и сохранения
        /// </summary>
        protected async Task HandleSaveAsync(params Control[] validationControls)
        {
            bool isValid = Validator.TryValidateObject(CurrentModel,
                new ValidationContext(CurrentModel),
                new List<ValidationResult>(), 
                validateAllProperties: true);

            if (!isValid)
            {
                HandleError("Исправьте ошибки ввода перед сохранением.");
                return;
            }

            if (CurrentModel == null)
            {
                HandleError("Нет данных для сохранения.");
                return;
            }

            try
            {
                await OnSaveAsync();
                OnNavigation(CurrentNavigationItem);
            }
            catch (Exception ex)
            {
                HandleError($"Ошибка при сохранении: {ex.Message}");
            }
        }

        /// <inheritdoc cref="BasePanelView.OnNavigation(NavigationItem)"/>
        public override async void OnNavigation(NavigationItem item)
        {
            base.OnNavigation(item);
            try
            {
                await LoadModelAsync();
                FillControls();
                SetupBindings();
            }
            catch (Exception ex)
            {
                HandleError($"Не удалось загрузить данные: {ex.Message}");
            }
        }
    }
}