using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Users;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin
{
    public partial class UserListView : UserListWrapper
    {
        private readonly INavigationService navigationService;
        private readonly IUserService userService;

        public UserListView(INavigationService navigationService,
            IUserService userService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.userService = userService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
            SearchHintMessage = "Введите логин пользователя";
        }

        protected override async Task<IEnumerable<User>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await userService.GetAll(cancellationToken);
        }

        protected override IEnumerable<User> FilterItems(string searchQuery, IEnumerable<User> items)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return items;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return items.Where(t =>
                t.Login?.ToLowerInvariant().Contains(lowerQuery) == true
            );
        }

        protected override Control CreateItemControl(User user)
        {
            var card = new UserCard(user);

            card.EditClicked += () => EditUser(user);
            card.DeleteClicked += () => DeleteUser(user);

            return card;
        }

        private void EditUser(User user)
        {
            var userCreateView = navigationService.ServiceProvider.GetRequiredService<UserCreateView>();
            userCreateView.Initialize(user);

            var navigationItem = new NavigationItem()
            {
                Title = "Редактирование пользователя",
                ViewType = null,
                ViewInstance = userCreateView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void DeleteUser(User user)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите удалить пользователя {user.Login}?",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                userService.Delete(user.Id, CancellationToken.None);
                MessageBox.Show($"Пользователь {user.Login} успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }
    }
}
