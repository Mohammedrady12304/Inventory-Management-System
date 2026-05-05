namespace Windows_Forms.Forms
{
    partial class UserModuleForm
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
                new System.ComponentModel.ComponentResourceManager(typeof(UserModuleForm));

            panel1 = new Panel(); pictureBoxClose = new PictureBox(); label1 = new Label();
            label2 = new Label(); txtUserName = new TextBox();
            label3 = new Label(); txtFullName = new TextBox();
            label4 = new Label(); txtPass = new TextBox();
            label5 = new Label(); txtRepass = new TextBox();
            label6 = new Label(); txtPhone = new TextBox();
            label7 = new Label(); cmbRole = new ComboBox();
            btnSave = new Button(); btnUpdate = new Button(); btnClear = new Button();

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
            label1.ForeColor = Color.White; label1.Location = new Point(5, 14); label1.Text = "User Module";

            int lx = 30, tx = 152, w = 396, gap = 45, y = 70;

            label2.AutoSize = true; label2.Location = new Point(lx, y + 3); label2.Text = "Username :";
            txtUserName.Location = new Point(tx, y); txtUserName.Name = "txtUserName"; txtUserName.Size = new Size(w, 22); y += gap;

            label3.AutoSize = true; label3.Location = new Point(lx, y + 3); label3.Text = "Full Name :";
            txtFullName.Location = new Point(tx, y); txtFullName.Name = "txtFullName"; txtFullName.Size = new Size(w, 22); y += gap;

            label4.AutoSize = true; label4.Location = new Point(lx, y + 3); label4.Text = "Password :";
            txtPass.Location = new Point(tx, y); txtPass.Name = "txtPass"; txtPass.Size = new Size(w, 22);
            txtPass.UseSystemPasswordChar = true; y += gap;

            label5.AutoSize = true; label5.Location = new Point(lx, y + 3); label5.Text = "Re-enter Password :";
            txtRepass.Location = new Point(tx, y); txtRepass.Name = "txtRepass"; txtRepass.Size = new Size(w, 22);
            txtRepass.UseSystemPasswordChar = true; y += gap;

            label6.AutoSize = true; label6.Location = new Point(lx, y + 3); label6.Text = "Phone :";
            txtPhone.Location = new Point(tx, y); txtPhone.Name = "txtPhone"; txtPhone.Size = new Size(w, 22); y += gap;

            label7.AutoSize = true; label7.Location = new Point(lx, y + 3); label7.Text = "Role :";
            cmbRole.Location = new Point(tx, y); cmbRole.Name = "cmbRole"; cmbRole.Size = new Size(w, 25);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Items.AddRange(new object[] { "Admin", "User" });
            cmbRole.SelectedIndex = 1; y += gap;

            btnSave.BackColor = Color.FromArgb(0, 64, 0); btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat; btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(152, y); btnSave.Name = "btnSave"; btnSave.Size = new Size(94, 37);
            btnSave.Text = "Save"; btnSave.UseVisualStyleBackColor = false; btnSave.Click += btnSave_Click;

            btnUpdate.BackColor = Color.Olive; btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat; btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(252, y); btnUpdate.Name = "btnUpdate"; btnUpdate.Size = new Size(94, 37);
            btnUpdate.Text = "Update"; btnUpdate.UseVisualStyleBackColor = false; btnUpdate.Click += btnUpdate_Click;

            btnClear.BackColor = Color.Red; btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat; btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(352, y); btnClear.Name = "btnClear"; btnClear.Size = new Size(94, 37);
            btnClear.Text = "Clear"; btnClear.UseVisualStyleBackColor = false; btnClear.Click += btnClear_Click;

            AutoScaleDimensions = new SizeF(7F, 17F); AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, y + 65);
            Controls.Add(panel1);
            Controls.Add(label2); Controls.Add(txtUserName);
            Controls.Add(label3); Controls.Add(txtFullName);
            Controls.Add(label4); Controls.Add(txtPass);
            Controls.Add(label5); Controls.Add(txtRepass);
            Controls.Add(label6); Controls.Add(txtPhone);
            Controls.Add(label7); Controls.Add(cmbRole);
            Controls.Add(btnSave); Controls.Add(btnUpdate); Controls.Add(btnClear);
            Font = new Font("Century Gothic", 9F); FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "UserModuleForm"; Text = "User Module";

            panel1.ResumeLayout(false); panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false); PerformLayout();
        }

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private Label label1, label2, label3, label4, label5, label6, label7;
        public TextBox txtUserName, txtFullName, txtPass, txtRepass, txtPhone;
        public ComboBox cmbRole;
        public Button btnSave, btnUpdate;
        private Button btnClear;
    }
}