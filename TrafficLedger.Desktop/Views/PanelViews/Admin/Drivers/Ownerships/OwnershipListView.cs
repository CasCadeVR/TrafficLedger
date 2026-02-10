using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Enums;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;
using TrafficLedger.Services.Contracts.Models.Ownerships;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers.Ownerships
{
    public partial class OwnershipListView : BaseListView<Transport>
    {
        private readonly INavigationService navigationService;
        private readonly ITransportService transportService;
        private Driver currentDriver = null!;

        public OwnershipListView(INavigationService navigationService, ITransportService transportService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.transportService = transportService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Driver entity)
        {
            currentDriver = entity;
        }

        protected override async Task<IEnumerable<Transport>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await transportService.GetAllByDriverId(currentDriver.Id, cancellationToken);
        }

        protected override IEnumerable<Transport> FilterItems(string searchQuery, IEnumerable<Transport> items)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return items;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return items.Where(t =>
                t.TransportCode?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Brand?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Model?.ToLowerInvariant().Contains(lowerQuery) == true
            );
        }

        protected override Control CreateItemControl(Transport item)
        {
            var card = new TransportCard(item, TransportCardRoleContext.DriverOwnershipList);

            card.EditClicked += () => Edit(item);
            card.DeletedClicked += () => Delete(item);

            return card;
        }

        private void Edit(Transport item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<OwnershipCreateView>();
            createView.Initialize(currentDriver, new OwnershipCodeCreateModel()
            {
                TransportCode = item.TransportCode,
                Date = item.Ownerships.First(x => x.DriverId == currentDriver.Id).Date,
            }); ;

            var navigationItem = new NavigationItem()
            {
                Title = "Редактирование владения",
                ViewType = null!,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void Delete(Transport item)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите развязать владение {currentDriver.FullName} с транспортом с кодом {item.TransportCode}?",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                var ownerships = item.Ownerships.Where(x => x.TransportId != item.Id)
                    .Select(x => new OwnershipDriverCreateModel()
                    {
                        DriverId = currentDriver.Id,
                        Date = x.Date
                    });
                
                var request = new TransportCreateModel()
                {
                    TransportCode = item.TransportCode,
                    Brand = item.Brand,
                    Model = item.Model,
                    Year = item.Year,
                    MileAge = item.MileAge,
                    Region = item.Region,
                    TransportCategoryId = item.TransportCategoryId,
                    Ownerships = ownerships.ToList(),
                }
                ;
                transportService.Update(item.Id, request, CancellationToken.None);
                MessageBox.Show($"Связь между {currentDriver.FullName} с транспортом с кодом {item.TransportCode} успешно удалёна", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }
    }
}
