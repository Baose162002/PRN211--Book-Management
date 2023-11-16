namespace BookManagement_TranQuocBao
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            logintext = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 117, 214);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(116, 367);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(164, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(116, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter your email....";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(116, 321);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password....";
            txtPassword.Size = new Size(164, 23);
            txtPassword.TabIndex = 4;
            // 
            // logintext
            // 
            logintext.AutoSize = true;
            logintext.Font = new Font("Bauhaus 93", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            logintext.ForeColor = Color.FromArgb(0, 117, 214);
            logintext.Location = new Point(135, 185);
            logintext.Name = "logintext";
            logintext.Size = new Size(124, 42);
            logintext.TabIndex = 1;
            logintext.Text = "LOG IN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = BookManagement.Properties.Resources.book1;
            pictureBox1.Location = new Point(116, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 464);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnLogin);
            Controls.Add(logintext);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label logintext;
        private PictureBox pictureBox1;
    }
}