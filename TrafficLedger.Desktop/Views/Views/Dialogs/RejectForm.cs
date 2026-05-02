using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Views.Views
{
    /// <summary>
    /// Форма написания причина отказа
    /// </summary>
    public partial class RejectForm : Form
    {
        /// <summary>
        /// Комментарий
        /// </summary>
        public string Commentary => commentaryTextBox.Text;

        public RejectForm()
        {
            InitializeComponent();
            BackColor = ColorScheme.FormBackground;
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                  "Вы действительно хотите отклонить эту заявку?",
                  "Выход",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                if (commentaryTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Коментарий не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult = DialogResult.OK;
            }
        }
    }
}
