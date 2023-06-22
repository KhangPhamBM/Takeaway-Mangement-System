using Microsoft.EntityFrameworkCore;
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
    public partial class AdminForm : Form
    {
        private SnackDeliveryContext _context = new SnackDeliveryContext();
        public AdminForm()
        {
            InitializeComponent();
            LoadData();

        }

        public void DataBinding()
        {

            txt_productId.DataBindings.Clear();
            txt_productName.DataBindings.Clear();
            txt_productPrice.DataBindings.Clear();
            txt_productDiscount.DataBindings.Clear();

            txt_productId.DataBindings.Add(new Binding("Text", dgv_productList.DataSource, "Id"));
            txt_productName.DataBindings.Add(new Binding("Text", dgv_productList.DataSource, "Name"));
            txt_productPrice.DataBindings.Add("Text", dgv_productList.DataSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged, 0);
            txt_productDiscount.DataBindings.Add("Text", dgv_productList.DataSource, "Discount", true, DataSourceUpdateMode.OnPropertyChanged, 0);


            txt_accountId.DataBindings.Clear();
            txt_accountName.DataBindings.Clear();
            txt_accountPhonenum.DataBindings.Clear();
            cbb_role.DataBindings.Clear();



            txt_accountId.DataBindings.Add(new Binding("Text", dgv_account.DataSource, "Id"));
            txt_accountName.DataBindings.Add(new Binding("Text", dgv_account.DataSource, "Name"));
            txt_accountPhonenum.DataBindings.Add(new Binding("Text", dgv_account.DataSource, "PhoneNumber"));
            //cbb_role.DataBindings.Add(new Binding("SelectedItem", dgv_account.DataSource, "IsAdmin"));

        }
        public void LoadData()
        {
            var products = (from p in _context.Products where p.Deleted == false select new { Id = p.Id, Name = p.Name, Price = p.Price, Discount = p.Discount }).ToList();
            dgv_productList.DataSource = products;

            IEnumerable<Account> accounts = _context.Accounts.ToList();
            dgv_account.DataSource = accounts;
            // Clear existing items
            cbb_role.Items.Add(true);
            cbb_role.Items.Add(false);


            DataBinding();

        }

        private void btn_viewallProduct_Click(object sender, EventArgs e)
        {
            var products = (from p in _context.Products where p.Deleted == false select new { Id = p.Id, Name = p.Name, Price = p.Price, Discount = p.Discount }).ToList();
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
            LoadData();

        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            var productdto = _context.Products.Find(int.Parse(txt_productId.Text));
            if (productdto != null)
            {
                productdto.Deleted = true;
                _context.SaveChanges();
            }
            LoadData();

        }

        private void btn_createProduct_Click(object sender, EventArgs e)
        {
            CreateProductForm createProductForm = new CreateProductForm();
            createProductForm.Show();
        }

        private void btn_updateAccount_Click(object sender, EventArgs e)
        {
            var accountdto = _context.Accounts.Find(int.Parse(txt_accountId.Text));
            if (accountdto != null)
            {
                accountdto.Name = txt_accountName.Text;
                accountdto.PhoneNumber = txt_accountPhonenum.Text;
                accountdto.IsAdmin = Boolean.Parse(cbb_role.Text);
                _context.SaveChanges();

            }
            LoadData();

        }

        private void cbb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_deleteAccount_Click(object sender, EventArgs e)
        {
            var accountdto = _context.Accounts.Find(int.Parse(txt_accountId.Text));
            if (accountdto != null)
            {
                accountdto.Deleted = true;
                _context.SaveChanges();
            }
            LoadData();

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        private void btn_reportSearch_Click(object sender, EventArgs e)
        {
            var orders = _context.Orders
      .Where(o => o.OrderDate >= dateTimeStart.Value && o.OrderDate < dateTimeEnd.Value)
      .ToList();
            double totalAmount = (double)_context.Orders
            .Where(o => o.OrderDate >= dateTimeStart.Value && o.OrderDate <= dateTimeEnd.Value)
            .Join(_context.OrderDetails,
                order => order.Id,
                orderDetail => orderDetail.Id,
                (order, orderDetail) => new { Order = order, OrderDetail = orderDetail })
            .Join(_context.Products,
                od => od.OrderDetail.ProductId,
                product => product.Id,
                (od, product) => new { OrderDetail = od.OrderDetail, Product = product })
            .Sum(odp => odp.OrderDetail.Quantity * odp.Product.Price);
            lbl_total.Text = totalAmount.ToString();
            dgv_report.DataSource = orders;

        }
    }
}
