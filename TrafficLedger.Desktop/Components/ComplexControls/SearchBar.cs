using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.SearchBars
{
    public partial class SearchBar : UserControl
    {
        public event Action Clicked;

        public SearchBar()
        {
            InitializeComponent();
            tableLayoutPanel.BackColor = ColorScheme.MenuButton;
        }

        public void SetSearchPlaceholder(string text)
        {
            searchTerm.PlaceholderText = text;
        }

        private void search_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke();
        }
    }
}
