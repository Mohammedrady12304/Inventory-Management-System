using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;
using System;
using System.Windows.Forms;

namespace Windows_Forms.Forms
{
    public partial class OrderForm : Form
    {
        private readonly OrderRepository _orderRepo;

        public OrderForm()
        {
            InitializeComponent();
            _orderRepo = new OrderRepository(Program.DbContext);
            LoadOrders();
        }

        public void LoadOrders()
        {
            int i = 0;
            dgvOrder.Rows.Clear();

            var orders = _orderRepo.SearchOrders(txtSearch.Text);
            double totalAmount = 0;
            int totalQty = 0;

            foreach (var order in orders)
            {
                i++;
                dgvOrder.Rows.Add(
                    i,
                    order.oid,
                    order.odate.ToString("dd/MM/yyyy"),
                    order.pid,
                    order.Product?.pname ?? "N/A",
                    order.cid,
                    order.Customer?.cname ?? "N/A",
                    order.qty,
                    order.price,
                    order.total
                );
                totalAmount += order.total;
                totalQty += order.qty;
            }

            lblQty.Text = totalQty.ToString();
            lblTotal.Text = totalAmount.ToString("N2");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var moduleForm = new OrderModuleForm();
            moduleForm.FormClosed += (s, args) => LoadOrders();
            moduleForm.ShowDialog();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvOrder.Columns[e.ColumnIndex].Name;
            int orderId = Convert.ToInt32(dgvOrder.Rows[e.RowIndex].Cells["ColOrderId"].Value);

            if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this order?",
                    "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var order = _orderRepo.GetById(orderId);
                    if (order != null)
                    {
                        var productRepo = new ProductRepository(Program.DbContext);
                        var product = productRepo.GetById(order.pid);
                        if (product != null)
                        {
                            product.pqty += order.qty;
                            productRepo.Update(product);
                            productRepo.Save();
                        }

                        _orderRepo.Delete(orderId);
                        _orderRepo.Save();
                        MessageBox.Show("Order deleted successfully!");
                    }
                }
                LoadOrders();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}