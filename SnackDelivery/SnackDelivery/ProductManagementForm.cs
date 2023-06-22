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
    public partial class ProductManagementForm : Form
    {
        private SnackDeliveryContext _context = new SnackDeliveryContext();
        public ProductManagementForm()
        {
            InitializeComponent();

        }



        private void btn_viewallProduct_Click(object sender, EventArgs e)
        {
            IEnumerable<Product> products = _context.Products.ToList();
            dgv_productList.DataSource = products;
        }

        private void btn_viewallAccount_Click(object sender, EventArgs e)
        {
            IEnumerable<Account> accounts = _context.Accounts.ToList();
            dgv_account.DataSource= accounts;   
        }
    }
}
