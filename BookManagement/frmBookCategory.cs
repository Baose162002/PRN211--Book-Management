using BookObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement
{
    public partial class frmBookCategory : Form
    {
        public frmBookCategory()
        {
            InitializeComponent();
        }

        private BookCategoryRepository bookCategoryRepository = new BookCategoryRepository();
        private BindingSource bookCategorySource;

        public void LoadBookCategory()
        {
            bookCategorySource = new BindingSource();
            var list = bookCategoryRepository.GetBookCategories();
            bookCategorySource.DataSource = list;
            txtBookCategoryID.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            txtBookGenreType.DataBindings.Clear();


            txtBookCategoryID.DataBindings.Add("Text", bookCategorySource, "BookCategoryId");
            txtDescription.DataBindings.Add("Text", bookCategorySource, "BookGenreType");
            txtBookGenreType.DataBindings.Add("Text", bookCategorySource, "Description");

            dgvBookCategory.DataSource = null;
            dgvBookCategory.DataSource = bookCategorySource;
            dgvBookCategory.Columns["Books"].Visible = false;

        }

        private void frmBookCategory_Load(object sender, EventArgs e)
        {
            LoadBookCategory();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmBookCategoryDetail frmBookCategoryDetail = new frmBookCategoryDetail
            {
                Text = "Add Book Category",
                InsertOrUpdate = false,


                bookCategoryRepository = bookCategoryRepository,

            };
            if (frmBookCategoryDetail.ShowDialog() == DialogResult.OK)
            {
                LoadBookCategory();
            }
        }
        public BookCategory GetBookCategory()
        {
            BookCategory bookcategory = null;
            try
            {
                int index = dgvBookCategory.CurrentCell.RowIndex;
                var dummy = (BookCategory)dgvBookCategory.Rows[index].DataBoundItem;
                bookcategory = bookCategoryRepository.GetBookCategoryById(dummy.BookCategoryId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return bookcategory;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmBookCategoryDetail frmBookCategoryDetail = new frmBookCategoryDetail
            {
                Text = "Update Book Category",
                InsertOrUpdate = true,
                BookCategoryInfor = GetBookCategory(),

                bookCategoryRepository = bookCategoryRepository,
            };
            if (frmBookCategoryDetail.ShowDialog() == DialogResult.OK)
            {
                LoadBookCategory();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you ready want to delete", "Book Category", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                bookCategoryRepository.delete(int.Parse(txtBookCategoryID.Text));
                LoadBookCategory();
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadBookCategory();
        }
    }
}
