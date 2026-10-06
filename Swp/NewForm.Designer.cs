namespace Swp
{
    partial class AddressForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Address1 = new TextBox();
            Address2 = new TextBox();
            Address3 = new TextBox();
            InputAddress = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Страна,область";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Населенный пункт";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 2;
            label3.Text = "Улица,дом,квартира";
            label3.Click += label3_Click;
            // 
            // Address1
            // 
            Address1.Location = new Point(137, 20);
            Address1.Name = "Address1";
            Address1.Size = new Size(272, 23);
            Address1.TabIndex = 3;
            // 
            // Address2
            // 
            Address2.Location = new Point(137, 51);
            Address2.Name = "Address2";
            Address2.Size = new Size(272, 23);
            Address2.TabIndex = 4;
            // 
            // Address3
            // 
            Address3.Location = new Point(137, 83);
            Address3.Name = "Address3";
            Address3.Size = new Size(272, 23);
            Address3.TabIndex = 5;
            // 
            // InputAddress
            // 
            InputAddress.Location = new Point(314, 135);
            InputAddress.Name = "InputAddress";
            InputAddress.Size = new Size(118, 23);
            InputAddress.TabIndex = 6;
            InputAddress.Text = "Ввод";
            InputAddress.UseVisualStyleBackColor = true;
            InputAddress.Click += InputAddress_Click;
            // 
            // AddressForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(444, 170);
            Controls.Add(InputAddress);
            Controls.Add(Address3);
            Controls.Add(Address2);
            Controls.Add(Address1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddressForm";
            Text = "Адрес";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public TextBox Address1;
        public TextBox Address2;
        public TextBox Address3;
        private Button InputAddress;
    }
}