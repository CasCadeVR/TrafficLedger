namespace TrafficLedger.Desktop.Views.Views
{
    public partial class AttachmentView : Form
    {
        public AttachmentView(string imageName, Image image)
        {
            InitializeComponent();
            this.BackgroundImage = image;
            this.Text = imageName;
        }
    }
}
