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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbBookID
            // 
            lbBookID.AutoSize = true;
            lbBookID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbBookID.Location = new Point(113, 129);
            lbBookID.Name = "lbBookID";
            lbBookID.Size = new Size(48, 15);
            lbBookID.TabIndex = 0;
            lbBookID.Text = "Book ID";
            // 
            // lbBookName
            // 
            lbBookName.AutoSize = true;
            lbBookName.Location = new Point(89, 191);
            lbBookName.Name = "lbBookName";
            lbBookName.Size = new Size(69, 15);
            lbBookName.TabIndex = 1;
            lbBookName.Text = "Book Name";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(91, 313);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 2;
            lbDescription.Text = "Description";
            // 
            // lbReleaseDate
            // 
            lbReleaseDate.AutoSize = true;
            lbReleaseDate.Location = new Point(91, 252);
            lbReleaseDate.Name = "lbReleaseDate";
            lbReleaseDate.Size = new Size(70, 15);
            lbReleaseDate.TabIndex = 3;
            lbReleaseDate.Text = "ReleaseDate";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(487, 126);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(53, 15);
            lbQuantity.TabIndex = 4;
            lbQuantity.Text = "Quantity";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(507, 193);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Location = new Point(485, 272);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(55, 15);
            lbCategory.TabIndex = 6;
            lbCategory.Text = "Category";
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new Point(496, 346);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(44, 15);
            lbAuthor.TabIndex = 7;
            lbAuthor.Text = "Author";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(180, 129);
            txtBookID.Name = "txtBookID";
            txtBookID.PlaceholderText = "Enter ID";
            txtBookID.Size = new Size(225, 23);
            txtBookID.TabIndex = 8;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(180, 191);
            txtBookName.Name = "txtBookName";
            txtBookName.PlaceholderText = "Enter book name";
            txtBookName.Size = new Size(225, 23);
            txtBookName.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(180, 313);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter your description";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(225, 56);
            txtDescription.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(551, 126);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Enter number";
            txtQuantity.Size = new Size(170, 23);
            txtQuantity.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(551, 193);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Enter number";
            txtPrice.Size = new Size(170, 23);
            txtPrice.TabIndex = 13;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(551, 346);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.PlaceholderText = "Enter Author";
            txtAuthor.Size = new Size(170, 23);
            txtAuthor.TabIndex = 15;
            // 
            // dtpReleaaseDate
            // 
            dtpReleaaseDate.CustomFormat = "dd/MM/yyyy";
            dtpReleaaseDate.Format = DateTimePickerFormat.Custom;
            dtpReleaaseDate.Location = new Point(180, 252);
            dtpReleaaseDate.Name = "dtpReleaaseDate";
            dtpReleaaseDate.Size = new Size(225, 23);
            dtpReleaaseDate.TabIndex = 16;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(551, 272);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(170, 23);
            cboCategory.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 117, 214);
            btnSave.DialogResult = DialogResult.OK;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(471, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 41);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(151, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(207, 41);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = BookManagement.Properties.Resources.library_header;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(803, 71);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bauhaus 93", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(562, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 42);
            label1.TabIndex = 4;
            label1.Text = "Create Book";
            label1.Click += label1_Click;
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
            Controls.Add(label1);
            Controls.Add(lbQuantity);
            Controls.Add(lbReleaseDate);
            Controls.Add(lbDescription);
            Controls.Add(lbBookName);
            Controls.Add(lbBookID);
            Controls.Add(pictureBox1);
            Name = "frmBook";
            Text = "frmBook";
            Load += frmBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label1;
    }
}