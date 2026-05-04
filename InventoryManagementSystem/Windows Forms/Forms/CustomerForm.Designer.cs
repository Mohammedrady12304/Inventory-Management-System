namespace Windows_Forms.Forms
{
    partial class CustomerForm
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

            dgvCustomer = new DataGridView();
            ColNo = new DataGridViewTextBoxColumn();
            ColCid = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColPhone = new DataGridViewTextBoxColumn();
            ViewOrders = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnAdd = new Button();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();

            headerStyle.BackColor = Color.DodgerBlue;
            headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Century Gothic", 9F);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.WrapMode = DataGridViewTriState.True;

            rowStyle.BackColor = Color.White;
            rowStyle.ForeColor = Color.Black;
            rowStyle.Font = new Font("Century Gothic", 9F);

            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCustomer.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvCustomer.ColumnHeadersHeight = 30;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomer.DefaultCellStyle = rowStyle;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[]
                { ColNo, ColCid, ColName, ColPhone, ViewOrders, Edit, Delete });

            ColNo.HeaderText = "No"; ColNo.Name = "ColNo"; ColNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ColNo.ReadOnly = true;
            ColCid.HeaderText = "ID"; ColCid.Name = "ColCid"; ColCid.Visible = false; ColCid.ReadOnly = true;
            ColName.HeaderText = "Full Name"; ColName.Name = "ColName"; ColName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; ColName.ReadOnly = true;
            ColPhone.HeaderText = "Phone"; ColPhone.Name = "ColPhone"; ColPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ColPhone.ReadOnly = true;

            ViewOrders.HeaderText = ""; ViewOrders.Name = "ViewOrders"; ViewOrders.Text = "Orders";
            ViewOrders.UseColumnTextForButtonValue = true; ViewOrders.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ViewOrders.FlatStyle = FlatStyle.Flat;
            ViewOrders.DefaultCellStyle.BackColor = Color.Teal; ViewOrders.DefaultCellStyle.ForeColor = Color.White;

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
            label1.ForeColor = Color.White; label1.Location = new Point(9, 15); label1.Text = "Manage Customers";

            label2.AutoSize = true; label2.BackColor = Color.White; label2.ForeColor = Color.Black;
            label2.Location = new Point(288, 18); label2.Text = "Search Box :";

            txtSearch.Location = new Point(404, 15); txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 22); txtSearch.TextChanged += txtSearch_TextChanged;

            btnAdd.BackColor = Color.White; btnAdd.Location = new Point(750, 13);
            btnAdd.Name = "btnAdd"; btnAdd.Size = new Size(125, 25);
            btnAdd.Text = "Add Customer"; btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            AutoScaleDimensions = new SizeF(7F, 17F); AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 506); Controls.Add(dgvCustomer); Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F); FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerForm"; Text = "Customer Management";

            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel1.ResumeLayout(false); panel1.PerformLayout(); ResumeLayout(false);
        }

        private DataGridView dgvCustomer;
        private Panel panel1;
        private Button btnAdd;
        private Label label1, label2;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn ColNo, ColCid, ColName, ColPhone;
        private DataGridViewButtonColumn ViewOrders, Edit, Delete;
    }
}