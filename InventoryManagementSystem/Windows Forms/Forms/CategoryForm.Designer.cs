namespace Windows_Forms.Forms
{
    partial class CategoryForm
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

            dgvCategory = new DataGridView();
            ColNo = new DataGridViewTextBoxColumn();
            ColCatId = new DataGridViewTextBoxColumn();
            ColCatName = new DataGridViewTextBoxColumn();
            ViewProducts = new DataGridViewButtonColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panel1 = new Panel();
            btnAdd = new Button();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();

            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            panel1.SuspendLayout(); SuspendLayout();

            headerStyle.BackColor = Color.DodgerBlue; headerStyle.ForeColor = Color.White;
            headerStyle.Font = new Font("Century Gothic", 9F);
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.WrapMode = DataGridViewTriState.True;
            rowStyle.BackColor = Color.White; rowStyle.ForeColor = Color.Black;
            rowStyle.Font = new Font("Century Gothic", 9F);

            dgvCategory.AllowUserToAddRows = false; dgvCategory.BackgroundColor = Color.White;
            dgvCategory.BorderStyle = BorderStyle.None;
            dgvCategory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategory.ColumnHeadersDefaultCellStyle = headerStyle;
            dgvCategory.ColumnHeadersHeight = 30;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategory.DefaultCellStyle = rowStyle; dgvCategory.EnableHeadersVisualStyles = false;
            dgvCategory.Dock = DockStyle.Fill; dgvCategory.RowHeadersVisible = false;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Name = "dgvCategory"; dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[]
                { ColNo, ColCatId, ColCatName, ViewProducts, Edit, Delete });

            ColNo.HeaderText = "No"; ColNo.Name = "ColNo"; ColNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; ColNo.ReadOnly = true;
            ColCatId.HeaderText = "Cat ID"; ColCatId.Name = "ColCatId"; ColCatId.Visible = false; ColCatId.ReadOnly = true;
            ColCatName.HeaderText = "Category Name"; ColCatName.Name = "ColCatName"; ColCatName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; ColCatName.ReadOnly = true;

            ViewProducts.HeaderText = ""; ViewProducts.Name = "ViewProducts"; ViewProducts.Text = "Products";
            ViewProducts.UseColumnTextForButtonValue = true; ViewProducts.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ViewProducts.FlatStyle = FlatStyle.Flat;
            ViewProducts.DefaultCellStyle.BackColor = Color.Teal; ViewProducts.DefaultCellStyle.ForeColor = Color.White;

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
            label1.ForeColor = Color.White; label1.Location = new Point(9, 15); label1.Text = "Manage Categories";
            label2.AutoSize = true; label2.BackColor = Color.White; label2.ForeColor = Color.Black;
            label2.Location = new Point(288, 18); label2.Text = "Search Box :";

            txtSearch.Location = new Point(404, 15); txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(270, 22); txtSearch.TextChanged += txtSearch_TextChanged;

            btnAdd.BackColor = Color.White; btnAdd.Location = new Point(720, 13);
            btnAdd.Name = "btnAdd"; btnAdd.Size = new Size(140, 25);
            btnAdd.Text = "Add Category"; btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            AutoScaleDimensions = new SizeF(7F, 17F); AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 506); Controls.Add(dgvCategory); Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F); FormBorderStyle = FormBorderStyle.None;
            Name = "CategoryForm"; Text = "Category Management";

            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            panel1.ResumeLayout(false); panel1.PerformLayout(); ResumeLayout(false);
        }

        private DataGridView dgvCategory;
        private Panel panel1;
        private Button btnAdd;
        private Label label1, label2;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn ColNo, ColCatId, ColCatName;
        private DataGridViewButtonColumn ViewProducts, Edit, Delete;
    }
}