using System;
using TrafficLedger.Desktop.Infrastructure.Navigation;

namespace TrafficLedger.Desktop.Contracts.Interfaces
{
    /// <summary>
    /// Сервис навигации
    /// </summary>
    public interface INavigationService
    {
        /// <summary>
        /// Перейти по <see cref="NavigationItem"/>
        /// </summary>
        void NavigateTo(NavigationItem item);

        /// <inheritdoc cref="IServiceProvider"/>
        IServiceProvider ServiceProvider { get; }
    }
}