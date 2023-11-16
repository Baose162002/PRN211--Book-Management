namespace BookManagement
{
    partial class frmMemberDetail
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
            lbMemberRole = new Label();
            lbFullName = new Label();
            lbEmail = new Label();
            lbPassword = new Label();
            lbMemberId = new Label();
            txtMemberRole = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtMemberID = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbMemberRole
            // 
            lbMemberRole.AutoSize = true;
            lbMemberRole.Location = new Point(373, 44);
            lbMemberRole.Name = "lbMemberRole";
            lbMemberRole.Size = new Size(78, 15);
            lbMemberRole.TabIndex = 20;
            lbMemberRole.Text = "Member Role";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new Point(391, 109);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(61, 15);
            lbFullName.TabIndex = 19;
            lbFullName.Text = "Full Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(129, 170);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 18;
            lbEmail.Text = "Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(111, 109);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 17;
            lbPassword.Text = "Password";
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(113, 44);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(65, 15);
            lbMemberId.TabIndex = 16;
            lbMemberId.Text = "Member Id";
            // 
            // txtMemberRole
            // 
            txtMemberRole.Location = new Point(475, 36);
            txtMemberRole.Name = "txtMemberRole";
            txtMemberRole.Size = new Size(100, 23);
            txtMemberRole.TabIndex = 15;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(475, 109);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(201, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 12;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(202, 41);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(100, 23);
            txtMemberID.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(253, 282);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 21;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(444, 282);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MemberDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbMemberRole);
            Controls.Add(lbFullName);
            Controls.Add(lbEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbMemberId);
            Controls.Add(txtMemberRole);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtMemberID);
            Name = "MemberDetail";
            Text = "MemberDetail";
            Load += MemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemberRole;
        private Label lbFullName;
        private Label lbEmail;
        private Label lbPassword;
        private Label lbMemberId;
        private TextBox txtMemberRole;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtMemberID;
        private Button btnSave;
        private Button btnCancel;
    }
}