﻿using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SnackDeliveryLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackDelivery
{
    public partial class Account_InfoForm : Form
    {
        private SnackDeliveryContext _context = new SnackDeliveryContext();
        public class OrderItem
        {
            public int productId { get; set; }
            public string? productName { get; set; }

            public float price { get; set; }
            public float discount { get; set; }
            public int quantity { get; set; }
            public float total { get; set; }
            public OrderItem()
            {

            }
        }
        BindingList<OrderItem> orderList;
        public Account_InfoForm()
        {
            InitializeComponent();
            orderList = new BindingList<OrderItem>();
            dgv_Order.DataSource = orderList;
        }

        public void DataBinding()
        {
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtDiscount.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text", dgv_Order.DataSource, "Id");
            txtProductName.DataBindings.Add("Text", dgv_Order.DataSource, "Name");
            txtPrice.DataBindings.Add("Text", dgv_Order.DataSource, "Price");
            txtDiscount.DataBindings.Add("Text", dgv_Order.DataSource, "Discount");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                var search = _context.Products
                    .Where(product => product.Name.Contains(txtSearch.Text))
                    .Select(p => new { Id = p.Id, Name = p.Name, Price = p.Price, Discount = p.Discount })
                    .FirstOrDefault();
                if (search != null)
                {
                    txtProductID.Text = search.Id.ToString();
                    txtProductName.Text = search.Name;
                    txtPrice.Text = search.Price.ToString();
                    txtDiscount.Text = search.Discount.ToString();
                }
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity) && quantity >= 1)
            {
                foreach (var existedItem in orderList)
                {
                    if (existedItem.productId.ToString() == txtProductID.Text)
                    {
                        if (quantity > 0)
                        {
                            var itemToUpdate = orderList.FirstOrDefault(o => o.productId == existedItem.productId);
                            if (itemToUpdate != null)
                            {
                                itemToUpdate.quantity += quantity;
                                refresh();
                                lbCurrentTotal.Text = getCurrentBill().ToString();
                            }
                        }
                        return;
                    }
                }
                var item = new OrderItem();
                item.productId = int.Parse(txtProductID.Text);
                item.productName = txtProductName.Text;
                item.price = float.Parse(txtPrice.Text);
                item.discount = float.Parse(txtDiscount.Text);
                item.quantity = quantity;
                item.total = (float)(quantity * item.price * (100 - item.discount) / 100);
                orderList.Add(item);
                lbCurrentTotal.Text = getCurrentBill().ToString();
                refresh();

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (!orderList.IsNullOrEmpty())
            {
                Order order = new Order();
                order.StaffId = 4;
                order.OrderDate = DateTime.Now;
                var addedOrder = _context.Orders.Add(order);
                _context.SaveChanges();
                if (addedOrder != null)
                {
                    foreach (var item in orderList)
                    {
                        OrderDetail detail = new OrderDetail();
                        detail.OrderId = addedOrder.Entity.Id;
                        detail.ProductId = item.productId;
                        detail.Quantity = item.quantity;
                        _context.OrderDetails.Add(detail);
                    }
                }
                _context.SaveChanges();
                reset();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            lbItemValue.Text = getItemValue(txtPrice.Text, txtDiscount.Text, txtQuantity.Text).ToString();
        }

        private float getItemValue(string price, string discount, string quantity)
        {
            if (int.TryParse(quantity, out int quan) && quan >= 1
                && float.TryParse(discount, out float dis)
                && float.TryParse(price, out float pri))
            {
                return (float)(quan * pri * (100 - dis) / 100);
            }
            return 0;
        }

        private float getCurrentBill()
        {
            float total = 0;
            foreach (var existedItem in orderList)
            {
                total += existedItem.total;
            }
            return total;
        }

        private void refresh()
        {
            dgv_Order.DataSource = null;
            dgv_Order.DataSource = orderList;
            foreach (var item in orderList)
            {
                item.total = getItemValue(item.price.ToString(), item.discount.ToString(), item.quantity.ToString());
            }
            lbCurrentTotal.Text = getCurrentBill().ToString();
        }

        private void reset()
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtQuantity.Text = string.Empty;

            // Clear the DataGridView
            dgv_Order.Rows.Clear();

            // Clear the orderList or create a new instance of it
            orderList.Clear(); // Or orderList = new List<OrderItem>();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name must not be left empty.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;


            if (String.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Phone number must not be left empty.", "Phonenumber Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (Regex.IsMatch(txtPhone.Text, @"^[0-9\s\-\+\(\)]+$"))
            {
                MessageBox.Show("Name must be in correct format.", "Number Only", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password must not be left empty.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(txtConfirm.Text))
            {
                MessageBox.Show("Confirm Password must not be left empty.", "Confirm Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Password and Confirm Password are not the same.", "Inccorect Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Account account = new Account();
            account.Name = txtName.Text;
            account.Password = txtPassword.Text;
            account.PhoneNumber = txtPhone.Text;
            account.IsAdmin = false;
            account.Deleted = false;
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }
    }
    }

