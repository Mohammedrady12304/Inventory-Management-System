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
            RoundControl(btnLogin, 15);
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !checkBoxPass.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userRepo.Authenticate(txtName.Text, txtPass.Text);
            if (user != null)
            {
                lblError.Visible = false;
                MessageBox.Show($"Welcome {user.fullname}!", "ACCESS GRANTED",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); 

                Main mainForm = new Main(user);
                mainForm.Show();
                txtName.Clear();
                txtPass.Clear();
            }
            else
            {
                lblError.Text = "Invalid username or password!";
                lblError.Visible = true;
            }
        }

        private void RoundControl(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            control.Region = new Region(gp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Exit Application", "CONFIRM EXIT",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    

    }
}