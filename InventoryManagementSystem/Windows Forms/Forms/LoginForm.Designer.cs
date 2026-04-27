namespace Windows_Forms.Forms
{
    partial class LoginForm
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
            txtName = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            checkBoxPass = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            lblClear = new System.Windows.Forms.Label();

            var lblTitle = new System.Windows.Forms.Label();
            var lblUsername = new System.Windows.Forms.Label();
            var lblPassword = new System.Windows.Forms.Label();

            SuspendLayout();

            // Title
            lblTitle.Text = "Inventory Management System";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(50, 30);
            lblTitle.Size = new System.Drawing.Size(350, 35);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblUsername
            lblUsername.Text = "Username:";
            lblUsername.Location = new System.Drawing.Point(50, 103);
            lblUsername.Size = new System.Drawing.Size(80, 20);

            // txtName
            txtName.Location = new System.Drawing.Point(150, 100);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(200, 27);

            // lblPassword
            lblPassword.Text = "Password:";
            lblPassword.Location = new System.Drawing.Point(50, 153);
            lblPassword.Size = new System.Drawing.Size(80, 20);

            // txtPass
            txtPass.Location = new System.Drawing.Point(150, 150);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(200, 27);
            txtPass.UseSystemPasswordChar = true;

            // checkBoxPass
            checkBoxPass.Location = new System.Drawing.Point(150, 190);
            checkBoxPass.Name = "checkBoxPass";
            checkBoxPass.Text = "Show Password";
            checkBoxPass.CheckedChanged += checkBoxPass_CheckedChanged;

            // btnLogin
            btnLogin.Location = new System.Drawing.Point(150, 230);
            btnLogin.Name = "btnLogin";
            btnLogin.Text = "Login";
            btnLogin.Size = new System.Drawing.Size(100, 30);
            btnLogin.Click += btnLogin_Click;

            // lblClear
            lblClear.Location = new System.Drawing.Point(260, 235);
            lblClear.Name = "lblClear";
            lblClear.Text = "Clear";
            lblClear.ForeColor = System.Drawing.Color.Blue;
            lblClear.Cursor = System.Windows.Forms.Cursors.Hand;
            lblClear.Click += lblClear_Click;

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 320);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtName);
            Controls.Add(txtPass);
            Controls.Add(checkBoxPass);
            Controls.Add(btnLogin);
            Controls.Add(lblClear);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblClear;
    }
}