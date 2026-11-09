namespace ManagPass
{
    partial class StartWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ShowPass = new CheckBox();
            PasswordBox = new TextBox();
            groupBox1 = new GroupBox();
            OpenBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            WayBox = new TextBox();
            ExitBtn = new Button();
            CreateBtn = new Button();
            menuStrip1 = new MenuStrip();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.Location = new Point(6, 118);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(179, 29);
            ShowPass.TabIndex = 0;
            ShowPass.Text = "Показать пароль";
            ShowPass.UseVisualStyleBackColor = true;
            ShowPass.CheckedChanged += ShowPass_CheckedChanged;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(90, 69);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(253, 32);
            PasswordBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OpenBtn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(WayBox);
            groupBox1.Controls.Add(PasswordBox);
            groupBox1.Controls.Add(ShowPass);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 166);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пароль";
            // 
            // OpenBtn
            // 
            OpenBtn.Location = new Point(191, 107);
            OpenBtn.Name = "OpenBtn";
            OpenBtn.Size = new Size(152, 49);
            OpenBtn.TabIndex = 10;
            OpenBtn.Text = "Открыть";
            OpenBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 5;
            label1.Text = "Путь";
            // 
            // WayBox
            // 
            WayBox.Location = new Point(65, 31);
            WayBox.Name = "WayBox";
            WayBox.PasswordChar = '*';
            WayBox.ReadOnly = true;
            WayBox.Size = new Size(278, 32);
            WayBox.TabIndex = 4;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(244, 199);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(122, 49);
            ExitBtn.TabIndex = 8;
            ExitBtn.Text = "Выйти";
            ExitBtn.UseVisualStyleBackColor = true;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(12, 199);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(226, 49);
            CreateBtn.TabIndex = 9;
            CreateBtn.Text = "Создать новый файл";
            CreateBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { помощьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(378, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(68, 20);
            помощьToolStripMenuItem.Text = "Помощь";
            помощьToolStripMenuItem.Click += помощьToolStripMenuItem_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // StartWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 260);
            Controls.Add(CreateBtn);
            Controls.Add(ExitBtn);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "StartWindow";
            Text = "Окно входа";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ShowPass;
        private TextBox PasswordBox;
        private GroupBox groupBox1;
        private Button ExitBtn;
        private Button CreateBtn;
        private Label label2;
        private Label label1;
        private TextBox WayBox;
        private Button OpenBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolTip toolTip1;
    }
}
