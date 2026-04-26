namespace Windows_Forms.Forms
{
    partial class UserModuleForm
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
            txtUserName = new System.Windows.Forms.TextBox();
            txtFullName = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            txtRepass = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();

            var lblUserName = new System.Windows.Forms.Label();
            var lblFullName = new System.Windows.Forms.Label();
            var lblPass = new System.Windows.Forms.Label();
            var lblRepass = new System.Windows.Forms.Label();
            var lblPhone = new System.Windows.Forms.Label();

            SuspendLayout();

            // Labels
            lblUserName.Text = "Username:";
            lblUserName.Location = new System.Drawing.Point(30, 53);
            lblUserName.Size = new System.Drawing.Size(100, 20);

            lblFullName.Text = "Full Name:";
            lblFullName.Location = new System.Drawing.Point(30, 103);
            lblFullName.Size = new System.Drawing.Size(100, 20);

            lblPass.Text = "Password:";
            lblPass.Location = new System.Drawing.Point(30, 153);
            lblPass.Size = new System.Drawing.Size(100, 20);

            lblRepass.Text = "Re-enter Password:";
            lblRepass.Location = new System.Drawing.Point(30, 203);
            lblRepass.Size = new System.Drawing.Size(120, 20);

            lblPhone.Text = "Phone:";
            lblPhone.Location = new System.Drawing.Point(30, 253);
            lblPhone.Size = new System.Drawing.Size(100, 20);

            // TextBoxes
            txtUserName.Location = new System.Drawing.Point(160, 50);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new System.Drawing.Size(200, 27);

            txtFullName.Location = new System.Drawing.Point(160, 100);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(200, 27);

            txtPass.Location = new System.Drawing.Point(160, 150);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(200, 27);
            txtPass.UseSystemPasswordChar = true;

            txtRepass.Location = new System.Drawing.Point(160, 200);
            txtRepass.Name = "txtRepass";
            txtRepass.Size = new System.Drawing.Size(200, 27);
            txtRepass.UseSystemPasswordChar = true;

            txtPhone.Location = new System.Drawing.Point(160, 250);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(200, 27);

            // Buttons
            btnSave.Location = new System.Drawing.Point(50, 310);
            btnSave.Name = "btnSave";
            btnSave.Text = "Save";
            btnSave.Size = new System.Drawing.Size(90, 30);
            btnSave.Click += btnSave_Click;

            btnUpdate.Location = new System.Drawing.Point(160, 310);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Text = "Update";
            btnUpdate.Size = new System.Drawing.Size(90, 30);
            btnUpdate.Click += btnUpdate_Click;

            btnClear.Location = new System.Drawing.Point(270, 310);
            btnClear.Name = "btnClear";
            btnClear.Text = "Clear";
            btnClear.Size = new System.Drawing.Size(90, 30);
            btnClear.Click += btnClear_Click;

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(420, 380);
            Controls.Add(lblUserName);
            Controls.Add(lblFullName);
            Controls.Add(lblPass);
            Controls.Add(lblRepass);
            Controls.Add(lblPhone);
            Controls.Add(txtUserName);
            Controls.Add(txtFullName);
            Controls.Add(txtPass);
            Controls.Add(txtRepass);
            Controls.Add(txtPhone);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Name = "UserModuleForm";
            this.Text = "User Module";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtFullName;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtRepass;
        public System.Windows.Forms.TextBox txtPhone;
    }
}