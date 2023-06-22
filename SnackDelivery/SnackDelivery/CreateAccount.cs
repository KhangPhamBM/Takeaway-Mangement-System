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
    public partial class CreateAccount : Form
    {
        SnackDeliveryContext _context = new SnackDeliveryContext();
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var account = new Account { Name = txt_accountName.Text, Password = txt_password.Text,
                PhoneNumber = txt_phonenum.Text, IsAdmin = Boolean.Parse(cbRole.Text), Deleted = false };
            _context.Accounts.Add(account); 
            _context.SaveChanges();
            this.Close();
        }
    }
}
