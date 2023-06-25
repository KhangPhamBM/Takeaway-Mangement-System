namespace SnackDelivery
{
    partial class AdminForm
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
            Report = new TabPage();
            lbl_total = new Label();
            label6 = new Label();
            dgv_report = new DataGridView();
            panel4 = new Panel();
            dateTimeStart = new DateTimePicker();
            btn_reportSearch = new Button();
            dateTimeEnd = new DateTimePicker();
            label5 = new Label();
            Account = new TabPage();
            panel9 = new Panel();
            btn_deleteAccount = new Button();
            btn_updateAccount = new Button();
            btn_create = new Button();
            txt_accountPhonenum = new TextBox();
            txt_accountName = new TextBox();
            txt_accountId = new TextBox();
            cbb_role = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel8 = new Panel();
            btn_viewallAccount = new Button();
            dgv_account = new DataGridView();
            panel7 = new Panel();
            btn_searchAccount = new Button();
            txt_accountSearch = new TextBox();
            label10 = new Label();
            Product_Page = new TabPage();
            panel3 = new Panel();
            btn_viewallProduct = new Button();
            panel2 = new Panel();
            btn_searchProduct = new Button();
            txt_searchProduct = new TextBox();
            lbl_name = new Label();
            panel1 = new Panel();
            btn_deleteProduct = new Button();
            btn_updateProduct = new Button();
            btn_createProduct = new Button();
            txt_productDiscount = new TextBox();
            txt_productPrice = new TextBox();
            txt_productName = new TextBox();
            txt_productId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_productList = new DataGridView();
            product = new TabControl();
            Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_report).BeginInit();
            panel4.SuspendLayout();
            Account.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_account).BeginInit();
            panel7.SuspendLayout();
            Product_Page.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).BeginInit();
            product.SuspendLayout();
            SuspendLayout();
            // 
            // Report
            // 
            Report.Controls.Add(lbl_total);
            Report.Controls.Add(label6);
            Report.Controls.Add(dgv_report);
            Report.Controls.Add(panel4);
            Report.Location = new Point(4, 24);
            Report.Name = "Report";
            Report.Padding = new Padding(3);
            Report.Size = new Size(861, 480);
            Report.TabIndex = 2;
            Report.Text = "Report";
            Report.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            lbl_total.BackColor = Color.Gainsboro;
            lbl_total.Location = new Point(199, 77);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(61, 15);
            lbl_total.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(161, 77);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 6;
            label6.Text = "Total";
            // 
            // dgv_report
            // 
            dgv_report.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_report.Location = new Point(133, 117);
            dgv_report.Name = "dgv_report";
            dgv_report.RowTemplate.Height = 25;
            dgv_report.Size = new Size(546, 287);
            dgv_report.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(dateTimeStart);
            panel4.Controls.Add(btn_reportSearch);
            panel4.Controls.Add(dateTimeEnd);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(80, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(706, 68);
            panel4.TabIndex = 4;
            // 
            // dateTimeStart
            // 
            dateTimeStart.Location = new Point(12, 13);
            dateTimeStart.Name = "dateTimeStart";
            dateTimeStart.Size = new Size(200, 23);
            dateTimeStart.TabIndex = 0;
            // 
            // btn_reportSearch
            // 
            btn_reportSearch.Location = new Point(596, 15);
            btn_reportSearch.Name = "btn_reportSearch";
            btn_reportSearch.Size = new Size(75, 23);
            btn_reportSearch.TabIndex = 3;
            btn_reportSearch.Text = "Search";
            btn_reportSearch.UseVisualStyleBackColor = true;
            btn_reportSearch.Click += btn_reportSearch_Click;
            // 
            // dateTimeEnd
            // 
            dateTimeEnd.Location = new Point(346, 13);
            dateTimeEnd.Name = "dateTimeEnd";
            dateTimeEnd.Size = new Size(200, 23);
            dateTimeEnd.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(270, 19);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 2;
            label5.Text = "to";
            // 
            // Account
            // 
            Account.Controls.Add(panel9);
            Account.Controls.Add(panel8);
            Account.Controls.Add(dgv_account);
            Account.Controls.Add(panel7);
            Account.Location = new Point(4, 24);
            Account.Name = "Account";
            Account.Padding = new Padding(3);
            Account.Size = new Size(861, 480);
            Account.TabIndex = 1;
            Account.Text = "Account";
            Account.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(btn_deleteAccount);
            panel9.Controls.Add(btn_updateAccount);
            panel9.Controls.Add(btn_create);
            panel9.Controls.Add(txt_accountPhonenum);
            panel9.Controls.Add(txt_accountName);
            panel9.Controls.Add(txt_accountId);
            panel9.Controls.Add(cbb_role);
            panel9.Controls.Add(label14);
            panel9.Controls.Add(label13);
            panel9.Controls.Add(label12);
            panel9.Controls.Add(label11);
            panel9.Location = new Point(505, 84);
            panel9.Name = "panel9";
            panel9.Size = new Size(350, 350);
            panel9.TabIndex = 3;
            // 
            // btn_deleteAccount
            // 
            btn_deleteAccount.Location = new Point(250, 223);
            btn_deleteAccount.Name = "btn_deleteAccount";
            btn_deleteAccount.Size = new Size(75, 23);
            btn_deleteAccount.TabIndex = 10;
            btn_deleteAccount.Text = "Delete";
            btn_deleteAccount.UseVisualStyleBackColor = true;
            btn_deleteAccount.Click += btn_deleteAccount_Click;
            // 
            // btn_updateAccount
            // 
            btn_updateAccount.Location = new Point(134, 223);
            btn_updateAccount.Name = "btn_updateAccount";
            btn_updateAccount.Size = new Size(75, 23);
            btn_updateAccount.TabIndex = 9;
            btn_updateAccount.Text = "Update";
            btn_updateAccount.UseVisualStyleBackColor = true;
            btn_updateAccount.Click += btn_updateAccount_Click;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(16, 223);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(75, 23);
            btn_create.TabIndex = 8;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // txt_accountPhonenum
            // 
            txt_accountPhonenum.Location = new Point(156, 101);
            txt_accountPhonenum.Name = "txt_accountPhonenum";
            txt_accountPhonenum.Size = new Size(169, 23);
            txt_accountPhonenum.TabIndex = 7;
            // 
            // txt_accountName
            // 
            txt_accountName.Location = new Point(156, 67);
            txt_accountName.Name = "txt_accountName";
            txt_accountName.Size = new Size(169, 23);
            txt_accountName.TabIndex = 6;
            // 
            // txt_accountId
            // 
            txt_accountId.Location = new Point(156, 33);
            txt_accountId.Name = "txt_accountId";
            txt_accountId.Size = new Size(169, 23);
            txt_accountId.TabIndex = 5;
            // 
            // cbb_role
            // 
            cbb_role.DisplayMember = "true";
            cbb_role.FormattingEnabled = true;
            cbb_role.Location = new Point(156, 135);
            cbb_role.Name = "cbb_role";
            cbb_role.Size = new Size(169, 23);
            cbb_role.TabIndex = 4;
            cbb_role.SelectedIndexChanged += cbb_role_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 135);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 3;
            label14.Text = "Role";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 101);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 2;
            label13.Text = "Phone number";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 67);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 1;
            label12.Text = "Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 33);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 0;
            label11.Text = "Account ID";
            // 
            // panel8
            // 
            panel8.Controls.Add(btn_viewallAccount);
            panel8.Location = new Point(504, 8);
            panel8.Name = "panel8";
            panel8.Size = new Size(351, 58);
            panel8.TabIndex = 2;
            // 
            // btn_viewallAccount
            // 
            btn_viewallAccount.Location = new Point(251, 31);
            btn_viewallAccount.Name = "btn_viewallAccount";
            btn_viewallAccount.Size = new Size(75, 23);
            btn_viewallAccount.TabIndex = 0;
            btn_viewallAccount.Text = "View all";
            btn_viewallAccount.UseVisualStyleBackColor = true;
            btn_viewallAccount.Click += btn_viewallAccount_Click;
            // 
            // dgv_account
            // 
            dgv_account.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_account.Location = new Point(8, 72);
            dgv_account.Name = "dgv_account";
            dgv_account.RowTemplate.Height = 25;
            dgv_account.Size = new Size(467, 362);
            dgv_account.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_searchAccount);
            panel7.Controls.Add(txt_accountSearch);
            panel7.Controls.Add(label10);
            panel7.Location = new Point(7, 8);
            panel7.Name = "panel7";
            panel7.Size = new Size(468, 58);
            panel7.TabIndex = 0;
            // 
            // btn_searchAccount
            // 
            btn_searchAccount.Location = new Point(390, 31);
            btn_searchAccount.Name = "btn_searchAccount";
            btn_searchAccount.Size = new Size(75, 23);
            btn_searchAccount.TabIndex = 2;
            btn_searchAccount.Text = "Search";
            btn_searchAccount.UseVisualStyleBackColor = true;
            btn_searchAccount.Click += btn_searchAccount_Click;
            // 
            // txt_accountSearch
            // 
            txt_accountSearch.Location = new Point(3, 32);
            txt_accountSearch.Name = "txt_accountSearch";
            txt_accountSearch.Size = new Size(281, 23);
            txt_accountSearch.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 11);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 0;
            label10.Text = "Hello, admin";
            // 
            // Product_Page
            // 
            Product_Page.Controls.Add(panel3);
            Product_Page.Controls.Add(panel2);
            Product_Page.Controls.Add(panel1);
            Product_Page.Controls.Add(dgv_productList);
            Product_Page.Location = new Point(4, 24);
            Product_Page.Name = "Product_Page";
            Product_Page.Padding = new Padding(3);
            Product_Page.Size = new Size(861, 480);
            Product_Page.TabIndex = 0;
            Product_Page.Text = "Product";
            Product_Page.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_viewallProduct);
            panel3.Location = new Point(563, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 40);
            panel3.TabIndex = 6;
            // 
            // btn_viewallProduct
            // 
            btn_viewallProduct.Location = new Point(193, 14);
            btn_viewallProduct.Name = "btn_viewallProduct";
            btn_viewallProduct.Size = new Size(75, 23);
            btn_viewallProduct.TabIndex = 0;
            btn_viewallProduct.Text = "View all";
            btn_viewallProduct.UseVisualStyleBackColor = true;
            btn_viewallProduct.Click += btn_viewallProduct_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_searchProduct);
            panel2.Controls.Add(txt_searchProduct);
            panel2.Controls.Add(lbl_name);
            panel2.Location = new Point(8, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 54);
            panel2.TabIndex = 5;
            // 
            // btn_searchProduct
            // 
            btn_searchProduct.Location = new Point(328, 31);
            btn_searchProduct.Name = "btn_searchProduct";
            btn_searchProduct.Size = new Size(75, 23);
            btn_searchProduct.TabIndex = 2;
            btn_searchProduct.Text = "Search";
            btn_searchProduct.UseVisualStyleBackColor = true;
            btn_searchProduct.Click += btn_searchProduct_Click;
            // 
            // txt_searchProduct
            // 
            txt_searchProduct.Location = new Point(6, 31);
            txt_searchProduct.Name = "txt_searchProduct";
            txt_searchProduct.Size = new Size(301, 23);
            txt_searchProduct.TabIndex = 1;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(6, 4);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(77, 15);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Hello, Admin";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_deleteProduct);
            panel1.Controls.Add(btn_updateProduct);
            panel1.Controls.Add(btn_createProduct);
            panel1.Controls.Add(txt_productDiscount);
            panel1.Controls.Add(txt_productPrice);
            panel1.Controls.Add(txt_productName);
            panel1.Controls.Add(txt_productId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(563, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 325);
            panel1.TabIndex = 4;
            // 
            // btn_deleteProduct
            // 
            btn_deleteProduct.Location = new Point(193, 217);
            btn_deleteProduct.Name = "btn_deleteProduct";
            btn_deleteProduct.Size = new Size(75, 23);
            btn_deleteProduct.TabIndex = 10;
            btn_deleteProduct.Text = "Delete";
            btn_deleteProduct.UseVisualStyleBackColor = true;
            btn_deleteProduct.Click += btn_deleteProduct_Click;
            // 
            // btn_updateProduct
            // 
            btn_updateProduct.Location = new Point(101, 217);
            btn_updateProduct.Name = "btn_updateProduct";
            btn_updateProduct.Size = new Size(75, 23);
            btn_updateProduct.TabIndex = 9;
            btn_updateProduct.Text = "Update";
            btn_updateProduct.UseVisualStyleBackColor = true;
            btn_updateProduct.Click += btn_updateProduct_Click;
            // 
            // btn_createProduct
            // 
            btn_createProduct.Location = new Point(9, 217);
            btn_createProduct.Name = "btn_createProduct";
            btn_createProduct.Size = new Size(75, 23);
            btn_createProduct.TabIndex = 8;
            btn_createProduct.Text = "Create";
            btn_createProduct.UseVisualStyleBackColor = true;
            btn_createProduct.Click += btn_createProduct_Click;
            // 
            // txt_productDiscount
            // 
            txt_productDiscount.Location = new Point(118, 151);
            txt_productDiscount.Name = "txt_productDiscount";
            txt_productDiscount.Size = new Size(150, 23);
            txt_productDiscount.TabIndex = 7;
            // 
            // txt_productPrice
            // 
            txt_productPrice.Location = new Point(118, 119);
            txt_productPrice.Name = "txt_productPrice";
            txt_productPrice.Size = new Size(150, 23);
            txt_productPrice.TabIndex = 6;
            // 
            // txt_productName
            // 
            txt_productName.Location = new Point(118, 87);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(150, 23);
            txt_productName.TabIndex = 5;
            // 
            // txt_productId
            // 
            txt_productId.Location = new Point(118, 55);
            txt_productId.Name = "txt_productId";
            txt_productId.Size = new Size(150, 23);
            txt_productId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 154);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Discount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 122);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 90);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 58);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Product ID";
            // 
            // dgv_productList
            // 
            dgv_productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productList.Location = new Point(8, 66);
            dgv_productList.Name = "dgv_productList";
            dgv_productList.RowTemplate.Height = 25;
            dgv_productList.Size = new Size(442, 322);
            dgv_productList.TabIndex = 0;
            // 
            // product
            // 
            product.Controls.Add(Product_Page);
            product.Controls.Add(Account);
            product.Controls.Add(Report);
            product.Location = new Point(0, 3);
            product.Name = "product";
            product.SelectedIndex = 0;
            product.Size = new Size(869, 508);
            product.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 512);
            Controls.Add(product);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Takeaway Mangement System";
            Report.ResumeLayout(false);
            Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_report).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            Account.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_account).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            Product_Page.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).EndInit();
            product.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage Report;
        private TabPage Account;
        private Panel panel9;
        private Button btn_deleteAccount;
        private Button btn_updateAccount;
        private Button btn_create;
        private TextBox txt_accountPhonenum;
        private TextBox txt_accountName;
        private TextBox txt_accountId;
        private ComboBox cbb_role;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Panel panel8;
        private Button btn_viewallAccount;
        private DataGridView dgv_account;
        private Panel panel7;
        private Button btn_searchAccount;
        private TextBox txt_accountSearch;
        private Label label10;
        private TabPage Product_Page;
        private Panel panel3;
        private Button btn_viewallProduct;
        private Panel panel2;
        private Button btn_searchProduct;
        private TextBox txt_searchProduct;
        private Label lbl_name;
        private Panel panel1;
        private Button btn_deleteProduct;
        private Button btn_updateProduct;
        private Button btn_createProduct;
        private TextBox txt_productDiscount;
        private TextBox txt_productPrice;
        private TextBox txt_productName;
        private TextBox txt_productId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_productList;
        private TabControl product;
        private DateTimePicker dateTimeEnd;
        private DateTimePicker dateTimeStart;
        private Panel panel4;
        private Button btn_reportSearch;
        private Label label5;
        private Label lbl_total;
        private Label label6;
        private DataGridView dgv_report;
    }
}