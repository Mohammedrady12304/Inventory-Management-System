namespace Windows_Forms.Forms
{
    partial class OrderModuleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();

            panel1 = new Panel();
            btnExit = new Button(); 
            label1 = new Label();
            panel2 = new Panel();
            dgvCustomer = new DataGridView();
            txtSearchCust = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtCId = new TextBox();
            txtCName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            dgvProduct = new DataGridView();
            txtSearchProd = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtPid = new TextBox();
            txtPName = new TextBox();
            txtPrice = new TextBox();
            UDQty = new NumericUpDown();
            txtTotal = new TextBox();
            dtOrder = new DateTimePicker();
            btnInsert = new Button();
            btnClear = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();

          
            ColCNo = new DataGridViewTextBoxColumn();
            ColCid = new DataGridViewTextBoxColumn();
            ColCName2 = new DataGridViewTextBoxColumn();

            
            ColPNo = new DataGridViewTextBoxColumn();
            ColPid2 = new DataGridViewTextBoxColumn();
            ColPName2 = new DataGridViewTextBoxColumn();
            ColPQty = new DataGridViewTextBoxColumn();
            ColPPrice = new DataGridViewTextBoxColumn();
            ColPDes = new DataGridViewTextBoxColumn();
            ColPCat = new DataGridViewTextBoxColumn();

            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UDQty).BeginInit();
            SuspendLayout();

            
            // panel1 
            
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 49);
            panel1.TabIndex = 1;

            
            // btnExit
             
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(908, 12);   
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 25);     
            btnExit.TabIndex = 11;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += pictureBoxClose_Click;   

            
            // label1
            
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 19);
            label1.TabIndex = 1;
            label1.Text = "Order Module";

            
            // panel2 
            
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtCName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtCId);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtSearchCust);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvCustomer);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 539);
            panel2.TabIndex = 2;

            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F);
            label7.Location = new Point(24, 374);
            label7.Name = "label7";
            label7.Size = new Size(123, 17);
            label7.TabIndex = 17;
            label7.Text = "Customer Name :";

            txtCName.Enabled = false;
            txtCName.Location = new Point(27, 394);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(211, 22);
            txtCName.TabIndex = 16;

            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F);
            label6.Location = new Point(24, 317);
            label6.Name = "label6";
            label6.Size = new Size(95, 17);
            label6.TabIndex = 15;
            label6.Text = "Customer Id :";

            txtCId.Enabled = false;
            txtCId.Location = new Point(27, 343);
            txtCId.Name = "txtCId";
            txtCId.Size = new Size(211, 22);
            txtCId.TabIndex = 14;

            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F);
            label4.Location = new Point(24, 241);
            label4.Name = "label4";
            label4.Size = new Size(87, 17);
            label4.TabIndex = 13;
            label4.Text = "Search box :";

            txtSearchCust.Location = new Point(111, 238);
            txtSearchCust.Name = "txtSearchCust";
            txtSearchCust.Size = new Size(144, 22);
            txtSearchCust.TabIndex = 11;
            txtSearchCust.TextChanged += txtSearchCust_TextChanged;

            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(3, 276);
            label2.Name = "label2";
            label2.Size = new Size(92, 18);
            label2.TabIndex = 10;
            label2.Text = "CUSTOMER ";

            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.AllowUserToDeleteRows = false;
            dgvCustomer.BackgroundColor = Color.White;
            dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCustomer.ColumnHeadersHeight = 30;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { ColCNo, ColCid, ColCName2 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCustomer.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCustomer.Dock = DockStyle.Top;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.Location = new Point(0, 0);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(260, 232);
            dgvCustomer.TabIndex = 5;
            dgvCustomer.CellClick += dgvCustomer_CellClick;

            ColCNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColCNo.HeaderText = "No";
            ColCNo.Name = "ColCNo";
            ColCNo.Width = 48;

            ColCid.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColCid.HeaderText = "Customer Id";
            ColCid.Name = "ColCid";
            ColCid.Width = 102;

            ColCName2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCName2.HeaderText = "Name";
            ColCName2.Name = "ColCName2";

             
            // panel3
            
            panel3.Controls.Add(UDQty);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnInsert);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(dtOrder);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtPName);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtPrice);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtPid);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtSearchProd);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dgvProduct);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(274, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(659, 539);
            panel3.TabIndex = 3;

            UDQty.Location = new Point(510, 384);
            UDQty.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            UDQty.Name = "UDQty";
            UDQty.Size = new Size(137, 22);
            UDQty.TabIndex = 30;
            UDQty.ValueChanged += UDQty_ValueChanged;

            btnClear.BackColor = Color.Red;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(523, 490);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 37);
            btnClear.TabIndex = 29;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            btnInsert.BackColor = Color.FromArgb(0, 64, 0);
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(382, 490);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(124, 37);
            btnInsert.TabIndex = 27;
            btnInsert.Text = "Order Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;

            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F);
            label13.Location = new Point(4, 430);
            label13.Name = "label13";
            label13.Size = new Size(88, 17);
            label13.TabIndex = 26;
            label13.Text = "Order Date :";

            dtOrder.CustomFormat = "dd/MM/yyyy";
            dtOrder.Format = DateTimePickerFormat.Custom;
            dtOrder.Location = new Point(6, 452);
            dtOrder.Name = "dtOrder";
            dtOrder.Size = new Size(211, 22);
            dtOrder.TabIndex = 25;

            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9.75F);
            label12.Location = new Point(3, 374);
            label12.Name = "label12";
            label12.Size = new Size(111, 17);
            label12.TabIndex = 24;
            label12.Text = "Product Name :";

            txtPName.Enabled = false;
            txtPName.Location = new Point(6, 394);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(211, 22);
            txtPName.TabIndex = 23;

            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F);
            label11.Location = new Point(449, 428);
            label11.Name = "label11";
            label11.Size = new Size(47, 17);
            label11.TabIndex = 22;
            label11.Text = "Total :";

            txtTotal.Enabled = false;
            txtTotal.Location = new Point(510, 425);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(137, 22);
            txtTotal.TabIndex = 21;

            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F);
            label10.Location = new Point(449, 346);
            label10.Name = "label10";
            label10.Size = new Size(47, 17);
            label10.TabIndex = 20;
            label10.Text = "Price :";

            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F);
            label9.Location = new Point(449, 387);
            label9.Name = "label9";
            label9.Size = new Size(38, 17);
            label9.TabIndex = 18;
            label9.Text = "Qty :";

            txtPrice.Enabled = false;
            txtPrice.Location = new Point(510, 343);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(137, 22);
            txtPrice.TabIndex = 17;

            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F);
            label8.Location = new Point(3, 317);
            label8.Name = "label8";
            label8.Size = new Size(83, 17);
            label8.TabIndex = 16;
            label8.Text = "Product Id :";

            txtPid.Enabled = false;
            txtPid.Location = new Point(6, 343);
            txtPid.Name = "txtPid";
            txtPid.Size = new Size(211, 22);
            txtPid.TabIndex = 15;

            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F);
            label5.Location = new Point(254, 241);
            label5.Name = "label5";
            label5.Size = new Size(87, 17);
            label5.TabIndex = 14;
            label5.Text = "Search box :";

            txtSearchProd.Location = new Point(344, 238);
            txtSearchProd.Name = "txtSearchProd";
            txtSearchProd.Size = new Size(303, 22);
            txtSearchProd.TabIndex = 12;
            txtSearchProd.TextChanged += txtSearchProd_TextChanged;

            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold | FontStyle.Underline);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(3, 276);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 11;
            label3.Text = "PRODUCT";

            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvProduct.ColumnHeadersHeight = 30;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] {
                ColPNo, ColPid2, ColPName2, ColPQty, ColPPrice, ColPDes, ColPCat
            });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle8;
            dgvProduct.Dock = DockStyle.Top;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(659, 232);
            dgvProduct.TabIndex = 9;
            dgvProduct.CellClick += dgvProduct_CellClick;

            ColPNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPNo.HeaderText = "No";
            ColPNo.Name = "ColPNo";
            ColPNo.Width = 48;

            ColPid2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPid2.HeaderText = "Product Id";
            ColPid2.Name = "ColPid2";
            ColPid2.Width = 92;

            ColPName2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPName2.HeaderText = "Name";
            ColPName2.Name = "ColPName2";
            ColPName2.Width = 67;

            ColPQty.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPQty.HeaderText = "Qty";
            ColPQty.Name = "ColPQty";
            ColPQty.Width = 52;

            ColPPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPPrice.HeaderText = "Price";
            ColPPrice.Name = "ColPPrice";
            ColPPrice.Width = 61;

            ColPDes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColPDes.HeaderText = "Description";
            ColPDes.Name = "ColPDes";

            ColPCat.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColPCat.HeaderText = "Category";
            ColPCat.Name = "ColPCat";
            ColPCat.Width = 87;

            // 
            // OrderModuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 588);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderModuleForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)UDQty).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel panel1;
        private Button btnExit;          
        private Label label1;
        private Panel panel2;
        private DataGridView dgvCustomer;
        private TextBox txtSearchCust;
        private Label label2;
        private Label label4;
        private TextBox txtCId;
        private TextBox txtCName;
        private Label label6;
        private Label label7;
        private Panel panel3;
        private DataGridView dgvProduct;
        private TextBox txtSearchProd;
        private Label label3;
        private Label label5;
        private TextBox txtPid;
        private TextBox txtPName;
        private TextBox txtPrice;
        private NumericUpDown UDQty;
        private TextBox txtTotal;
        private DateTimePicker dtOrder;
        private Button btnInsert;
        private Button btnClear;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridViewTextBoxColumn ColCNo;
        private DataGridViewTextBoxColumn ColCid;
        private DataGridViewTextBoxColumn ColCName2;
        private DataGridViewTextBoxColumn ColPNo;
        private DataGridViewTextBoxColumn ColPid2;
        private DataGridViewTextBoxColumn ColPName2;
        private DataGridViewTextBoxColumn ColPQty;
        private DataGridViewTextBoxColumn ColPPrice;
        private DataGridViewTextBoxColumn ColPDes;
        private DataGridViewTextBoxColumn ColPCat;
    }
}