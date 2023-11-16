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
    public partial class frmBookCategoryDetail : Form
    {
        public frmBookCategoryDetail()
        {
            InitializeComponent();
        }
        public IBookCategoryRepository bookCategoryRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public BookCategory BookCategoryInfor { get; set; }

        private void ClearText()
        {
            txtBookCategoryID.Text = string.Empty;
            txtBookGenreType.Text = string.Empty;
            txtDescription.Text = string.Empty;

        }

        private void frmBookCategoryDetail_Load(object sender, EventArgs e)
        {
            txtBookCategoryID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtBookCategoryID.Text = BookCategoryInfor.BookCategoryId.ToString();
                txtBookGenreType.Text = BookCategoryInfor.BookGenreType;
                txtDescription.Text = BookCategoryInfor.Description;



            }
        }

        private bool ValidateInput()
        {
            // Kiểm tra điều kiện cho txtPrice và txtQuantity


            // Kiểm tra điều kiện cho txtBookName
            string bookName = txtBookGenreType.Text.Trim();
            if (string.IsNullOrEmpty(bookName))
            {
                MessageBox.Show("Book Name is required.");
                return false;
            }

            if (bookName.Length < 2 || bookName.Length > 50)
            {
                MessageBox.Show("Book Name must be between 2 and 50 characters.");
                return false;
            }



            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBookCategoryID.Text) ||
               string.IsNullOrEmpty(txtBookGenreType.Text) ||
               string.IsNullOrEmpty(txtDescription.Text))

            {
                MessageBox.Show("Required all fields");
                return;

            }
            if (!ValidateInput())
            {
                return;
            }

            try
            {


                var bookcategory = new BookCategory()
                {
                    BookCategoryId = int.Parse(txtBookCategoryID.Text),
                    BookGenreType = txtBookGenreType.Text,
                    Description = txtDescription.Text,



                };
                if (InsertOrUpdate)
                {
                    bookCategoryRepository.update(bookcategory);
                    MessageBox.Show("Update successful");
                }
                else
                {
                    bookCategoryRepository.create(bookcategory);
                    MessageBox.Show("Add successful");
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)=>Close();
  
    }

}
