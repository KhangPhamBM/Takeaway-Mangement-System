namespace SnackDelivery
{
    partial class CreateProductForm
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
            txt_pName = new TextBox();
            txt_price = new TextBox();
            txt_discount = new TextBox();
            btn_save = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 56);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 96);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 135);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Discount";
            // 
            // txt_pName
            // 
            txt_pName.Location = new Point(189, 56);
            txt_pName.Name = "txt_pName";
            txt_pName.Size = new Size(174, 23);
            txt_pName.TabIndex = 3;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(189, 93);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(174, 23);
            txt_price.TabIndex = 4;
            // 
            // txt_discount
            // 
            txt_discount.Location = new Point(189, 132);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(174, 23);
            txt_discount.TabIndex = 5;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(176, 196);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 23);
            btn_save.TabIndex = 6;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(142, 9);
            label4.Name = "label4";
            label4.Size = new Size(123, 21);
            label4.TabIndex = 11;
            label4.Text = "Create Product";
            // 
            // CreateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 281);
            Controls.Add(label4);
            Controls.Add(btn_save);
            Controls.Add(txt_discount);
            Controls.Add(txt_price);
            Controls.Add(txt_pName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateProductForm";
            Text = "Takeaway Mangement System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_pName;
        private TextBox txt_price;
        private TextBox txt_discount;
        private Button btn_save;
        private Label label4;
    }
}