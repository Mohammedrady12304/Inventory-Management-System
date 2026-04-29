
namespace Windows_Forms.Forms
{
    partial class ProductModuleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModuleForm));
            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            txtPDes = new TextBox();
            label6 = new Label();
            btnClear = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            label5 = new Label();
            txtPPrice = new TextBox();
            label4 = new Label();
            txtPQty = new TextBox();
            label3 = new Label();
            txtPName = new TextBox();
            label2 = new Label();
            comboCat = new ComboBox();
            lblPid = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBoxClose);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(602, 49);
            panel1.TabIndex = 14;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(575, -1);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(29, 27);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 11;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 1;
            label1.Text = "Product Module";
            // 
            // txtPDes
            // 
            txtPDes.Location = new Point(152, 202);
            txtPDes.Name = "txtPDes";
            txtPDes.Size = new Size(396, 22);
            txtPDes.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 205);
            label6.Name = "label6";
            label6.Size = new Size(85, 17);
            label6.TabIndex = 26;
            label6.Text = "Description : ";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(450, 296);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 37);
            btnClear.TabIndex = 25;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Olive;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(350, 296);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 37);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 64, 0);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(250, 296);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 37);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 248);
            label5.Name = "label5";
            label5.Size = new Size(73, 17);
            label5.TabIndex = 21;
            label5.Text = "Category : ";
            // 
            // txtPPrice
            // 
            txtPPrice.Location = new Point(152, 159);
            txtPPrice.Name = "txtPPrice";
            txtPPrice.Size = new Size(396, 22);
            txtPPrice.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 162);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 19;
            label4.Text = "Price : ";
            // 
            // txtPQty
            // 
            txtPQty.Location = new Point(152, 116);
            txtPQty.Name = "txtPQty";
            txtPQty.Size = new Size(396, 22);
            txtPQty.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 119);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 17;
            label3.Text = "Quantity : ";
            // 
            // txtPName
            // 
            txtPName.Location = new Point(152, 73);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(396, 22);
            txtPName.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 75);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 15;
            label2.Text = "Product Name : ";
            // 
            // comboCat
            // 
            comboCat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCat.FormattingEnabled = true;
            comboCat.Location = new Point(152, 248);
            comboCat.Name = "comboCat";
            comboCat.Size = new Size(396, 25);
            comboCat.TabIndex = 28;
            comboCat.SelectedIndexChanged += comboCat_SelectedIndexChanged;
            // 
            // lblPid
            // 
            lblPid.AutoSize = true;
            lblPid.Location = new Point(49, 306);
            lblPid.Name = "lblPid";
            lblPid.Size = new Size(70, 17);
            lblPid.TabIndex = 29;
            lblPid.Text = "product id";
            lblPid.Visible = false;
            // 
            // ProductModuleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 350);
            Controls.Add(lblPid);
            Controls.Add(comboCat);
            Controls.Add(panel1);
            Controls.Add(txtPDes);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtPPrice);
            Controls.Add(label4);
            Controls.Add(txtPQty);
            Controls.Add(label3);
            Controls.Add(txtPName);
            Controls.Add(label2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductModuleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModuleForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPDes;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPPrice;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPQty;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboCat;
        public System.Windows.Forms.Label lblPid;
    }
}