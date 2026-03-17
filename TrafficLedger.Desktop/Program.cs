using System.Configuration;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TrafficLedger.Context;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views;
using TrafficLedger.Desktop.Views.PanelViews;
using TrafficLedger.Desktop.Views.PanelViews.Admin;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers.Ownerships;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Fines;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Parkings;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Payments;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Requests;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Transports;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Users;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Violations;
using TrafficLedger.Desktop.Views.PanelViews.FineCreate;
using TrafficLedger.Desktop.Views.PanelViews.Fines;
using TrafficLedger.Desktop.Views.PanelViews.Parkings;
using TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions;
using TrafficLedger.Desktop.Views.PanelViews.Payments;
using TrafficLedger.Repositories.Contracts.IReadRepositories;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;
using TrafficLedger.Repositories.ReadRepositories;
using TrafficLedger.Repositories.WriteRepositories;
using TrafficLedger.Services;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop
{
    internal static class Program
    {
        /// <summary>
        /// ¬ходна€ точка программы
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            var authorizeForm = serviceProvider.GetRequiredService<AuthorizeForm>();

            if (authorizeForm.ShowDialog() == DialogResult.OK)
            {
                var mainForm = serviceProvider.GetRequiredService<MainView>();

                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Database
            var connectionString = ConfigurationManager.ConnectionStrings["TrafficLedgerConnectionString"]?.ConnectionString;

            services.AddDbContext<TrafficLedgerContext>(options =>
            {
                options.UseSqlServer(connectionString).LogTo(
                    message => Debug.WriteLine(message),
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information);
            });

            services.AddScoped<IWriter>(x => x.GetRequiredService<TrafficLedgerContext>());
            services.AddScoped<IReader>(x => x.GetRequiredService<TrafficLedgerContext>());
            services.AddScoped<IUnitOfWork>(x => x.GetRequiredService<TrafficLedgerContext>());

            // Repostories and services
            services.AddScoped<IAttachmentReadRepository, AttachmentReadRepository>();
            services.AddScoped<IAttachmentWriteRepository, AttachmentWriteRepository>();
            services.AddScoped<IOwnershipWriteRepository, OwnershipWriteRepository>();
            services.AddScoped<ILicenseCategoryWriteRepository, LicenseCategoryWriteRepository>();

            services.AddScoped<ITransportCategoryReadRepository, TransportCategoryReadRepository>();
            services.AddScoped<ITransportCategoryWriteRepository, TransportCategoryWriteRepository>();
            services.AddScoped<ITransportService, TransportService>();

            services.AddScoped<IViolationReadRepository, ViolationReadRepository>();
            services.AddScoped<IViolationWriteRepository, ViolationWriteRepository>();
            services.AddScoped<IViolationService, ViolationService>();

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<ITransportReadRepository, TransportReadRepository>();
            services.AddScoped<ITransportWriteRepository, TransportWriteRepository>();
            services.AddScoped<ITransportCategoryService, TransportCategoryService>();

            services.AddScoped<IFineReadRepository, FineReadRepository>();
            services.AddScoped<IFineWriteRepository, FineWriteRepository>();
            services.AddScoped<IFineService, FineService>();

            services.AddScoped<IPaymentReadRepository, PaymentReadRepository>();
            services.AddScoped<IPaymentWriteRepository, PaymentWriteRepository>();
            services.AddScoped<IPaymentService, PaymentService>();

            services.AddScoped<IDriverReadRepository, DriverReadRepository>();
            services.AddScoped<IDriverWriteRepository, DriverWriteRepository>();
            services.AddScoped<IDriverService, DriverService>();

            services.AddScoped<IDriverLicenseReadRepository, DriverLicenseReadRepository>();
            services.AddScoped<IDriverLicenseWriteRepository, DriverLicenseWriteRepository>();
            services.AddScoped<IDriverLicenseService, DriverLicenseService>();

            services.AddScoped<IParkingZoneReadRepository, ParkingZoneReadRepository>();
            services.AddScoped<IParkingZoneWriteRepository, ParkingZoneWriteRepository>();
            services.AddScoped<IParkingZoneService, ParkingZoneService>();

            services.AddScoped<IParkingSessionReadRepository, ParkingSessionReadRepository>();
            services.AddScoped<IParkingSessionWriteRepository, ParkingSessionWriteRepository>();
            services.AddScoped<IParkingSessionService, ParkingSessionService>();

            // Helper services
            services.AddSingleton<AuthenticationService>();

            // Main
            services.AddScoped<AuthorizeForm>();
            services.AddScoped<MainView>();
            services.AddScoped<INavigationService>(x => x.GetRequiredService<MainView>());
            services.AddScoped(x => new Lazy<INavigationService>(() => x.GetRequiredService<INavigationService>()));

            // User
            services.AddScoped<UserView>();
            services.AddScoped<DriverCreateView>();
            services.AddScoped<DriverLicenseCreateView>();

            services.AddScoped<OwnershipView>();
            services.AddScoped<OwnershipCreateView>();
            services.AddScoped<OwnershipListView>();

            // Transport
            services.AddScoped<TransportUserListView>();

            // Payment
            services.AddScoped<PaymentParkingSessionCreateView>();
            services.AddScoped<PaymentFineCreateView>();
            services.AddScoped<PaymentFineListView>();
            services.AddScoped<PaymentFineUserListView>();

            // Fines
            services.AddScoped<FineCreateView>();
            services.AddScoped<FineTransportListView>();

            services.AddScoped<TransportListView>();
            services.AddScoped<TransportUserView>();
            services.AddScoped<TransportCreateView>();

            // Parkings
            services.AddScoped<ParkingSessionView>();
            services.AddScoped<ParkingZoneView>();

            services.AddScoped<ParkingZoneCreateView>();
            services.AddScoped<ParkingZoneListView>();

            services.AddScoped<ParkingSessionCreateView>();
            services.AddScoped<ParkingSessionUserListView>();

            // Admin
            services.AddScoped<AdminView>();
            services.AddScoped<RequestView>();
            services.AddScoped<UserListView>();
            services.AddScoped<UserCreateView>();

            services.AddScoped<DriverListView>();

            services.AddScoped<DriverLicenseListView>();

            services.AddScoped<ViolationView>();
            services.AddScoped<ViolationListView>();
            services.AddScoped<ViolationCreateView>();

            services.AddScoped<FineListView>();
        }
    }
}