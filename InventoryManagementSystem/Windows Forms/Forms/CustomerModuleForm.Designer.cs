namespace Windows_Forms.Forms
{
    partial class CustomerModuleForm
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
            txtPhone = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();

            var lblName = new System.Windows.Forms.Label();
            var lblPhone = new System.Windows.Forms.Label();

            SuspendLayout();

            // Labels
            lblName.Text = "Full Name:";
            lblName.Location = new System.Drawing.Point(30, 53);
            lblName.Size = new System.Drawing.Size(100, 20);

            lblPhone.Text = "Phone:";
            lblPhone.Location = new System.Drawing.Point(30, 103);
            lblPhone.Size = new System.Drawing.Size(100, 20);

            // TextBoxes
            txtName.Location = new System.Drawing.Point(160, 50);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(200, 27);

            txtPhone.Location = new System.Drawing.Point(160, 100);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(200, 27);

            // Buttons
            btnSave.Location = new System.Drawing.Point(50, 160);
            btnSave.Name = "btnSave";
            btnSave.Text = "Save";
            btnSave.Size = new System.Drawing.Size(90, 30);
            btnSave.Click += btnSave_Click;

            btnUpdate.Location = new System.Drawing.Point(160, 160);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Text = "Update";
            btnUpdate.Size = new System.Drawing.Size(90, 30);
            btnUpdate.Click += btnUpdate_Click;

            btnClear.Location = new System.Drawing.Point(270, 160);
            btnClear.Name = "btnClear";
            btnClear.Text = "Clear";
            btnClear.Size = new System.Drawing.Size(90, 30);
            btnClear.Click += btnClear_Click;

            // Form
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(420, 230);
            Controls.Add(lblName);
            Controls.Add(lblPhone);
            Controls.Add(txtName);
            Controls.Add(txtPhone);
            Controls.Add(btnSave);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Name = "CustomerModuleForm";
            Text = "Customer Module";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
    }
}