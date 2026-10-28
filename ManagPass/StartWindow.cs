namespace ManagPass
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();

            nameGropBox.Text = nameGropList.Text;
        }

        private void nameGropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameGropBox.Text = nameGropList.Text;
        }
    }
}
