using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using TrafficLedger.Context.Tests;
using TrafficLedger.Entities;
using Xunit;

namespace TrafficLedger.Database.Tests
{
    /// <summary>
    /// Тесты для базы данных таблицы <see cref="Violation"/>
    /// </summary>
    public class ViolationDatabaseTests : TrafficLedgerContextInMemory
    {
        /// <summary>
        /// Проверяет, что элемент не будет найден по пустому идентификатору
        /// </summary>
        [Fact]
        public async Task GetShouldReturnNull()
        {
            // Arrange
            var emptyId = Guid.Empty;

            // Act
            var result = await Context.Set<Violation>().FirstOrDefaultAsync(x => x.Id == emptyId);

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
            Context.Set<Violation>().Add(target);
            await UnitOfWork.SaveChangesAsync();

            // Act
            var result = await Context.Set<Violation>().FirstOrDefaultAsync(x => x.Id == target.Id);

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
            Context.Set<Violation>().AddRange(new List<Violation>() { target, target1 });
            await UnitOfWork.SaveChangesAsync();

            // Act
            var result = Context.Set<Violation>().ToList();

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
            Context.Set<Violation>().Add(target);
            await UnitOfWork.SaveChangesAsync();
            var result = await Context.Set<Violation>().FirstOrDefaultAsync(x => x.Id == target.Id);

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
            Violation target = null!;

            // Act
            Action act = () => Context.Set<Violation>().Remove(target);

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
            Context.Set<Violation>().Add(newEntity);
            await UnitOfWork.SaveChangesAsync();

            // Act
            var target = await Context.Set<Violation>().SingleAsync(x => x.Id == newEntity.Id);
            Action act = () => Context.Set<Violation>().Remove(target);

            // Assert
            act.Should().NotThrow();
            await UnitOfWork.SaveChangesAsync();
            var result = await Context.Set<Violation>().SingleOrDefaultAsync(x => x.Id == target.Id);
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
            Context.Set<Violation>().Add(newEntity);
            await UnitOfWork.SaveChangesAsync();
            var requestModel = CreateExample();
            var existingEntity = await Context.Set<Violation>().SingleAsync(x => x.Id == newEntity.Id);
            existingEntity.ViolationCode = requestModel.ViolationCode;
            existingEntity.Name = requestModel.Name;
            existingEntity.Description = requestModel.Description;
            existingEntity.MinFinePrice = requestModel.MinFinePrice;

            // Act
            await UnitOfWork.SaveChangesAsync();

            // Assert
            var result = await Context.Set<Violation>().SingleAsync(x => x.Id == existingEntity.Id);
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
            MinFinePrice = new Random().Next(10, 150) * 100,
        };
    }
}