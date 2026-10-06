namespace Swp
{
    partial class Form1
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
            input_SNFN = new Button();
            label1 = new Label();
            label2 = new Label();
            Surname = new TextBox();
            Firstname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            BDate = new TextBox();
            Pass = new TextBox();
            label5 = new Label();
            Univer = new TextBox();
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            базаДанныхToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            OpenMenuDataBase = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            GetAddress = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // input_SNFN
            // 
            input_SNFN.Location = new Point(378, 311);
            input_SNFN.Name = "input_SNFN";
            input_SNFN.Size = new Size(110, 23);
            input_SNFN.TabIndex = 0;
            input_SNFN.Text = "Ввод";
            input_SNFN.UseVisualStyleBackColor = true;
            input_SNFN.Click += Input_SNFN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 51);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 85);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Имя";
            // 
            // Surname
            // 
            Surname.Location = new Point(232, 48);
            Surname.Name = "Surname";
            Surname.Size = new Size(100, 23);
            Surname.TabIndex = 3;
            // 
            // Firstname
            // 
            Firstname.Location = new Point(232, 82);
            Firstname.Name = "Firstname";
            Firstname.Size = new Size(100, 23);
            Firstname.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 116);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Дата Рождения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 153);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 6;
            label4.Text = "Паспорт(серия,№)";
            // 
            // BDate
            // 
            BDate.Location = new Point(232, 113);
            BDate.Name = "BDate";
            BDate.Size = new Size(100, 23);
            BDate.TabIndex = 7;
            // 
            // Pass
            // 
            Pass.Location = new Point(232, 150);
            Pass.Name = "Pass";
            Pass.Size = new Size(100, 23);
            Pass.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 189);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 9;
            label5.Text = "Университет";
            // 
            // Univer
            // 
            Univer.Location = new Point(232, 186);
            Univer.Name = "Univer";
            Univer.Size = new Size(100, 23);
            Univer.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { базаДанныхToolStripMenuItem, помощьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(517, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // базаДанныхToolStripMenuItem
            // 
            базаДанныхToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenMenuDataBase, сохранитьToolStripMenuItem });
            базаДанныхToolStripMenuItem.Name = "базаДанныхToolStripMenuItem";
            базаДанныхToolStripMenuItem.Size = new Size(87, 20);
            базаДанныхToolStripMenuItem.Text = "База данных";
            базаДанныхToolStripMenuItem.Click += базаДанныхToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem });
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(66, 20);
            помощьToolStripMenuItem.Text = "помощь";
            // 
            // OpenMenuDataBase
            // 
            OpenMenuDataBase.Name = "OpenMenuDataBase";
            OpenMenuDataBase.Size = new Size(180, 22);
            OpenMenuDataBase.Text = "Открыть";
            OpenMenuDataBase.Click += OpenMenuDataBase_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(180, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(180, 22);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 227);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 13;
            label6.Text = "Адрес";
            // 
            // GetAddress
            // 
            GetAddress.Location = new Point(232, 223);
            GetAddress.Name = "GetAddress";
            GetAddress.Size = new Size(100, 23);
            GetAddress.TabIndex = 14;
            GetAddress.Text = "Адрес";
            GetAddress.UseVisualStyleBackColor = true;
            GetAddress.Click += GetAddress_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(517, 362);
            Controls.Add(GetAddress);
            Controls.Add(label6);
            Controls.Add(Univer);
            Controls.Add(label5);
            Controls.Add(Pass);
            Controls.Add(BDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Firstname);
            Controls.Add(Surname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input_SNFN);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Первая форма";
            FormClosing += SmwForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button input_SNFN;
        private Label label1;
        private Label label2;
        private TextBox Surname;
        private TextBox Firstname;
        private Label label3;
        private Label label4;
        private TextBox BDate;
        private TextBox Pass;
        private Label label5;
        private TextBox Univer;
        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem базаДанныхToolStripMenuItem;
        private ToolStripMenuItem OpenMenuDataBase;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Label label6;
        private Button GetAddress;
    }
}
