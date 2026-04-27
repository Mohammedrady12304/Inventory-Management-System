using Class_Library.Services;
using System;
using System.Windows.Forms;

namespace Windows_Forms.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepo;

        public LoginForm()
        {
            InitializeComponent();
            _userRepo = new UserRepository(Program.DbContext);
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !checkBoxPass.Checked;
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userRepo.Authenticate(txtName.Text, txtPass.Text);
            if (user != null)
            {
                MessageBox.Show($"Welcome {user.fullname}!", "ACCESS GRANTED",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "ACCESS DENIED",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}