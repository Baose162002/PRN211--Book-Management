namespace BookManagement
{
    partial class frmMainAdmin
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
            btnMember = new Button();
            btnBook = new Button();
            btnCategory = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnMember
            // 
            btnMember.Location = new Point(34, 220);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(175, 76);
            btnMember.TabIndex = 0;
            btnMember.Text = "Manager Member";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(318, 220);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(166, 76);
            btnBook.TabIndex = 1;
            btnBook.Text = "Book Manager";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(583, 220);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(176, 76);
            btnCategory.TabIndex = 2;
            btnCategory.Text = "Book Category";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(636, 70);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // frmMainAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnCategory);
            Controls.Add(btnBook);
            Controls.Add(btnMember);
            Name = "frmMainAdmin";
            Text = "MainAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMember;
        private Button btnBook;
        private Button btnCategory;
        private Button btnLogout;
    }
}