using Class_Library.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly InventoryManagementContext _context;
        public DashboardForm()
        {
            InitializeComponent();
            _context = Program.DbContext;
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            lblTotalProducts.Text = _context.Products.Count().ToString();

            lblTotalCustomers.Text = _context.Customers.Count().ToString();

            var today = DateTime.Today;
            lblTodayOrders.Text = _context.Orders
                .Where(o => o.odate >= today).Count().ToString();

            lblLowStock.Text = _context.Products
                .Where(p => p.pqty < 5).Count().ToString();
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalCustomers_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
