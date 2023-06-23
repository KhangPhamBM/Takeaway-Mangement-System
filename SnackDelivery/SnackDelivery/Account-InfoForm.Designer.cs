namespace SnackDelivery
{
    partial class Account_InfoForm
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
            tabStaff = new TabControl();
            pageOrder = new TabPage();
            label1 = new Label();
            lbCurrentTotal = new Label();
            lbDiscount = new Label();
            txtDiscount = new TextBox();
            dgv_Order = new DataGridView();
            lbTotal = new Label();
            btnAddToCart = new Button();
            btnCheckOut = new Button();
            lbProductName = new Label();
            lbPrice = new Label();
            lbQuantity = new Label();
            lbItemValue = new Label();
            lbProductID = new Label();
            lbHelloUser = new Label();
            btnSearch = new Button();
            txtQuantity = new TextBox();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtSearch = new TextBox();
            pageAccount = new TabPage();
            btSave = new Button();
            txtConfirm = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            lbConfirmPassword = new Label();
            lbPassword = new Label();
            lbPhonenumber = new Label();
            lbName = new Label();
            tabStaff.SuspendLayout();
            pageOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Order).BeginInit();
            pageAccount.SuspendLayout();
            SuspendLayout();
            // 
            // tabStaff
            // 
            tabStaff.Controls.Add(pageOrder);
            tabStaff.Controls.Add(pageAccount);
            tabStaff.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabStaff.Location = new Point(30, 61);
            tabStaff.Margin = new Padding(3, 4, 3, 4);
            tabStaff.Name = "tabStaff";
            tabStaff.SelectedIndex = 0;
            tabStaff.Size = new Size(912, 521);
            tabStaff.TabIndex = 0;
            // 
            // pageOrder
            // 
            pageOrder.Controls.Add(label1);
            pageOrder.Controls.Add(lbCurrentTotal);
            pageOrder.Controls.Add(lbDiscount);
            pageOrder.Controls.Add(txtDiscount);
            pageOrder.Controls.Add(dgv_Order);
            pageOrder.Controls.Add(lbTotal);
            pageOrder.Controls.Add(btnAddToCart);
            pageOrder.Controls.Add(btnCheckOut);
            pageOrder.Controls.Add(lbProductName);
            pageOrder.Controls.Add(lbPrice);
            pageOrder.Controls.Add(lbQuantity);
            pageOrder.Controls.Add(lbItemValue);
            pageOrder.Controls.Add(lbProductID);
            pageOrder.Controls.Add(lbHelloUser);
            pageOrder.Controls.Add(btnSearch);
            pageOrder.Controls.Add(txtQuantity);
            pageOrder.Controls.Add(txtProductID);
            pageOrder.Controls.Add(txtProductName);
            pageOrder.Controls.Add(txtPrice);
            pageOrder.Controls.Add(txtSearch);
            pageOrder.Location = new Point(4, 29);
            pageOrder.Margin = new Padding(3, 4, 3, 4);
            pageOrder.Name = "pageOrder";
            pageOrder.Padding = new Padding(3, 4, 3, 4);
            pageOrder.Size = new Size(904, 488);
            pageOrder.TabIndex = 0;
            pageOrder.Text = "Order";
            pageOrder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 455);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 26;
            label1.Text = "Total: ";
            // 
            // lbCurrentTotal
            // 
            lbCurrentTotal.AutoSize = true;
            lbCurrentTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbCurrentTotal.Location = new Point(101, 455);
            lbCurrentTotal.Name = "lbCurrentTotal";
            lbCurrentTotal.Size = new Size(17, 20);
            lbCurrentTotal.TabIndex = 25;
            lbCurrentTotal.Text = "0";
            lbCurrentTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbDiscount.Location = new Point(440, 111);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(67, 20);
            lbDiscount.TabIndex = 24;
            lbDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Anchor = AnchorStyles.None;
            txtDiscount.Location = new Point(549, 106);
            txtDiscount.Margin = new Padding(3, 4, 3, 4);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(163, 27);
            txtDiscount.TabIndex = 23;
            // 
            // dgv_Order
            // 
            dgv_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Order.Location = new Point(52, 212);
            dgv_Order.Margin = new Padding(3, 4, 3, 4);
            dgv_Order.Name = "dgv_Order";
            dgv_Order.RowHeadersWidth = 51;
            dgv_Order.RowTemplate.Height = 25;
            dgv_Order.Size = new Size(805, 229);
            dgv_Order.TabIndex = 22;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotal.Location = new Point(440, 182);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(42, 20);
            lbTotal.TabIndex = 21;
            lbTotal.Text = "Total";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(763, 103);
            btnAddToCart.Margin = new Padding(3, 4, 3, 4);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(118, 31);
            btnAddToCart.TabIndex = 20;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(763, 140);
            btnCheckOut.Margin = new Padding(3, 4, 3, 4);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(118, 31);
            btnCheckOut.TabIndex = 19;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductName.Location = new Point(39, 147);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(104, 20);
            lbProductName.TabIndex = 18;
            lbProductName.Text = "Product Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(39, 182);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 17;
            lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuantity.Location = new Point(440, 146);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(65, 20);
            lbQuantity.TabIndex = 16;
            lbQuantity.Text = "Quantity";
            // 
            // lbItemValue
            // 
            lbItemValue.AutoSize = true;
            lbItemValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbItemValue.Location = new Point(548, 182);
            lbItemValue.Name = "lbItemValue";
            lbItemValue.Size = new Size(49, 20);
            lbItemValue.TabIndex = 15;
            lbItemValue.Text = "10000";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductID.Location = new Point(39, 113);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(79, 20);
            lbProductID.TabIndex = 14;
            lbProductID.Text = "Product ID";
            // 
            // lbHelloUser
            // 
            lbHelloUser.AutoSize = true;
            lbHelloUser.Location = new Point(34, 24);
            lbHelloUser.Name = "lbHelloUser";
            lbHelloUser.Size = new Size(53, 20);
            lbHelloUser.TabIndex = 13;
            lbHelloUser.Text = "Hello, ";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(404, 57);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(101, 31);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(549, 141);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(163, 27);
            txtQuantity.TabIndex = 11;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(148, 107);
            txtProductID.Margin = new Padding(3, 4, 3, 4);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(163, 27);
            txtProductID.TabIndex = 10;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(148, 142);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(163, 27);
            txtProductName.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(148, 177);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(163, 27);
            txtPrice.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(39, 57);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(311, 27);
            txtSearch.TabIndex = 7;
            // 
            // pageAccount
            // 
            pageAccount.BackColor = Color.White;
            pageAccount.Controls.Add(btSave);
            pageAccount.Controls.Add(txtConfirm);
            pageAccount.Controls.Add(txtPassword);
            pageAccount.Controls.Add(txtPhone);
            pageAccount.Controls.Add(txtName);
            pageAccount.Controls.Add(lbConfirmPassword);
            pageAccount.Controls.Add(lbPassword);
            pageAccount.Controls.Add(lbPhonenumber);
            pageAccount.Controls.Add(lbName);
            pageAccount.Location = new Point(4, 29);
            pageAccount.Margin = new Padding(3, 4, 3, 4);
            pageAccount.Name = "pageAccount";
            pageAccount.Padding = new Padding(3, 4, 3, 4);
            pageAccount.Size = new Size(904, 488);
            pageAccount.TabIndex = 1;
            pageAccount.Text = "Account";
            // 
            // btSave
            // 
            btSave.Location = new Point(366, 306);
            btSave.Name = "btSave";
            btSave.Size = new Size(161, 36);
            btSave.TabIndex = 8;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(450, 240);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(203, 27);
            txtConfirm.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(450, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(203, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(450, 165);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(203, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(450, 127);
            txtName.Name = "txtName";
            txtName.Size = new Size(203, 27);
            txtName.TabIndex = 4;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(265, 247);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(137, 20);
            lbConfirmPassword.TabIndex = 3;
            lbConfirmPassword.Text = "Confirm Password";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(265, 209);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(76, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbPhonenumber
            // 
            lbPhonenumber.AutoSize = true;
            lbPhonenumber.Location = new Point(265, 172);
            lbPhonenumber.Name = "lbPhonenumber";
            lbPhonenumber.Size = new Size(112, 20);
            lbPhonenumber.TabIndex = 1;
            lbPhonenumber.Text = "Phone number";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(265, 134);
            lbName.Name = "lbName";
            lbName.Size = new Size(51, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // Account_InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 757);
            Controls.Add(tabStaff);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Account_InfoForm";
            Text = "Account_InfoForm";
            tabStaff.ResumeLayout(false);
            pageOrder.ResumeLayout(false);
            pageOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Order).EndInit();
            pageAccount.ResumeLayout(false);
            pageAccount.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabStaff;
        private TabPage pageOrder;
        private TabPage pageAccount;
        private Label lbTotal;
        private Button btnAddToCart;
        private Button btnCheckOut;
        private Label lbProductName;
        private Label lbPrice;
        private Label lbQuantity;
        private Label lbItemValue;
        private Label lbProductID;
        private Label lbHelloUser;
        private Button btnSearch;
        private TextBox txtQuantity;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtSearch;
        private DataGridView dgv_Order;
        private Label lbDiscount;
        private TextBox txtDiscount;
        private Label lbCurrentTotal;
        private Label lbName;
        private Label label1;
        private Button btSave;
        private TextBox txtConfirm;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label lbConfirmPassword;
        private Label lbPassword;
        private Label lbPhonenumber;
    }
}