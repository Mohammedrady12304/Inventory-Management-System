namespace Windows_Forms.Forms
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region category edit and delete buttons

        #endregion
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCategory = new DataGridView();
            ColNo = new DataGridViewTextBoxColumn();
            ColCatId = new DataGridViewTextBoxColumn();
            ColCatName = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // dgvCategory
            // 
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { ColNo, ColCatId, ColCatName, Edit, Delete });
            dgvCategory.Location = new Point(-3, 48);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.Size = new Size(803, 296);
            dgvCategory.TabIndex = 0;
            dgvCategory.CellContentClick += dgvCategory_CellContentClick;
            // 
            // ColNo
            // 
            ColNo.HeaderText = "No";
            ColNo.Name = "ColNo";
            // 
            // ColCatId
            // 
            ColCatId.HeaderText = "Cat ID";
            ColCatId.Name = "ColCatId";
            ColCatId.Visible = false;
            // 
            // ColCatName
            // 
            ColCatName.HeaderText = "Category Name";
            ColCatName.Name = "ColCatName";
            ColCatName.Width = 250;
            // 
            // Edit
            // 
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.ToolTipText = "Edit";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.ToolTipText = "Delete";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Category";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(dgvCategory);
            Name = "CategoryForm";
            Text = "CategoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategory;
        private Button btnAdd;
        private DataGridViewTextBoxColumn ColNo;
        private DataGridViewTextBoxColumn ColCatId;
        private DataGridViewTextBoxColumn ColCatName;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;

    }


}