using TrafficLedger.Desktop.Components.Controls.SearchBars;
using TrafficLedger.Desktop.Components.Labels;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    /// <summary>
    /// Базовый класс для списков с поиском по нажатию кнопки.
    /// </summary>
    /// <typeparam name="TItem">Тип элемента списка</typeparam>
    public class BaseListView<TItem> : BasePanelView
    {
        /// <summary>
        /// Хранитель записей
        /// </summary>
        protected FlowLayoutPanel ItemsContainer { get; set; } = null!;

        /// <summary>
        /// Поисковое поле
        /// </summary>
        protected SearchBar SearchBar { get; set; } = null!;

        /// <summary>
        /// Сообщение при остутсвии элементов
        /// </summary>
        protected string NoItemsMessage { get; set; } = "Список пуст";

        private List<TItem> allItems = [];

        /// <summary>
        /// Загружает все данные один раз (при открытии формы)
        /// </summary>
        protected virtual Task<IEnumerable<TItem>> LoadItemsAsync(CancellationToken cancellationToken) { throw new NotImplementedException(); }

        /// <summary>
        /// Фильтрует элементы по поисковому запросу
        /// </summary>
        protected virtual IEnumerable<TItem> FilterItems(string searchTerm, IEnumerable<TItem> items) { throw new NotImplementedException(); }

        /// <summary>
        /// Создаёт UI-компонент для одного элемента
        /// </summary>
        protected virtual Control CreateItemControl(TItem item) { throw new NotImplementedException(); }

        /// <summary>
        /// Обработчик ошибок
        /// </summary>
        protected virtual void HandleLoadError(Exception ex)
        {
            MessageBox.Show(
                $"Не удалось загрузить данные: {ex.Message}",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void RenderItems(IEnumerable<TItem> items)
        {
            ItemsContainer?.Controls.Clear();

            if (!items.Any())
            {
                AddNoItemsMessage();
                return;
            }

            foreach (var item in items)
            {
                ItemsContainer?.Controls.Add(CreateItemControl(item));
            }
        }

        /// <summary>
        /// Выполняет поиск по текущему запросу
        /// </summary>
        protected void PerformSearch()
        {
            string query = SearchBar?.searchTerm?.Text.Trim() ?? string.Empty;

            var filtered = FilterItems(query, allItems);
            RenderItems(filtered);
        }

        private void SetupSearch()
        {
            if (SearchBar != null)
            {
                SearchBar.Clicked += PerformSearch;
            }
        }

        private void AddNoItemsMessage()
        {
            var label = new Heading3Label();
            label.Text = NoItemsMessage;
            label.TextAlign = ContentAlignment.MiddleCenter;

            ItemsContainer?.Controls.Add(label);
        }

        /// <inheritdoc cref="BasePanelView.OnNavigation(NavigationItem)"/>
        public override async void OnNavigation(NavigationItem item)
        {
            base.OnNavigation(item);

            try
            {
                var items = await LoadItemsAsync(CancellationToken.None);
                allItems = items.ToList();

                RenderItems(allItems);
                SetupSearch();
                PerformSearch();
            }
            catch (Exception ex)
            {
                HandleLoadError(ex);
            }
        }
    }
}