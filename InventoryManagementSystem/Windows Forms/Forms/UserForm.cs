using Class_Library.Services;
using System;
using System.Windows.Forms;

namespace Windows_Forms.Forms
{
    public partial class UserForm : Form
    {
        private readonly UserRepository _userRepo;

        public UserForm()
        {
            InitializeComponent();
            _userRepo = new UserRepository(Program.DbContext);
            LoadUser();
        }

        public void LoadUser()
        {
            int i = 0;
            dgvUser.Rows.Clear();
            var users = _userRepo.GetAll();
            foreach (var user in users)
            {
                i++;
                dgvUser.Rows.Add(i, user.username, user.fullname, user.password, user.phone);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.btnSave.Enabled = true;
            userModule.btnUpdate.Enabled = false;
            userModule.ShowDialog();
            LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvUser.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                UserModuleForm userModule = new UserModuleForm();
                userModule.txtUserName.Text = dgvUser.Rows[e.RowIndex].Cells["ColUsername"].Value.ToString();
                userModule.txtFullName.Text = dgvUser.Rows[e.RowIndex].Cells["ColFullName"].Value.ToString();
                userModule.txtPass.Text = dgvUser.Rows[e.RowIndex].Cells["ColPassword"].Value.ToString();
                userModule.txtRepass.Text = dgvUser.Rows[e.RowIndex].Cells["ColPassword"].Value.ToString();
                userModule.txtPhone.Text = dgvUser.Rows[e.RowIndex].Cells["ColPhone"].Value.ToString();
                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.txtUserName.Enabled = false;
                userModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                string username = dgvUser.Rows[e.RowIndex].Cells["ColUsername"].Value.ToString()!;
                if (MessageBox.Show($"Are you sure you want to delete '{username}'?",
                    "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _userRepo.Delete(username);
                    _userRepo.Save();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }

            LoadUser();
        }
    }
}