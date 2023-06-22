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
            LoadData();
            DataBinding();
        }

        public void DataBinding()
        {
            //   BindingSource source = new BindingSource();
            //   source.DataSource = GetProducts();
            txt_productId.DataBindings.Clear();
            txt_productName.DataBindings.Clear();
            txt_productPrice.DataBindings.Clear();
            txt_productDiscount.DataBindings.Clear();


            txt_accountId.DataBindings.Clear();
            txt_accountName.DataBindings.Clear();
            txt_accountPhonenum.DataBindings.Clear();
            cbb_role.DataBindings.Clear();

            txt_productId.DataBindings.Add(new Binding("Text", dgv_productList.DataSource, "Id"));
            txt_productName.DataBindings.Add(new Binding("Text", dgv_productList.DataSource, "Name"));
            txt_productPrice.DataBindings.Add(new Binding("Text", dgv_productList.DataSource, "Price"));
            txt_productDiscount.DataBindings.Add(new Binding("Text", dgv_productList.DataSource, "Discount"));

            txt_accountId.DataBindings.Add(new Binding("Text", dgv_account.DataSource, "Id"));
            txt_accountName.DataBindings.Add(new Binding("Text", dgv_account.DataSource, "Name"));
            txt_accountPhonenum.DataBindings.Add(new Binding("Text", dgv_account.DataSource, "PhoneNumber"));
            cbb_role.DataBindings.Add(new Binding("Text", dgv_account.DataSource, "IsAdmin"));







        }
        private void LoadData()
        {
            var products = (from p in _context.Products select new { Id = p.Id, Name = p.Name, Price = p.Price, Discount = p.Discount }).ToList();
            dgv_productList.DataSource = products;

            IEnumerable<Account> accounts = _context.Accounts.ToList();
            dgv_account.DataSource = accounts;


        }

        private void btn_viewallProduct_Click(object sender, EventArgs e)
        {
            var products = (from p in _context.Products select new { Id = p.Id, Name = p.Name, Price = p.Price, Discount = p.Discount }).ToList();
            dgv_productList.DataSource = products;
        }

        private void btn_viewallAccount_Click(object sender, EventArgs e)
        {
            IEnumerable<Account> accounts = _context.Accounts.ToList();
            dgv_account.DataSource = accounts;
        }

        private void btn_searchAccount_Click(object sender, EventArgs e)
        {

            if (txt_accountSearch.Text != null)
            {
                var search = _context.Accounts.Where(account => account.Name.Contains(txt_accountSearch.Text)).ToList();
                dgv_account.DataSource = search;

            }
            DataBinding();
        }

        private void btn_searchProduct_Click(object sender, EventArgs e)
        {
            if (txt_searchProduct.Text != null)
            {

                var search = _context.Products.Where(product => product.Name.Contains(txt_searchProduct.Text)).ToList();
                dgv_productList.DataSource = search;
            }
            DataBinding();

        }

        private void btn_updateProduct_Click(object sender, EventArgs e)
        {
            var productdto = _context.Products.Find(int.Parse(txt_productId.Text));
            if (productdto != null)
            {
                productdto.Name = txt_productName.Text;
                productdto.Price = double.Parse(txt_productPrice.Text);
                productdto.Discount = double.Parse(txt_productDiscount.Text);
                _context.SaveChanges();
            }
            DataBinding();
            LoadData();
        }
    }
}
