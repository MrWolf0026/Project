using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagPass
{
    public partial class HomeWindow : Form
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void nameGropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameGropBox.Text = nameGropList.Text;
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вас приветствует программа \"Менеджер паролей\"!\n\n" +
                "");
        }
    }
}
