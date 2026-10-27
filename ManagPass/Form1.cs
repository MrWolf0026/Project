namespace ManagPass
{
    public partial class Form1 : Form
    {
        public Form1()
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
