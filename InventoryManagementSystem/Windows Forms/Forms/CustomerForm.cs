using Class_Library.Context;
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

        private void LoadCustomers()
        {
            dgvCustomer.Rows.Clear();
            var customers = _customerRepo.GetAll().ToList();
            int no = 1;
            foreach (var c in customers)
            {
                dgvCustomer.Rows.Add(no++, c.cname, c.cphone, "Edit", "Delete");
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

            var customer = dgvCustomer.Rows[e.RowIndex].Tag as Customer;
            if (customer == null) return;

            // Edit
            if (e.ColumnIndex == dgvCustomer.Columns["Edit"].Index)
            {
                var moduleForm = new CustomerModuleForm();
                moduleForm.LoadForEdit(customer);
                moduleForm.FormClosed += (s, args) => LoadCustomers();
                moduleForm.ShowDialog();
            }

            // Delete
            if (e.ColumnIndex == dgvCustomer.Columns["Delete"].Index)
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete '{customer.cname}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _customerRepo.Delete(customer.cid);
                    _customerRepo.Save();
                    LoadCustomers();
                }
            }
        }
    }
}