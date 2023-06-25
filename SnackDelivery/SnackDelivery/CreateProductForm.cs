using SnackDeliveryLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackDelivery
{
    public partial class CreateProductForm : Form
    {
        private SnackDeliveryContext _context = new SnackDeliveryContext();

        public CreateProductForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_pName.Text != null && txt_price.Text != null && txt_discount.Text != null)
            {
                Product product = new Product
                {
                    Name = txt_pName.Text,
                    Price = double.Parse(txt_price.Text),
                    Discount = double.Parse(txt_price.Text),
                    Deleted = false
                };
                _context.Products.Add(product);
                _context.SaveChanges();
                this.Close();
            }
        }
    }
}
