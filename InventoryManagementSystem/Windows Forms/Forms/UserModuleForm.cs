using Class_Library.Models;
using Class_Library.Services;
using System;
using System.Windows.Forms;

namespace Windows_Forms.Forms
{
    public partial class UserModuleForm : Form
    {
        private readonly UserRepository _userRepo;

        public UserModuleForm()
        {
            InitializeComponent();
            _userRepo = new UserRepository(Program.DbContext);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please fill all required fields.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPass.Text != txtRepass.Text)
            {
                MessageBox.Show("Password did not match!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userRepo.UsernameExists(txtUserName.Text))
            {
                MessageBox.Show("Username already exists!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to save this user?", "Saving Record",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var newUser = new User
                    {
                        username = txtUserName.Text,
                        fullname = txtFullName.Text,
                        password = txtPass.Text,
                        phone = txtPhone.Text
                    };

                    _userRepo.Add(newUser);
                    _userRepo.Save();
                    MessageBox.Show("User has been successfully saved.");
                    Clear();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtRepass.Text)
            {
                MessageBox.Show("Password did not match!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update this user?", "Update Record",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var existingUser = _userRepo.GetById(txtUserName.Text);

                    if (existingUser == null)
                    {
                        MessageBox.Show("User not found!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    existingUser.fullname = txtFullName.Text;
                    existingUser.password = txtPass.Text;
                    existingUser.phone = txtPhone.Text;

                    _userRepo.Update(existingUser);
                    _userRepo.Save();
                    MessageBox.Show("User has been successfully updated!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void Clear()
        {
            txtUserName.Clear();
            txtFullName.Clear();
            txtPass.Clear();
            txtRepass.Clear();
            txtPhone.Clear();
        }
    }
}