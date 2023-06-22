namespace SnackDelivery
{
    partial class CreateAccount
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
            Password = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_accountName = new TextBox();
            txt_password = new TextBox();
            txt_phonenum = new TextBox();
            btn_save = new Button();
            cbRole = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 83);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(56, 119);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 159);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 191);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 3;
            label3.Text = "Role";
            // 
            // txt_accountName
            // 
            txt_accountName.Location = new Point(171, 75);
            txt_accountName.Name = "txt_accountName";
            txt_accountName.Size = new Size(163, 23);
            txt_accountName.TabIndex = 4;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(171, 111);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(163, 23);
            txt_password.TabIndex = 5;
            // 
            // txt_phonenum
            // 
            txt_phonenum.Location = new Point(171, 151);
            txt_phonenum.Name = "txt_phonenum";
            txt_phonenum.Size = new Size(163, 23);
            txt_phonenum.TabIndex = 6;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(150, 262);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "True", "False" });
            cbRole.Location = new Point(167, 188);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(167, 23);
            cbRole.TabIndex = 9;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 360);
            Controls.Add(cbRole);
            Controls.Add(btn_save);
            Controls.Add(txt_phonenum);
            Controls.Add(txt_password);
            Controls.Add(txt_accountName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Password);
            Controls.Add(label1);
            Name = "CreateAccount";
            Text = "CreateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Password;
        private Label label2;
        private Label label3;
        private TextBox txt_accountName;
        private TextBox txt_password;
        private TextBox txt_phonenum;
        private Button btn_save;
        private ComboBox cbRole;
    }
}