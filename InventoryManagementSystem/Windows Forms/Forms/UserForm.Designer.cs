namespace Windows_Forms.Forms
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle rowStyle = new DataGridViewCellStyle();

            dgvUser = new DataGridView();
            ColNo = new DataGridViewTextBoxColumn();
            ColUsername = new DataGridViewTextBoxColumn();
            ColFullName = new DataGridViewTextBoxColumn();
            ColPassword = new DataGridViewTextBoxColumn();
            ColPhone = new DataGridViewTextBoxColumn();
            ColRole = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnAdd = new Button();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            panel1.SuspendLayout(); SuspendLayout();

            headerStyle.BackColor = Color.DodgerBlue; headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Century Gothic", 9F);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            rowStyle.BackColor = Color.White; rowStyle.ForeColor = Color.Black;
            rowStyle.Font = new Font("Century Gothic", 9F);

            dgvUser.AllowUserToAddRows = false; dgvUser.BackgroundColor = Color.White;
            dgvUser.BorderStyle = BorderStyle.None;
            dgvUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUser.ColumnHeadersDefaultCellStyle = headerStyle; dgvUser.ColumnHeadersHeight = 30;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.DefaultCellStyle = rowStyle; dgvUser.EnableHeadersVisualStyles = false;
            dgvUser.Dock = DockStyle.Fill; dgvUser.RowHeadersVisible = false;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Name = "dgvUser"; dgvUser.CellContentClick += dgvUser_CellContentClick;
            dgvUser.Columns.AddRange(new DataGridViewColumn[]
                { ColNo, ColUsername, ColFullName, ColPassword, ColPhone, ColRole, Edit, Delete });

            ColNo.HeaderText = "No"; ColNo.Name = "ColNo"; ColNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ColNo.ReadOnly = true;
            ColUsername.HeaderText = "Username"; ColUsername.Name = "ColUsername"; ColUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ColUsername.ReadOnly = true;
            ColFullName.HeaderText = "Full Name"; ColFullName.Name = "ColFullName"; ColFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; ColFullName.ReadOnly = true;
            ColPassword.HeaderText = "Password"; ColPassword.Name = "ColPassword"; ColPassword.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ColPassword.ReadOnly = true;
            ColPhone.HeaderText = "Phone"; ColPhone.Name = "ColPhone"; ColPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ColPhone.ReadOnly = true;
            ColRole.HeaderText = "Role"; ColRole.Name = "ColRole"; ColRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ColRole.ReadOnly = true;

            Edit.HeaderText = ""; Edit.Name = "Edit"; Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true; Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.DefaultCellStyle.BackColor = Color.Olive; Edit.DefaultCellStyle.ForeColor = Color.White;

            Delete.HeaderText = ""; Delete.Name = "Delete"; Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true; Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.FlatStyle = FlatStyle.Flat;
            Delete.DefaultCellStyle.BackColor = Color.Crimson; Delete.DefaultCellStyle.ForeColor = Color.White;

            panel1.BackColor = Color.DodgerBlue; panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAdd); panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch); panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom; panel1.Height = 50; panel1.Name = "panel1";

            label1.AutoSize = true; label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White; label1.Location = new Point(9, 15); label1.Text = "Manage Users";
            label2.AutoSize = true; label2.BackColor = Color.White; label2.ForeColor = Color.Black;
            label2.Location = new Point(288, 18); label2.Text = "Search Box :";

            txtSearch.Location = new Point(404, 15); txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 22); txtSearch.TextChanged += txtSearch_TextChanged;

            btnAdd.BackColor = Color.White; btnAdd.Location = new Point(750, 13);
            btnAdd.Name = "btnAdd"; btnAdd.Size = new Size(100, 25);
            btnAdd.Text = "Add User"; btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            AutoScaleDimensions = new SizeF(7F, 17F); AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 506); Controls.Add(dgvUser); Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F); FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm"; Text = "User Management";

            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            panel1.ResumeLayout(false); panel1.PerformLayout(); ResumeLayout(false);
        }

        private DataGridView dgvUser;
        private Panel panel1;
        private Button btnAdd;
        private Label label1, label2;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn ColNo, ColUsername, ColFullName, ColPassword, ColPhone, ColRole;
        private DataGridViewButtonColumn Edit, Delete;
    }
}