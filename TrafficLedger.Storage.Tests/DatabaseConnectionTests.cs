using FluentAssertions;
using TrafficLedger.Context.Tests;
using TrafficLedger.Entities;
using Xunit;

namespace TrafficLedger.Storage.Tests
{
    /// <summary>
    /// Тесты на подключение к базе данных
    /// </summary>
    public class DatabaseConnectionTests : IClassFixture<TrafficLedgerContextInMemory>
    {
        private readonly TrafficLedgerContextInMemory fixture;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="DatabaseConnectionTests"/>
        /// </summary>
        public DatabaseConnectionTests(TrafficLedgerContextInMemory fixture)
        {
            this.fixture = fixture;
        }

        /// <summary>
        /// Проверяет, что подключение к базе данных успешно
        /// </summary>
        [Fact]
        public void ConnectionShouldBeEstablished()
        {
            // Arrange & Act
            Action act = () => fixture.Context.Database.Exists();

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
            Action act = () => { result = fixture.Context.Set<Violation>().ToList(); };

            // Assert
            act.Should().NotThrow();
        }
    }
}