using FluentAssertions;
using TrafficLedger.Context.Tests;
using TrafficLedger.Entities;
using Xunit;

namespace TrafficLedger.Storage.Tests
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
        public void ConnectionShouldBeEstablished()
        {
            // Arrange & Act
            Action act = async () => await Context.Database.CanConnectAsync();

            // Assert
            act.Should().NotThrow();
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