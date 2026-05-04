namespace Windows_Forms.Forms
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            dgvOrder = new DataGridView();
            panel1 = new Panel();
            btnAdd = new Button();
            label1 = new Label();
            txtSearch = new TextBox();
            label2 = new Label();
            lblTotal = new Label();
            lblQty = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();

            ColNo = new DataGridViewTextBoxColumn();
            ColOrderId = new DataGridViewTextBoxColumn();
            ColDate = new DataGridViewTextBoxColumn();
            ColPid = new DataGridViewTextBoxColumn();
            ColPName = new DataGridViewTextBoxColumn();
            ColCid = new DataGridViewTextBoxColumn();
            ColCName = new DataGridViewTextBoxColumn();
            ColQty = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColTotal = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();

            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();

            // dgvOrder
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.BackgroundColor = Color.White;
            dgvOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrder.ColumnHeadersHeight = 30;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] {
                ColNo, ColOrderId, ColDate, ColPid, ColPName,
                ColCid, ColCName, ColQty, ColPrice, ColTotal, Delete
            });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvOrder.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOrder.Dock = DockStyle.Fill;
            dgvOrder.EnableHeadersVisualStyles = false;
            dgvOrder.Location = new Point(0, 0);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(992, 421);
            dgvOrder.TabIndex = 3;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;

            // Columns
            ColNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColNo.HeaderText = "No";
            ColNo.Name = "ColNo";
            ColNo.Width = 48;

            ColOrderId.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColOrderId.HeaderText = "Order Id";
            ColOrderId.Name = "ColOrderId";
            ColOrderId.Width = 79;

            ColDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColDate.HeaderText = "Order Date";
            ColDate.Name = "ColDate";
            ColDate.Width = 98;

            ColPid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPid.HeaderText = "Product Id";
            ColPid.Name = "ColPid";
            ColPid.Width = 92;

            ColPName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPName.HeaderText = "Product Name";
            ColPName.Name = "ColPName";
            ColPName.Width = 117;

            ColCid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColCid.HeaderText = "Customer Id";
            ColCid.Name = "ColCid";
            ColCid.Width = 102;

            ColCName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColCName.HeaderText = "Customer Name";
            ColCName.Name = "ColCName";
            ColCName.Width = 127;

            ColQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColQty.HeaderText = "Qty";
            ColQty.Name = "ColQty";
            ColQty.Width = 52;

            ColPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPrice.HeaderText = "Price";
            ColPrice.Name = "ColPrice";
            ColPrice.Width = 61;

            ColTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTotal.HeaderText = "Total Amount";
            ColTotal.Name = "ColTotal";

            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.ToolTipText = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 5;

            // panel1
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblQty);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 421);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 85);
            panel1.TabIndex = 2;

            // btnAdd
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(880, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add Order";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 0;
            label1.Text = "Manage Orders";

            // txtSearch
            txtSearch.Location = new Point(88, 51);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(302, 22);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 15;
            label2.Text = "Search In :";

            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(436, 10);
            label3.Name = "label3";
            label3.Size = new Size(117, 16);
            label3.TabIndex = 16;
            label3.Text = "Order Summary:";

            // label4
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(535, 35);
            label4.Name = "label4";
            label4.Size = new Size(31, 16);
            label4.TabIndex = 16;
            label4.Text = "Qty";

            // label5
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(644, 35);
            label5.Name = "label5";
            label5.Size = new Size(93, 16);
            label5.TabIndex = 16;
            label5.Text = "Total Amount";

            // lblQty
            lblQty.AutoSize = true;
            lblQty.ForeColor = Color.White;
            lblQty.Location = new Point(535, 55);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(16, 17);
            lblQty.TabIndex = 17;
            lblQty.Text = "0";

            // lblTotal
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(644, 55);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 17);
            lblTotal.TabIndex = 18;
            lblTotal.Text = "0.00";

            // OrderForm
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 506);
            Controls.Add(dgvOrder);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private DataGridView dgvOrder;
        private Panel panel1;
        private Button btnAdd;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private Label lblTotal;
        private Label lblQty;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridViewTextBoxColumn ColNo;
        private DataGridViewTextBoxColumn ColOrderId;
        private DataGridViewTextBoxColumn ColDate;
        private DataGridViewTextBoxColumn ColPid;
        private DataGridViewTextBoxColumn ColPName;
        private DataGridViewTextBoxColumn ColCid;
        private DataGridViewTextBoxColumn ColCName;
        private DataGridViewTextBoxColumn ColQty;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColTotal;
        private DataGridViewButtonColumn Delete;
    }
}