using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;

namespace Windows_Forms.Forms
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerRepository _customerRepo;

        public CustomerForm()
        {
            InitializeComponent();
            _customerRepo = new CustomerRepository(Program.DbContext);
            LoadCustomers();
        }

        public void LoadCustomers()
        {
            int i = 0;
            dgvCustomer.Rows.Clear();
            var customers = _customerRepo.SearchCustomers(txtSearch.Text);
            foreach (var c in customers)
            {
                i++;
                dgvCustomer.Rows.Add(i, c.cid, c.cname, c.cphone);
                dgvCustomer.Rows[dgvCustomer.Rows.Count - 1].Tag = c;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var moduleForm = new CustomerModuleForm();
            moduleForm.FormClosed += (s, args) => LoadCustomers();
            moduleForm.ShowDialog();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvCustomer.Columns[e.ColumnIndex].Name;
            var customer = dgvCustomer.Rows[e.RowIndex].Tag as Customer;
            if (customer == null) return;

            if (colName == "Edit")
            {
                var moduleForm = new CustomerModuleForm();
                moduleForm.LoadForEdit(customer);
                moduleForm.FormClosed += (s, args) => LoadCustomers();
                moduleForm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show($"Are you sure you want to delete '{customer.cname}'?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _customerRepo.Delete(customer.cid);
                    _customerRepo.Save();
                    LoadCustomers();
                }
            }
            else if (colName == "ViewOrders")
            {
                var fullCustomer = _customerRepo.GetByIdWithOrders(customer.cid);
                if (fullCustomer != null)
                    new CustomerOrdersForm(fullCustomer).ShowDialog();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadCustomers();
    }
}