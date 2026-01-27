namespace TrafficLedger.Common.Core;

/// <summary>
/// Методы расширения для тасков
/// </summary>
public static class TaskExtensions
{
    /// <summary>
    /// Выбрасывает исключение если результатом таски был <see langword="null"/>
    /// </summary>
    public static async Task<TResult> OrThrowIfDefault<TResult, TException>(this Task<TResult> task, Func<TException> exception)
        where TException : Exception
        {
            var result = await task;

            if (EqualityComparer<TResult>.Default.Equals(result, default(TResult)))
            {
                throw exception();
            }

            return result;
        }

    /// <summary>
    /// Выбрасывает исключение если результатом таски был <see langword="true"/>
    /// </summary>
    public static async Task AndThrowIfTrue<TException>(this Task<bool> task, Func<TException> exception)
        where TException : Exception
        {
            var result = await task;

            if (result == true)
            {
                throw exception();
            }
        }

    /// <summary>
    /// Выбрасывает исключение если условие по результату таски выполнилось
    /// </summary>
    public static Task<TResult> OrThrowIf<TResult, TException>(this Task<TResult> task,
        Func<TResult, bool> condition,
        Func<TException> exception)
        where TException : Exception
        => task.ContinueWith(x =>
        {
            if (condition.Invoke(x.Result))
            {
                throw exception.Invoke();
            }

            return x.Result;
        });

    /// <summary>
    /// Выбрасывает исключение если условие по результату таски выполнилось
    /// </summary>
    public static Task<TResult> OrThrowIf<TResult, TException>(this Task<TResult> task,
        Func<TResult, bool> condition,
        Func<TResult, TException> exception)
        where TException : Exception
        => task.ContinueWith(x =>
        {
            if (condition.Invoke(x.Result))
            {
                throw exception.Invoke(x.Result);
            }

            return x.Result;
        });
}