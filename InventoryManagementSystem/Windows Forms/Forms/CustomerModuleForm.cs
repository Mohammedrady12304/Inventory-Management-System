using Class_Library.Services;
using InventoryManagementSystem.ClassLibrary.Models;
using System.ComponentModel;

namespace Windows_Forms.Forms
{
    public partial class CustomerModuleForm : Form
    {
        private readonly CustomerRepository _customerRepo;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedCustomerId { get; set; } = 0;

        public CustomerModuleForm()
        {
            InitializeComponent();
            _customerRepo = new CustomerRepository(Program.DbContext);
            btnUpdate.Enabled = false;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e) => this.Dispose();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Are you sure you want to save this customer?",
                "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _customerRepo.Add(new Customer { cname = txtName.Text.Trim(), cphone = txtPhone.Text.Trim() });
                _customerRepo.Save();
                MessageBox.Show("Customer saved successfully.");
                this.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedCustomerId == 0) return;
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Are you sure you want to update this customer?",
                "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var customer = _customerRepo.GetById(SelectedCustomerId);
                if (customer == null) return;
                customer.cname = txtName.Text.Trim();
                customer.cphone = txtPhone.Text.Trim();
                _customerRepo.Update(customer);
                _customerRepo.Save();
                MessageBox.Show("Customer updated successfully.");
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear(); txtPhone.Clear();
            SelectedCustomerId = 0;
            btnSave.Enabled = true; btnUpdate.Enabled = false;
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