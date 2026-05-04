using Microsoft.EntityFrameworkCore;
using TrafficLedger.Entities;

namespace TrafficLedger.Context.SeedData
{
    /// <summary>
    /// Загрузчик исходных данных для <see cref="Violation"/>
    /// </summary>
    public static class ViolationSeeder
    {
        private static List<Violation> Violations =>
             [
                new Violation
                {
                    ViolationCode = "12.1",
                    Name = "Управление транспортным средством, не зарегистрированным в установленном порядке",
                    Description = "Повторное совершение административного правонарушения, предусмотренного частью 1 настоящей статьи," +
                        "влечет наложение административного штрафа в размере пяти тысяч рублей или лишение права " +
                        "управления транспортными средствами на срок от одного до трех месяцев.",
                    MinFinePrice = 500,
                    MaxFinePrice = 800,
                },

                new Violation
                {
                    ViolationCode = "12.2",
                    Name = "Управление транспортным средством с нарушением правил установки на нем государственных регистрационных знаков",
                    Description = "Управление транспортным средством с нечитаемыми, нестандартными или установленными с нарушением требований государственного " +
                        "стандарта государственными регистрационными знаками, за исключением случаев, предусмотренных частью 2 настоящей статьи," +
                        "(в ред. Федерального закона от 23.07.2010 N 175-ФЗ)" +
                        "влечет предупреждение или наложение административного штрафа в размере пятисот рублей.",
                    MinFinePrice = 500
                },

                new Violation
                {
                    ViolationCode = "12.3",
                    Name = "Управление транспортным средством водителем, не имеющим при себе документов, предусмотренных Правилами дорожного движения",
                    Description = "Управление транспортным средством водителем, не имеющим при себе регистрационных документов на транспортное средство, " +
                        "а в установленных случаях документов, предусмотренных таможенным законодательством " +
                        "Таможенного союза, с отметками таможенных органов, подтверждающими временный ввоз транспортного средства," +
                        "(в ред. Федеральных законов от 25.04.2002 N 41-ФЗ, от 24.07.2007 N 210-ФЗ, от 25.12.2012 N 252-ФЗ, от 08.06.2015 N 143-ФЗ)" +
                        "влечет предупреждение или наложение административного штрафа в размере пятисот рублей.",
                    MinFinePrice = 500
                },

                new Violation
                {
                    ViolationCode = "12.6",
                    Name = "Нарушение правил применения ремней безопасности или мотошлемов",
                    Description = "Управление транспортным средством водителем, не пристегнутым ремнем безопасности, перевозка пассажиров, " +
                        "не пристегнутых ремнями безопасности, если конструкцией транспортного средства предусмотрены ремни безопасности, " +
                        "а равно управление мотоциклом или мопедом либо перевозка на мотоцикле пассажиров без мотошлемов или в незастегнутых мотошлемах," +
                        "влечет наложение административного штрафа в размере одной тысячи пятисот рублей.",
                    MinFinePrice = 1500
                },

                new Violation
                {
                    ViolationCode = "12.7",
                    Name = "Управление транспортным средством водителем, не имеющим права управления транспортным средством",
                    Description = "Управление транспортным средством водителем, не имеющим права управления транспортным средством (за исключением учебной езды)," +
                        "влечет наложение административного штрафа в размере от пяти тысяч до пятнадцати тысяч рублей.",
                    MinFinePrice = 5000,
                    MaxFinePrice = 15000,
                },
            ];

        /// <summary>
        /// Загрузить данные <see cref="Violation"/> асинхронно
        /// </summary>
        public static async Task SeedAsync(TrafficLedgerContext context, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }

            if (await context.Set<Violation>().AnyAsync())
            {
                return;
            }

            foreach (var violation in Violations)
            {
                violation.CreatedAt = DateTimeOffset.UtcNow;
                violation.UpdatedAt = DateTimeOffset.UtcNow;
                await context.Set<Violation>().AddAsync(violation);
            }
        }

        /// <summary>
        /// Загрузить данные <see cref="Violation"/>
        /// </summary>
        public static void Seed(TrafficLedgerContext context)
        {
            if (context.Set<Violation>().Any())
            {
                return;
            }

            foreach (var violation in Violations)
            {
                violation.CreatedAt = DateTimeOffset.UtcNow;
                violation.UpdatedAt = DateTimeOffset.UtcNow;
                context.Set<Violation>().Add(violation);
            }
        }
    }
}