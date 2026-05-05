using Class_Library.Context;
using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;
using System.Text.RegularExpressions;

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
        private bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && !Regex.IsMatch(name, @"^\d+$");
        }
        private bool IsValidPhone(string Phone)
        {
            return Regex.IsMatch(Phone, @"^(010|011|012|015)\d{8}$");
        }
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the customer name.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!IsValidName(txtName.Text.Trim()))
            {
                MessageBox.Show("Customer name cannot be numbers only.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter the phone number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            if (!IsValidPhone(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Phone must start with 010, 011, 012, or 015 and be 11 digits.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

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
            if (!ValidateInputs()) return;

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