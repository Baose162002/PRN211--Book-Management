namespace BookManagement
{
    partial class frmBookCategory
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
            dgvBookCategory = new DataGridView();
            txtBookCategoryID = new TextBox();
            txtBookGenreType = new TextBox();
            txtDescription = new TextBox();
            txtSearch = new TextBox();
            lbBookCategoryID = new Label();
            lbBookGenreType = new Label();
            lbDescription = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBookCategory).BeginInit();
            SuspendLayout();
            // 
            // dgvBookCategory
            // 
            dgvBookCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookCategory.Location = new Point(12, 396);
            dgvBookCategory.Name = "dgvBookCategory";
            dgvBookCategory.RowTemplate.Height = 25;
            dgvBookCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookCategory.Size = new Size(1015, 261);
            dgvBookCategory.TabIndex = 0;
            // 
            // txtBookCategoryID
            // 
            txtBookCategoryID.Location = new Point(157, 87);
            txtBookCategoryID.Name = "txtBookCategoryID";
            txtBookCategoryID.Size = new Size(100, 23);
            txtBookCategoryID.TabIndex = 1;
            // 
            // txtBookGenreType
            // 
            txtBookGenreType.Location = new Point(157, 192);
            txtBookGenreType.Name = "txtBookGenreType";
            txtBookGenreType.Size = new Size(100, 23);
            txtBookGenreType.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(157, 302);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 3;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(645, 87);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(139, 23);
            txtSearch.TabIndex = 4;
            // 
            // lbBookCategoryID
            // 
            lbBookCategoryID.AutoSize = true;
            lbBookCategoryID.Location = new Point(34, 95);
            lbBookCategoryID.Name = "lbBookCategoryID";
            lbBookCategoryID.Size = new Size(99, 15);
            lbBookCategoryID.TabIndex = 5;
            lbBookCategoryID.Text = "Book Category ID";
            // 
            // lbBookGenreType
            // 
            lbBookGenreType.AutoSize = true;
            lbBookGenreType.Location = new Point(38, 192);
            lbBookGenreType.Name = "lbBookGenreType";
            lbBookGenreType.Size = new Size(95, 15);
            lbBookGenreType.TabIndex = 6;
            lbBookGenreType.Text = "Book Genre Type";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(66, 305);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 7;
            lbDescription.Text = "Description";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(404, 302);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(543, 302);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(682, 302);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(807, 87);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(828, 301);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 12;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // frmBookCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 679);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lbDescription);
            Controls.Add(lbBookGenreType);
            Controls.Add(lbBookCategoryID);
            Controls.Add(txtSearch);
            Controls.Add(txtDescription);
            Controls.Add(txtBookGenreType);
            Controls.Add(txtBookCategoryID);
            Controls.Add(dgvBookCategory);
            Name = "frmBookCategory";
            Text = "frmBookCategory";
            Load += frmBookCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBookCategory;
        private TextBox txtBookCategoryID;
        private TextBox txtBookGenreType;
        private TextBox txtDescription;
        private TextBox txtSearch;
        private Label lbBookCategoryID;
        private Label lbBookGenreType;
        private Label lbDescription;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnLoad;
    }
}