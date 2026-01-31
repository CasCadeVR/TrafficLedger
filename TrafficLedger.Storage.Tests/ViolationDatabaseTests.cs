using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using TrafficFinePayment.Context.Tests;
using TrafficFinePayment.Entities;
using Xunit;

namespace TrafficFinePayment.Storage
{
    /// <summary>
    /// Тесты для базы данных таблицы <see cref="Violation"/>
    /// </summary>
    public class ViolationDatabaseTests : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture fixture;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ViolationDatabaseTests"/>
        /// </summary>
        public ViolationDatabaseTests(DatabaseFixture fixture)
        {
            this.fixture = fixture;
        }

        /// <summary>
        /// Проверяет, что элемент не будет найден по пустому идентификатору
        /// </summary>
        [Fact]
        public async Task GetShouldReturnNull()
        {
            // Arrange
            var emptyId = Guid.Empty;

            // Act
            var result = await fixture.Context.Set<Violation>().SingleOrDefaultAsync(x => x.Id == emptyId);

            // Assert
            result.Should().BeNull();
        }

        /// <summary>
        /// Проверяет, что элемент будет найден
        /// </summary>
        [Fact]
        public async Task GetShouldReturnValue()
        {
            // Arrange
            var target = CreateExample();
            fixture.Context.Set<Violation>().Add(target);
            await fixture.UnitOfWork.SaveChangesAsync();

            // Act
            var result = await fixture.Context.Set<Violation>().SingleOrDefaultAsync(x => x.Id == target.Id);

            // Assert
            result.Should().BeEquivalentTo(target);
        }

        /// <summary>
        /// Проверяет чтение с хранилища и наличие в нём объекта
        /// </summary>
        [Fact]
        public async Task GetAllShouldReturnValues()
        {
            // Arrange
            var target = CreateExample();
            var target1 = CreateExample();
            fixture.Context.Set<Violation>().AddRange(new List<Violation>() { target, target1 });
            await fixture.UnitOfWork.SaveChangesAsync();

            // Act
            var result = fixture.Context.Set<Violation>().ToList();

            // Assert
            result.Should().NotBeEmpty()
                    .And.ContainSingle(x => x.Id == target.Id)
                    .And.ContainSingle(x => x.Id == target1.Id);
        }

        /// <summary>
        /// Проверяет добавление объектов в хранилище
        /// </summary>
        [Fact]
        public async Task AddShouldReturnValue()
        {
            // Arrange
            var target = CreateExample();

            // Act
            fixture.Context.Set<Violation>().Add(target);
            await fixture.UnitOfWork.SaveChangesAsync();
            var result = await fixture.Context.Set<Violation>().SingleOrDefaultAsync(x => x.Id == target.Id);

            // Assert
            result.Should().NotBeNull()
                .And.BeEquivalentTo(target);
        }

        /// <summary>
        /// Удаление падает с ошибкой: элемент не найден
        /// </summary>
        [Fact]
        public void DeleteShouldThrowById()
        {
            // Arrange
            Violation target = null;

            // Act
            Action act = () => fixture.Context.Set<Violation>().Remove(target);

            // Assert
            act.Should().Throw<ArgumentNullException>();
        }

        /// <summary>
        /// Успешно удаляет существующий элемент
        /// </summary>
        [Fact]
        public async Task DeleteShouldWork()
        {
            // Arrange
            var newEntity = CreateExample();
            fixture.Context.Set<Violation>().Add(newEntity);
            await fixture.UnitOfWork.SaveChangesAsync();

            // Act
            var target = await fixture.Context.Set<Violation>().SingleAsync(x => x.Id == newEntity.Id);
            Action act = () => fixture.Context.Set<Violation>().Remove(target);

            // Assert
            act.Should().NotThrow();
            await fixture.UnitOfWork.SaveChangesAsync();
            var result = await fixture.Context.Set<Violation>().SingleOrDefaultAsync(x => x.Id == target.Id);
            result.Should().BeNull();
        }

        /// <summary>
        /// Редактирует элемент, изменяя все значения кроме Идентификатора
        /// </summary>
        [Fact]
        public async Task UpdateShouldWork()
        {
            // Arrange
            var newEntity = CreateExample();
            fixture.Context.Set<Violation>().Add(newEntity);
            await fixture.UnitOfWork.SaveChangesAsync();
            var requestModel = CreateExample();
            var existingEntity = await fixture.Context.Set<Violation>().SingleAsync(x => x.Id == newEntity.Id);
            existingEntity.ViolationCode = requestModel.ViolationCode;
            existingEntity.Name = requestModel.Name;
            existingEntity.Description = requestModel.Description;
            existingEntity.FinePrice = requestModel.FinePrice;

            // Act
            await fixture.UnitOfWork.SaveChangesAsync();

            // Assert
            var result = await fixture.Context.Set<Violation>().SingleAsync(x => x.Id == existingEntity.Id);
            result.Should().BeEquivalentTo(requestModel, options => options
                .Excluding(x => x.Id)
                .Excluding(x => x.CreatedAt)
                .Excluding(x => x.UpdatedAt)
                .Excluding(x => x.DeletedAt));
        }

        private static Violation CreateExample() => new Violation()
        {
            Id = Guid.NewGuid(),
            Name = $"Name {Guid.NewGuid()}",
            ViolationCode = $"Code {Guid.NewGuid()}",
            Description = $"Description {Guid.NewGuid()}",
            FinePrice = new Random().Next(10, 150) * 100,
        };
    }
}