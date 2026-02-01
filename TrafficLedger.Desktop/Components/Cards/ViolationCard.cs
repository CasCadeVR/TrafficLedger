using System;
using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="Violation"/>
    /// </summary>
    public partial class ViolationCard : BaseCard
    {
        /// <summary>
        /// Нажата кнопка редактирования
        /// </summary>
        public event Action EditClicked;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action DeletedClicked;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ViolationCard"/>
        /// </summary>
        public ViolationCard(Violation request)
        {
            InitializeComponent();
            FillFields(request);
            buttonDelete.Visible = AuthenticationService.Instance.HasAccessTo(Role.Admin);
            buttonEdit.Visible = AuthenticationService.Instance.HasAccessTo(Role.Admin);
        }

        private void FillFields(Violation request)
        {
            violationName.Text = request.Name;
            description.Text = request.Description;
            code.Text = request.ViolationCode;
            finePrice.Text = request.FinePrice.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeletedClicked?.Invoke();
        }
    }
}
