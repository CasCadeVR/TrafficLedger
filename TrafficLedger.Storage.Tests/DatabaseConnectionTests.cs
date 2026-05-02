using FluentAssertions;
using TrafficLedger.Context.Tests;
using TrafficLedger.Entities;
using Xunit;

namespace TrafficLedger.Database.Tests
{
    /// <summary>
    /// Тесты на подключение к базе данных
    /// </summary>
    public class DatabaseConnectionTests : TrafficLedgerContextInMemory
    {
        /// <summary>
        /// Проверяет, что подключение к базе данных успешно
        /// </summary>
        [Fact]
        public async Task ConnectionShouldBeEstablished()
        {
            // Arrange & Act
            var act = await Context.Database.CanConnectAsync();

            // Assert
            act.Should().BeTrue();
        }

        /// <summary>
        /// Проверяет, что можно выполнить простой запрос
        /// </summary>
        [Fact]
        public void CanExecuteSimpleQuery()
        {
            // Arrange
            var result = new List<Violation>();

            // Act
            Action act = () => { result = Context.Set<Violation>().ToList(); };

            // Assert
            act.Should().NotThrow();
        }
    }
}