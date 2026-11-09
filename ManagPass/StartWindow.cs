namespace ManagPass
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();

            toolTip1.SetToolTip(WayBox, "Для выбора файла дважджы нажмите ЛКМ.");
            toolTip1.SetToolTip(PasswordBox, "Здесь вводится пароль для открытия файла.");
            toolTip1.SetToolTip(OpenBtn, "Открыть файл, послек ввода пароля.");
            toolTip1.SetToolTip(ExitBtn, "Закрыть приложение.");
            toolTip1.SetToolTip(CreateBtn, "Начало работы с пустым файлом.");
            toolTip1.SetToolTip(ShowPass, "Показать пароль.");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вас приветствует программа \"Менеджер паролей\"!\n\n" +
                "Чтобы получить информацию о конкретном элементе, вы можете навести на него курсор, после чего появится всплывающая подсказка.");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPass.Checked == true)
            {
                PasswordBox.PasswordChar = '\0';
            }


            if (ShowPass.Checked == false)
            {
                PasswordBox.PasswordChar = '*';
            }
        }
    }
}
