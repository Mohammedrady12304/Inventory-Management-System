using Class_Library.Context;
using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;
using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Windows_Forms.Forms
{
    public partial class OrderModuleForm : Form
    {
        private readonly InventoryManagementContext _db;
        private readonly CustomerRepository _customerRepo;
        private readonly ProductRepository _productRepo;
        private int _selectedProductQty = 0;

        public OrderModuleForm()
        {
            InitializeComponent();

           

            _db = Program.DbContext;
            _customerRepo = new CustomerRepository(_db);
            _productRepo = new ProductRepository(_db);
            LoadCustomers();
            LoadProducts();
        }

        private void LoadCustomers()
        {
            dgvCustomer.Rows.Clear();
            var customers = _customerRepo.GetAll()
                .Where(c => c.cname.ToLower().Contains(txtSearchCust.Text.ToLower()) ||
                           c.cid.ToString().Contains(txtSearchCust.Text))
                .ToList();

            int no = 1;
            foreach (var c in customers)
            {
                dgvCustomer.Rows.Add(no++, c.cid, c.cname);
            }
        }

        private void LoadProducts()
        {
            dgvProduct.Rows.Clear();
            var products = _productRepo.GetAll()
                .Where(p => p.pname.ToLower().Contains(txtSearchProd.Text.ToLower()) ||
                           p.pid.ToString().Contains(txtSearchProd.Text))
                .ToList();

            int no = 1;
            foreach (var p in products)
            {
                dgvProduct.Rows.Add(no++, p.pid, p.pname, p.pqty, p.pprice, p.pdescription, p.pcategory);
            }
        }

        private void txtSearchCust_TextChanged(object sender, EventArgs e) => LoadCustomers();
        private void txtSearchProd_TextChanged(object sender, EventArgs e) => LoadProducts();

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtCId.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCName.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtPid.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            _selectedProductQty = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells[3].Value);
            CalculateTotal();
        }

        private void UDQty_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(UDQty.Value) > _selectedProductQty)
            {
                MessageBox.Show("Instock quantity is not enough!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UDQty.Value = Math.Max(0, _selectedProductQty);
                return;
            }
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (!string.IsNullOrEmpty(txtPrice.Text) && UDQty.Value > 0)
            {
                int total = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(UDQty.Value);
                txtTotal.Text = total.ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCId.Text))
            {
                MessageBox.Show("Please select customer!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtPid.Text))
            {
                MessageBox.Show("Please select product!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to insert this order?",
                "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var order = new Order
                    {
                        odate = dtOrder.Value,
                        pid = Convert.ToInt32(txtPid.Text),
                        cid = Convert.ToInt32(txtCId.Text),
                        qty = Convert.ToInt32(UDQty.Value),
                        price = Convert.ToInt32(txtPrice.Text),
                        total = Convert.ToInt32(txtTotal.Text)
                    };

                    _db.Orders.Add(order);

                    var product = _productRepo.GetById(order.pid);
                    if (product != null)
                    {
                        product.pqty -= order.qty;
                        _db.Products.Update(product);
                    }

                    _db.SaveChanges();

                    MessageBox.Show("Order has been successfully inserted.");
                    Clear();
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => Clear();

        public void Clear()
        {
            txtCId.Clear();
            txtCName.Clear();
            txtPid.Clear();
            txtPName.Clear();
            txtPrice.Clear();
            UDQty.Value = 0;
            txtTotal.Clear();
            dtOrder.Value = DateTime.Now;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e) => this.Dispose();
    }
}