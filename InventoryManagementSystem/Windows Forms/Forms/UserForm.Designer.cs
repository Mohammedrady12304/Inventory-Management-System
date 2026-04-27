namespace Windows_Forms.Forms
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            btnAdd = new System.Windows.Forms.Button();
            dgvUser = new System.Windows.Forms.DataGridView();
            topPanel = new System.Windows.Forms.Panel();
            ColNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();

            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();

            // topPanel
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Height = 50;
            topPanel.Controls.Add(btnAdd);

            // btnAdd
            btnAdd.Text = "Add User";
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(100, 30);
            btnAdd.Location = new System.Drawing.Point(10, 10);
            btnAdd.Click += btnAdd_Click;

            // dgvUser
            dgvUser.Name = "dgvUser";
            dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvUser.ReadOnly = true;
            dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.CellContentClick += dgvUser_CellContentClick;
            dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                ColNo, ColUsername, ColFullName, ColPassword, ColPhone, Edit, Delete
            });

            // Columns
            ColNo.Name = "ColNo";
            ColNo.HeaderText = "No.";
            ColNo.ReadOnly = true;

            ColUsername.Name = "ColUsername";
            ColUsername.HeaderText = "Username";
            ColUsername.ReadOnly = true;

            ColFullName.Name = "ColFullName";
            ColFullName.HeaderText = "Full Name";
            ColFullName.ReadOnly = true;

            ColPassword.Name = "ColPassword";
            ColPassword.HeaderText = "Password";
            ColPassword.ReadOnly = true;

            ColPhone.Name = "ColPhone";
            ColPhone.HeaderText = "Phone";
            ColPhone.ReadOnly = true;

            Edit.Name = "Edit";
            Edit.HeaderText = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;

            Delete.Name = "Delete";
            Delete.HeaderText = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgvUser);
            Controls.Add(topPanel);
            Name = "UserForm";
            this.Text = "User Management";

            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}