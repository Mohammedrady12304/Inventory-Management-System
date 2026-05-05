using Class_Library.Models;
using Class_Library.Services;
using System.Text.RegularExpressions;

namespace Windows_Forms.Forms
{
    public partial class UserModuleForm : Form
    {
        private readonly UserRepository _userRepo;
        private ErrorProvider errorProvider;

        public UserModuleForm()
        {
            InitializeComponent();

            _userRepo = new UserRepository(Program.DbContext);

            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        // ================= VALIDATION METHODS =================

        private bool IsValidName(string input)
        {
            return Regex.IsMatch(input, @"^[a-zA-Z\s]+$");
        }

        private bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^(010|011|012|015)\d{8}$");
        }

        // ================= VALIDATE ALL INPUTS =================

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            // Username
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider.SetError(txtUserName, "Username is required");
                isValid = false;
            }
            else if (!IsValidName(txtUserName.Text))
            {
                errorProvider.SetError(txtUserName, "Username must contain letters only");
                isValid = false;
            }

            // Full Name
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Full name is required");
                isValid = false;
            }
            else if (!IsValidName(txtFullName.Text))
            {
                errorProvider.SetError(txtFullName, "Full name must contain letters only");
                isValid = false;
            }

            // Phone
            if (!IsValidPhone(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Phone must be 010/011/012/015 + 8 digits");
                isValid = false;
            }

            // Password
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                errorProvider.SetError(txtPass, "Password is required");
                isValid = false;
            }

            // Re-password
            if (txtPass.Text != txtRepass.Text)
            {
                errorProvider.SetError(txtRepass, "Passwords do not match");
                isValid = false;
            }

            return isValid;
        }

        // ================= EVENTS =================

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // ================= SAVE =================

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (_userRepo.UsernameExists(txtUserName.Text))
            {
                errorProvider.SetError(txtUserName, "Username already exists");
                return;
            }

            if (MessageBox.Show("Save this user?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _userRepo.Add(new User
                    {
                        username = txtUserName.Text.Trim(),
                        fullname = txtFullName.Text.Trim(),
                        password = txtPass.Text,
                        phone = txtPhone.Text.Trim(),
                        role = cmbRole.SelectedIndex == 0 ? UserRole.Admin : UserRole.User
                    });

                    _userRepo.Save();

                    Clear();
                    this.Close();

                    MessageBox.Show("User saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ================= UPDATE =================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            if (MessageBox.Show("Update this user?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var user = _userRepo.GetById(txtUserName.Text);

                    if (user == null)
                    {
                        MessageBox.Show("User not found!");
                        return;
                    }

                    user.fullname = txtFullName.Text.Trim();
                    user.password = txtPass.Text;
                    user.phone = txtPhone.Text.Trim();
                    user.role = cmbRole.SelectedIndex == 0 ? UserRole.Admin : UserRole.User;

                    _userRepo.Update(user);
                    _userRepo.Save();

                    Clear();
                    this.Close();

                    MessageBox.Show("User updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ================= CLEAR =================

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

            cmbRole.SelectedIndex = 1;

            errorProvider.Clear();
        }

        // ================= OPTIONAL UX IMPROVEMENTS =================

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}