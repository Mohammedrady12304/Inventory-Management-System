using Class_Library.Models;
using Class_Library.Services;

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
            string search = txtSearch.Text.ToLower();
            var users = _userRepo.GetAll().Where(u =>
                u.username.ToLower().Contains(search) ||
                u.fullname.ToLower().Contains(search) ||
                u.phone.Contains(search));

            foreach (var user in users)
            {
                i++;
                dgvUser.Rows.Add(i, user.username, user.fullname, "••••••", user.phone, user.role.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserModuleForm userModule = new UserModuleForm();
            userModule.btnSave.Enabled = true; userModule.btnUpdate.Enabled = false;
            userModule.ShowDialog(); LoadUser();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvUser.Columns[e.ColumnIndex].Name;

            if (colName == "Edit")
            {
                string username = dgvUser.Rows[e.RowIndex].Cells["ColUsername"].Value.ToString()!;
                var user = _userRepo.GetById(username);
                if (user == null) return;
                UserModuleForm userModule = new UserModuleForm();
                userModule.txtUserName.Text = user.username;
                userModule.txtFullName.Text = user.fullname;
                userModule.txtPass.Text = user.password;
                userModule.txtRepass.Text = user.password;
                userModule.txtPhone.Text = user.phone;
                userModule.cmbRole.SelectedIndex = user.role == UserRole.Admin ? 0 : 1;
                userModule.btnSave.Enabled = false;
                userModule.btnUpdate.Enabled = true;
                userModule.txtUserName.Enabled = false;
                userModule.ShowDialog();
            }
            else if (colName == "Delete")
            {
                string username = dgvUser.Rows[e.RowIndex].Cells["ColUsername"].Value.ToString()!;
                if (MessageBox.Show($"Delete '{username}'?",
                    "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _userRepo.Delete(username);
                    _userRepo.Save();
                    MessageBox.Show("Record deleted!");
                }
            }
            LoadUser();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadUser();
    }
}