using Class_Library.Context;
using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;

namespace Windows_Forms.Forms
{
    public partial class CustomerModuleForm : Form
    {
        private readonly CustomerRepository _customerRepo;
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public int SelectedCustomerId { get; set; } = 0;

        public CustomerModuleForm()
        {
            InitializeComponent();
            _customerRepo = new CustomerRepository(Program.DbContext);
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customer = new Customer
            {
                cname = txtName.Text.Trim(),
                cphone = txtPhone.Text.Trim()
            };

            _customerRepo.Add(customer);
            _customerRepo.Save();

            MessageBox.Show("Customer saved successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedCustomerId == 0) return;

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var customer = _customerRepo.GetById(SelectedCustomerId);
            if (customer == null) return;

            customer.cname = txtName.Text.Trim();
            customer.cphone = txtPhone.Text.Trim();

            _customerRepo.Update(customer);
            _customerRepo.Save();

            MessageBox.Show("Customer updated successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtPhone.Clear();
            SelectedCustomerId = 0;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void LoadForEdit(Customer customer)
        {
            SelectedCustomerId = customer.cid;
            txtName.Text = customer.cname;
            txtPhone.Text = customer.cphone;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }
    }
}