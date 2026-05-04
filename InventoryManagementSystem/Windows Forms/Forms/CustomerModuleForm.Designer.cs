namespace Windows_Forms.Forms
{
    partial class CustomerModuleForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(ProductModuleForm));

            panel1 = new Panel();
            pictureBoxClose = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnClear = new Button();

            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();

            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(pictureBoxClose); panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top; panel1.Name = "panel1"; panel1.Size = new Size(602, 49);

            try { pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image"); } catch { }
            pictureBoxClose.Location = new Point(575, -1); pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(29, 27); pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.Click += pictureBoxClose_Click;

            label1.AutoSize = true; label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White; label1.Location = new Point(5, 14); label1.Text = "Customer Module";

            label2.AutoSize = true; label2.Location = new Point(30, 83); label2.Text = "Full Name :";
            txtName.Location = new Point(152, 80); txtName.Name = "txtName"; txtName.Size = new Size(396, 22);

            label3.AutoSize = true; label3.Location = new Point(30, 133); label3.Text = "Phone :";
            txtPhone.Location = new Point(152, 130); txtPhone.Name = "txtPhone"; txtPhone.Size = new Size(396, 22);

            btnSave.BackColor = Color.FromArgb(0, 64, 0); btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat; btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(152, 185); btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 37); btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false; btnSave.Click += btnSave_Click;

            btnUpdate.BackColor = Color.Olive; btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat; btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(252, 185); btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 37); btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false; btnUpdate.Click += btnUpdate_Click;

            btnClear.BackColor = Color.Red; btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat; btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(352, 185); btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 37); btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false; btnClear.Click += btnClear_Click;

            AutoScaleDimensions = new SizeF(7F, 17F); AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 250);
            Controls.Add(panel1); Controls.Add(label2); Controls.Add(txtName);
            Controls.Add(label3); Controls.Add(txtPhone);
            Controls.Add(btnSave); Controls.Add(btnUpdate); Controls.Add(btnClear);
            Font = new Font("Century Gothic", 9F); FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "CustomerModuleForm"; Text = "Customer Module";

            panel1.ResumeLayout(false); panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label label1, label2, label3;
        public TextBox txtName;
        public TextBox txtPhone;
        public Button btnSave;
        public Button btnUpdate;
        private Button btnClear;
    }
}