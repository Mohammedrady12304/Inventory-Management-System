using Class_Library.Models;
using Class_Library.Services;

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

        private void pictureBoxClose_Click(object sender, EventArgs e) => this.Dispose();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            { MessageBox.Show("Please fill all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (txtPass.Text != txtRepass.Text)
            { MessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (_userRepo.UsernameExists(txtUserName.Text))
            { MessageBox.Show("Username already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("Save this user?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _userRepo.Add(new User
                    {
                        username = txtUserName.Text,
                        fullname = txtFullName.Text,
                        password = txtPass.Text,
                        phone = txtPhone.Text,
                        role = cmbRole.SelectedIndex == 0 ? UserRole.Admin : UserRole.User
                    });
                    _userRepo.Save();
                    MessageBox.Show("User saved successfully.");
                    Clear(); this.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != txtRepass.Text)
            { MessageBox.Show("Passwords do not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (MessageBox.Show("Update this user?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var user = _userRepo.GetById(txtUserName.Text);
                    if (user == null) { MessageBox.Show("User not found!"); return; }
                    user.fullname = txtFullName.Text; user.password = txtPass.Text;
                    user.phone = txtPhone.Text;
                    user.role = cmbRole.SelectedIndex == 0 ? UserRole.Admin : UserRole.User;
                    _userRepo.Update(user); _userRepo.Save();
                    MessageBox.Show("User updated successfully!"); this.Close();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e) { Clear(); btnSave.Enabled = true; btnUpdate.Enabled = false; }

        public void Clear()
        {
            txtUserName.Clear(); txtFullName.Clear(); txtPass.Clear(); txtRepass.Clear(); txtPhone.Clear();
            cmbRole.SelectedIndex = 1;
        }
    }
}