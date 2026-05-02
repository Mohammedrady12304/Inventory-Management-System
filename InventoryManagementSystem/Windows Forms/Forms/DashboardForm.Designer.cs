namespace Windows_Forms.Forms
{
    partial class DashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lblTotalProducts = new Label();
            lbl = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblTotalCustomers = new Label();
            L1 = new Label();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            lblLowStock = new Label();
            l3 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            lblTodayOrders = new Label();
            l2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label5 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblTotalProducts);
            panel1.Controls.Add(lbl);
            panel1.Location = new Point(4, 166);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 97);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.productCart;
            pictureBox2.Location = new Point(42, 13);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // lblTotalProducts
            // 
            lblTotalProducts.AutoSize = true;
            lblTotalProducts.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold);
            lblTotalProducts.ForeColor = Color.MidnightBlue;
            lblTotalProducts.Location = new Point(58, 68);
            lblTotalProducts.Name = "lblTotalProducts";
            lblTotalProducts.Size = new Size(75, 19);
            lblTotalProducts.TabIndex = 5;
            lblTotalProducts.Text = "Total ";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = SystemColors.ButtonShadow;
            lbl.Location = new Point(9, 44);
            lbl.Name = "lbl";
            lbl.Size = new Size(133, 15);
            lbl.TabIndex = 4;
            lbl.Text = "Total Products";
            lbl.Click += lbl_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTotalCustomers);
            panel2.Controls.Add(L1);
            panel2.Location = new Point(150, 166);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 97);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UserIcon;
            pictureBox1.Location = new Point(49, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold);
            lblTotalCustomers.ForeColor = Color.MidnightBlue;
            lblTotalCustomers.Location = new Point(57, 68);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(64, 19);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "Total";
            lblTotalCustomers.Click += lblTotalCustomers_Click;
            // 
            // L1
            // 
            L1.AutoSize = true;
            L1.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            L1.ForeColor = SystemColors.ButtonShadow;
            L1.Location = new Point(3, 44);
            L1.Name = "L1";
            L1.Size = new Size(142, 15);
            L1.TabIndex = 0;
            L1.Text = "Total Customers";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(lblLowStock);
            panel3.Controls.Add(l3);
            panel3.Location = new Point(443, 166);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 97);
            panel3.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.StocklowIcon;
            pictureBox4.Location = new Point(52, 13);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 27);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold);
            lblLowStock.ForeColor = Color.MidnightBlue;
            lblLowStock.Location = new Point(52, 68);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(64, 19);
            lblLowStock.TabIndex = 2;
            lblLowStock.Text = "Total";
            // 
            // l3
            // 
            l3.AutoSize = true;
            l3.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l3.ForeColor = SystemColors.ButtonShadow;
            l3.Location = new Point(15, 42);
            l3.Name = "l3";
            l3.Size = new Size(97, 15);
            l3.TabIndex = 1;
            l3.Text = "Low Stocks";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(lblTodayOrders);
            panel4.Controls.Add(l2);
            panel4.Location = new Point(297, 166);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(141, 97);
            panel4.TabIndex = 3;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ReceiptIcon;
            pictureBox3.Location = new Point(52, 13);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblTodayOrders
            // 
            lblTodayOrders.AutoSize = true;
            lblTodayOrders.Font = new Font("SimSun-ExtB", 13.8F, FontStyle.Bold);
            lblTodayOrders.ForeColor = Color.MidnightBlue;
            lblTodayOrders.Location = new Point(52, 68);
            lblTodayOrders.Name = "lblTodayOrders";
            lblTodayOrders.Size = new Size(64, 19);
            lblTodayOrders.TabIndex = 2;
            lblTodayOrders.Text = "Total";
            // 
            // l2
            // 
            l2.AutoSize = true;
            l2.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l2.ForeColor = SystemColors.ButtonShadow;
            l2.Location = new Point(9, 42);
            l2.Name = "l2";
            l2.Size = new Size(115, 15);
            l2.TabIndex = 1;
            l2.Text = "Today Orders";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun-ExtB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(170, 58);
            label5.Name = "label5";
            label5.Size = new Size(237, 30);
            label5.TabIndex = 4;
            label5.Text = "Store Overview";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(109, 106);
            label2.Name = "label2";
            label2.Size = new Size(349, 32);
            label2.TabIndex = 5;
            label2.Text = "Welcome back! Here is what's happening\r\n         with Grocerease today";
            label2.Click += label2_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(594, 338);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashboardForm";
            Text = "DashboardForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lbl;
        private Label L1;
        private Label l3;
        private Label l2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label lblTotalProducts;
        private Label lblTotalCustomers;
        private Label lblLowStock;
        private Label lblTodayOrders;
        private Label label5;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}