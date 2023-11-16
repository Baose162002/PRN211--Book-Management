namespace BookManagement_TranQuocBao
{
    partial class frmBookManagement
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
            dgvBook = new DataGridView();
            cboCategory = new ComboBox();
            lbBookID = new Label();
            lbBookName = new Label();
            lbDescription = new Label();
            lbReleaseDate = new Label();
            lbQuantity = new Label();
            lbPrice = new Label();
            lbCategory = new Label();
            lbAuthor = new Label();
            txtAuthor = new TextBox();
            txtBookID = new TextBox();
            txtBookName = new TextBox();
            txtDescription = new TextBox();
            txtQuanity = new TextBox();
            txtPrice = new TextBox();
            dtpReleaseDate = new DateTimePicker();
            btnDelete = new Button();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(29, 427);
            dgvBook.Name = "dgvBook";
            dgvBook.RowTemplate.Height = 25;
            dgvBook.Size = new Size(907, 249);
            dgvBook.TabIndex = 0;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(538, 38);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 1;
            // 
            // lbBookID
            // 
            lbBookID.AutoSize = true;
            lbBookID.Location = new Point(76, 38);
            lbBookID.Name = "lbBookID";
            lbBookID.Size = new Size(45, 15);
            lbBookID.TabIndex = 2;
            lbBookID.Text = "BookID";
            // 
            // lbBookName
            // 
            lbBookName.AutoSize = true;
            lbBookName.Location = new Point(76, 97);
            lbBookName.Name = "lbBookName";
            lbBookName.Size = new Size(69, 15);
            lbBookName.TabIndex = 3;
            lbBookName.Text = "Book Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(76, 162);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 4;
            lbDescription.Text = "Description";
            // 
            // lbReleaseDate
            // 
            lbReleaseDate.AutoSize = true;
            lbReleaseDate.Location = new Point(73, 234);
            lbReleaseDate.Name = "lbReleaseDate";
            lbReleaseDate.Size = new Size(70, 15);
            lbReleaseDate.TabIndex = 5;
            lbReleaseDate.Text = "ReleaseDate";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(73, 294);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(53, 15);
            lbQuantity.TabIndex = 6;
            lbQuantity.Text = "Quantity";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(88, 354);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 7;
            lbPrice.Text = "Price";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(460, 38);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(55, 15);
            lbCategory.TabIndex = 8;
            lbCategory.Text = "Category";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new Point(460, 92);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(44, 15);
            lbAuthor.TabIndex = 9;
            lbAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(538, 89);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(121, 23);
            txtAuthor.TabIndex = 10;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(171, 36);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(106, 23);
            txtBookID.TabIndex = 11;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(171, 92);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(106, 23);
            txtBookName.TabIndex = 12;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(161, 144);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(233, 61);
            txtDescription.TabIndex = 13;
            // 
            // txtQuanity
            // 
            txtQuanity.Location = new Point(171, 286);
            txtQuanity.Name = "txtQuanity";
            txtQuanity.Size = new Size(106, 23);
            txtQuanity.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(171, 346);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(106, 23);
            txtPrice.TabIndex = 16;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.CustomFormat = "dd/MM/yyyy";
            dtpReleaseDate.Format = DateTimePickerFormat.Custom;
            dtpReleaseDate.Location = new Point(174, 234);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(120, 23);
            dtpReleaseDate.TabIndex = 17;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(736, 314);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(471, 314);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 19;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(602, 314);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(780, 193);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 21;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(623, 194);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(128, 23);
            txtSearch.TabIndex = 22;
            // 
            // frmBookManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 705);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(btnDelete);
            Controls.Add(dtpReleaseDate);
            Controls.Add(txtPrice);
            Controls.Add(txtQuanity);
            Controls.Add(txtDescription);
            Controls.Add(txtBookName);
            Controls.Add(txtBookID);
            Controls.Add(txtAuthor);
            Controls.Add(lbAuthor);
            Controls.Add(lbCategory);
            Controls.Add(lbPrice);
            Controls.Add(lbQuantity);
            Controls.Add(lbReleaseDate);
            Controls.Add(lbDescription);
            Controls.Add(lbBookName);
            Controls.Add(lbBookID);
            Controls.Add(cboCategory);
            Controls.Add(dgvBook);
            Name = "frmBookManagement";
            Text = "frmBookManagement";
            Load += frmBookManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBook;
        private ComboBox cboCategory;
        private Label lbBookID;
        private Label lbBookName;
        private Label lbDescription;
        private Label lbReleaseDate;
        private Label lbQuantity;
        private Label lbPrice;
        private Label lbCategory;
        private Label lbAuthor;
        private TextBox txtAuthor;
        private TextBox txtBookID;
        private TextBox txtBookName;
        private TextBox txtDescription;
        private TextBox txtQuanity;
        private TextBox txtPrice;
        private DateTimePicker dtpReleaseDate;
        private Button btnDelete;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}