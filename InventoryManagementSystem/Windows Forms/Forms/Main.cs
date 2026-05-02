using Class_Library.Models;
using InventoryManagementSystem.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms.Forms
{
    public partial class Main : Form
    {
        private User _currentUser;
        public Main(User user)
        {
            InitializeComponent();
            _currentUser = user;
            SetupDashboard();
            openChildForm(new DashboardForm());
        }

        private void SetupDashboard()
        {
            lblWelcome.Text = $"Welcome, {_currentUser.fullname} ({_currentUser.role})";

            if (_currentUser.role != UserRole.Admin)
            {
                button5.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Exit Application", "CONFIRM EXIT",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //openChildForm(new Order());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new CustomerForm());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                LoginForm login = new LoginForm();
                login.ShowDialog();

                this.Close();
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
