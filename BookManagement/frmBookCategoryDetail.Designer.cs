namespace BookManagement
{
    partial class frmBookCategoryDetail
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
            lbDescription = new Label();
            lbBookGenreType = new Label();
            lbBookCategoryID = new Label();
            txtDescription = new TextBox();
            txtBookGenreType = new TextBox();
            txtBookCategoryID = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(119, 229);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 13;
            lbDescription.Text = "Description";
            // 
            // lbBookGenreType
            // 
            lbBookGenreType.AutoSize = true;
            lbBookGenreType.Location = new Point(91, 143);
            lbBookGenreType.Name = "lbBookGenreType";
            lbBookGenreType.Size = new Size(95, 15);
            lbBookGenreType.TabIndex = 12;
            lbBookGenreType.Text = "Book Genre Type";
            // 
            // lbBookCategoryID
            // 
            lbBookCategoryID.AutoSize = true;
            lbBookCategoryID.Location = new Point(91, 61);
            lbBookCategoryID.Name = "lbBookCategoryID";
            lbBookCategoryID.Size = new Size(99, 15);
            lbBookCategoryID.TabIndex = 11;
            lbBookCategoryID.Text = "Book Category ID";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(241, 221);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 10;
            // 
            // txtBookGenreType
            // 
            txtBookGenreType.Location = new Point(241, 135);
            txtBookGenreType.Name = "txtBookGenreType";
            txtBookGenreType.Size = new Size(100, 23);
            txtBookGenreType.TabIndex = 9;
            // 
            // txtBookCategoryID
            // 
            txtBookCategoryID.Location = new Point(241, 53);
            txtBookCategoryID.Name = "txtBookCategoryID";
            txtBookCategoryID.Size = new Size(100, 23);
            txtBookCategoryID.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(152, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(310, 333);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmBookCategoryDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbDescription);
            Controls.Add(lbBookGenreType);
            Controls.Add(lbBookCategoryID);
            Controls.Add(txtDescription);
            Controls.Add(txtBookGenreType);
            Controls.Add(txtBookCategoryID);
            Name = "frmBookCategoryDetail";
            Text = "frmBookCategoryDetail";
            Load += frmBookCategoryDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDescription;
        private Label lbBookGenreType;
        private Label lbBookCategoryID;
        private TextBox txtDescription;
        private TextBox txtBookGenreType;
        private TextBox txtBookCategoryID;
        private Button btnSave;
        private Button btnCancel;
    }
}