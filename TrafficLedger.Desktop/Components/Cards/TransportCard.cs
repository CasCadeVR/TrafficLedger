using System;
using TrafficLedger.Desktop.Contracts.Enums;
using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="Transport"/>
    /// </summary>
    public partial class TransportCard : BaseCard
    {
        /// <summary>
        /// Нажата кнопка редактирования
        /// </summary>
        public event Action EditClicked;

        /// <summary>
        /// Нажата кнопка создания штрафа
        /// </summary>
        public event Action CreateFineClicked;

        /// <summary>
        /// Нажата кнопка список штрафов
        /// </summary>
        public event Action ListFineClicked;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action DeletedClicked;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="TransportCard"/>
        /// </summary>
        public TransportCard(Transport request, TransportCardRoleContext context)
        {
            InitializeComponent();
            FillFields(request);
            ApplyContext(context);
        }

        private void ApplyContext(TransportCardRoleContext context)
        {
            var currentUser = AuthenticationService.Instance.CurrentUser;

            switch (context)
            {
                case TransportCardRoleContext.OwnerList:
                    buttonDelete.Visible = false;
                    buttonAddFine.Visible = false;
                    buttonListFines.Visible = true;
                    break;

                case TransportCardRoleContext.DriverOwnershipList:
                    buttonDelete.Visible = true;
                    buttonAddFine.Visible = false;
                    buttonListFines.Visible = false;
                    break;

                case TransportCardRoleContext.RoleList:
                    buttonEdit.Visible = currentUser.Role != Role.TrafficPolice;
                    buttonDelete.Visible = AuthenticationService.Instance.HasAccessTo(Role.Admin);
                    buttonAddFine.Visible = AuthenticationService.Instance.HasAccessTo(Role.TrafficPolice);
                    buttonListFines.Visible = true;
                    break;
            }
        }

        private void FillFields(Transport request)
        {
            brand.Text = request.Brand;
            model.Text = request.Model;
            number.Text = request.TransportCode;
            category.Text = request.TransportCategory.CategoryName;
            status.Text = Enum.GetName(request.Status);
            toolTip.SetToolTip(category, request.TransportCategory.Description);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke();
        }

        private void buttonListFines_Click(object sender, EventArgs e)
        {
            ListFineClicked?.Invoke();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeletedClicked?.Invoke();
        }

        private void buttonAddFine_Click(object sender, EventArgs e)
        {
            CreateFineClicked?.Invoke();
        }
    }
}
