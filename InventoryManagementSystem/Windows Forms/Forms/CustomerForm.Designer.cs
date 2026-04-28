namespace Windows_Forms.Forms
{
    partial class CustomerForm
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
            dgvCustomer = new System.Windows.Forms.DataGridView();
            topPanel = new System.Windows.Forms.Panel();
            ColNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();

            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            topPanel.SuspendLayout();
            SuspendLayout();

            // topPanel
            topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            topPanel.Height = 50;
            topPanel.Controls.Add(btnAdd);

            // btnAdd
            btnAdd.Text = "Add Customer";
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(110, 30);
            btnAdd.Location = new System.Drawing.Point(10, 10);
            btnAdd.Click += btnAdd_Click;

            // dgvCustomer
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvCustomer.ReadOnly = true;
            dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                ColNo, ColName, ColPhone, Edit, Delete
            });

            // Columns
            ColNo.Name = "ColNo";
            ColNo.HeaderText = "No.";
            ColNo.ReadOnly = true;

            ColName.Name = "ColName";
            ColName.HeaderText = "Full Name";
            ColName.ReadOnly = true;

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
            Controls.Add(dgvCustomer);
            Controls.Add(topPanel);
            Name = "CustomerForm";
            Text = "Customer Management";

            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}