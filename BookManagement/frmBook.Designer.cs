namespace BookManagement_TranQuocBao
{
    partial class frmBook
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
            lbBookID = new Label();
            lbBookName = new Label();
            lbDescription = new Label();
            lbReleaseDate = new Label();
            lbQuantity = new Label();
            lbPrice = new Label();
            lbCategory = new Label();
            lbAuthor = new Label();
            txtBookID = new TextBox();
            txtBookName = new TextBox();
            txtDescription = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtAuthor = new TextBox();
            dtpReleaaseDate = new DateTimePicker();
            cboCategory = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbBookID
            // 
            lbBookID.AutoSize = true;
            lbBookID.Location = new Point(50, 41);
            lbBookID.Name = "lbBookID";
            lbBookID.Size = new Size(48, 15);
            lbBookID.TabIndex = 0;
            lbBookID.Text = "Book ID";
            // 
            // lbBookName
            // 
            lbBookName.AutoSize = true;
            lbBookName.Location = new Point(52, 132);
            lbBookName.Name = "lbBookName";
            lbBookName.Size = new Size(69, 15);
            lbBookName.TabIndex = 1;
            lbBookName.Text = "Book Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(50, 211);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 2;
            lbDescription.Text = "Description";
            // 
            // lbReleaseDate
            // 
            lbReleaseDate.AutoSize = true;
            lbReleaseDate.Location = new Point(50, 287);
            lbReleaseDate.Name = "lbReleaseDate";
            lbReleaseDate.Size = new Size(70, 15);
            lbReleaseDate.TabIndex = 3;
            lbReleaseDate.Text = "ReleaseDate";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(392, 41);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(53, 15);
            lbQuantity.TabIndex = 4;
            lbQuantity.Text = "Quantity";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(392, 132);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(392, 211);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(55, 15);
            lbCategory.TabIndex = 6;
            lbCategory.Text = "Category";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new Point(392, 287);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(44, 15);
            lbAuthor.TabIndex = 7;
            lbAuthor.Text = "Author";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(124, 41);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(100, 23);
            txtBookID.TabIndex = 8;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(128, 131);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(178, 23);
            txtBookName.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(123, 187);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(183, 56);
            txtDescription.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(493, 39);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(492, 126);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 13;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(492, 279);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 15;
            // 
            // dtpReleaaseDate
            // 
            dtpReleaaseDate.CustomFormat = "dd/MM/yyyy";
            dtpReleaaseDate.Format = DateTimePickerFormat.Custom;
            dtpReleaaseDate.Location = new Point(142, 285);
            dtpReleaaseDate.Name = "dtpReleaaseDate";
            dtpReleaaseDate.Size = new Size(200, 23);
            dtpReleaaseDate.TabIndex = 16;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(492, 205);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(167, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(392, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboCategory);
            Controls.Add(dtpReleaaseDate);
            Controls.Add(txtAuthor);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtDescription);
            Controls.Add(txtBookName);
            Controls.Add(txtBookID);
            Controls.Add(lbAuthor);
            Controls.Add(lbCategory);
            Controls.Add(lbPrice);
            Controls.Add(lbQuantity);
            Controls.Add(lbReleaseDate);
            Controls.Add(lbDescription);
            Controls.Add(lbBookName);
            Controls.Add(lbBookID);
            Name = "frmBook";
            Text = "frmBook";
            Load += frmBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBookID;
        private Label lbBookName;
        private Label lbDescription;
        private Label lbReleaseDate;
        private Label lbQuantity;
        private Label lbPrice;
        private Label lbCategory;
        private Label lbAuthor;
        private TextBox txtBookID;
        private TextBox txtBookName;
        private TextBox txtDescription;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox textBox7;
        private TextBox txtAuthor;
        private DateTimePicker dtpReleaaseDate;
        private ComboBox cboCategory;
        private Button btnSave;
        private Button btnCancel;
    }
}