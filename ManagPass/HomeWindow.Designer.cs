namespace ManagPass
{
    partial class HomeWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            nameGropBox = new TextBox();
            nameGropList = new ListBox();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 76);
            label3.Name = "label3";
            label3.Size = new Size(194, 31);
            label3.TabIndex = 0;
            label3.Text = "Тип шифрования";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(466, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 237);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сохраниение";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 138);
            label4.Name = "label4";
            label4.Size = new Size(164, 31);
            label4.TabIndex = 1;
            label4.Text = "Пароль файла";
            // 
            // button1
            // 
            button1.Location = new Point(12, 136);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 10;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 91);
            button2.Name = "button2";
            button2.Size = new Size(290, 46);
            button2.TabIndex = 6;
            button2.Text = "Сгенерировать пароль";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 50);
            label2.Name = "label2";
            label2.Size = new Size(93, 31);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(105, 47);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(337, 38);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(353, 38);
            textBox2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(12, 276);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 255);
            panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nameGropBox);
            groupBox1.Location = new Point(12, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(448, 82);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Название группы";
            // 
            // nameGropBox
            // 
            nameGropBox.Location = new Point(6, 37);
            nameGropBox.Name = "nameGropBox";
            nameGropBox.Size = new Size(436, 38);
            nameGropBox.TabIndex = 0;
            // 
            // nameGropList
            // 
            nameGropList.FormattingEnabled = true;
            nameGropList.ItemHeight = 31;
            nameGropList.Items.AddRange(new object[] { "Google", "Steam", "Discord" });
            nameGropList.Location = new Point(12, 33);
            nameGropList.Name = "nameGropList";
            nameGropList.Size = new Size(448, 97);
            nameGropList.TabIndex = 7;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(67, 24);
            выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(201, 26);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(201, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(201, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, выйтиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(898, 30);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // HomeWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 555);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(nameGropList);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "HomeWindow";
            Text = "HomeWindow";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox nameGropBox;
        private ListBox nameGropList;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}