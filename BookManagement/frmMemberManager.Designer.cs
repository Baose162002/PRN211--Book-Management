namespace BookManagement
{
    partial class frmMemberManager
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
            dgvMember = new DataGridView();
            txtMemberID = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtMemberRole = new TextBox();
            lbMemberId = new Label();
            lbPassword = new Label();
            lbEmail = new Label();
            lbFullName = new Label();
            lbMemberRole = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(12, 448);
            dgvMember.Name = "dgvMember";
            dgvMember.RowTemplate.Height = 25;
            dgvMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMember.Size = new Size(993, 290);
            dgvMember.TabIndex = 0;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(120, 60);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(100, 23);
            txtMemberID.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(119, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(119, 259);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(100, 23);
            txtFullName.TabIndex = 4;
            // 
            // txtMemberRole
            // 
            txtMemberRole.Location = new Point(393, 55);
            txtMemberRole.Name = "txtMemberRole";
            txtMemberRole.Size = new Size(100, 23);
            txtMemberRole.TabIndex = 5;
            // 
            // lbMemberId
            // 
            lbMemberId.AutoSize = true;
            lbMemberId.Location = new Point(31, 63);
            lbMemberId.Name = "lbMemberId";
            lbMemberId.Size = new Size(65, 15);
            lbMemberId.TabIndex = 6;
            lbMemberId.Text = "Member Id";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(29, 128);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 7;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(47, 189);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 8;
            lbEmail.Text = "Email";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new Point(35, 259);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(61, 15);
            lbFullName.TabIndex = 9;
            lbFullName.Text = "Full Name";
            // 
            // lbMemberRole
            // 
            lbMemberRole.AutoSize = true;
            lbMemberRole.Location = new Point(291, 63);
            lbMemberRole.Name = "lbMemberRole";
            lbMemberRole.Size = new Size(78, 15);
            lbMemberRole.TabIndex = 10;
            lbMemberRole.Text = "Member Role";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(357, 306);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(489, 306);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(640, 306);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(790, 306);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmMemberManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 775);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
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
            Controls.Add(dgvMember);
            Name = "frmMemberManager";
            Text = "frmMemberManager";
            Load += frmMemberManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMember;
        private TextBox txtMemberID;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtFullName;
        private TextBox txtMemberRole;
        private Label lbMemberId;
        private Label lbPassword;
        private Label lbEmail;
        private Label lbFullName;
        private Label lbMemberRole;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoad;
    }
}