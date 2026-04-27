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
            txtName = new TextBox();
            txtPass = new TextBox();
            checkBoxPass = new CheckBox();
            btnLogin = new Button();
            lblClear = new Label();
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            panel1 = new Panel();
            lblError = new Label();
            picLogo = new PictureBox();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 11F);
            txtName.Location = new Point(238, 190);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 32);
            txtName.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 11F);
            txtPass.Location = new Point(238, 240);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(200, 32);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // checkBoxPass
            // 
            checkBoxPass.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxPass.Location = new Point(238, 280);
            checkBoxPass.Name = "checkBoxPass";
            checkBoxPass.Size = new Size(104, 24);
            checkBoxPass.TabIndex = 5;
            checkBoxPass.Text = "Show Password";
            checkBoxPass.CheckedChanged += checkBoxPass_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(214, 328);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(105, 43);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblClear
            // 
            lblClear.Cursor = Cursors.Hand;
            lblClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblClear.ForeColor = Color.Gray;
            lblClear.Location = new Point(335, 336);
            lblClear.Name = "lblClear";
            lblClear.Size = new Size(47, 30);
            lblClear.TabIndex = 7;
            lblClear.Text = "Clear";
            lblClear.TextAlign = ContentAlignment.MiddleCenter;
            lblClear.Click += lblClear_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(85, 128);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory Management System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(113, 192);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 31);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(113, 240);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(110, 32);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblClear);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(checkBoxPass);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtPass);
            panel1.ForeColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(100, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 400);
            panel1.TabIndex = 8;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.FromArgb(192, 0, 0);
            lblError.Location = new Point(200, 305);
            lblError.Name = "lblError";
            lblError.Size = new Size(48, 20);
            lblError.TabIndex = 9;
            lblError.Text = "label1";
            lblError.Visible = false;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.logo;
            picLogo.Location = new Point(250, 15);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 100);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 8;
            picLogo.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(764, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(35, 30);
            btnExit.TabIndex = 9;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 500);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblClear;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private Panel panel1;
        private PictureBox picLogo;
        private Button btnExit;
        private Label lblError;
    }
}