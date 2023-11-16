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
using BookObject.Models;

namespace BookManagement_TranQuocBao
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }
        public IBookRepository bookRepository { get; set; }
        public IBookCategoryRepository bookCategoryRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Book BookInfor { get; set; }


        private void ClearText()
        {
            txtBookID.Text = string.Empty;
            txtBookName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            dtpReleaaseDate.Text = string.Empty;
        }


        private void frmBook_Load(object sender, EventArgs e)
        {
            cboCategory.DataSource = bookCategoryRepository.GetBookCategories();

            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";
            txtBookID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {



                txtBookID.Text = BookInfor.BookId.ToString();
                txtBookName.Text = BookInfor.BookName;
                txtDescription.Text = BookInfor.Description;
                dtpReleaaseDate.Value = BookInfor.ReleaseDate;
                txtQuantity.Text = BookInfor.Quantity.ToString();
                txtPrice.Text = BookInfor.Price.ToString();


                cboCategory.SelectedValue = BookInfor.BookCategoryId;
                txtAuthor.Text = BookInfor.Author;



            }
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }




        private bool ValidateInput()
        {
            // Kiểm tra điều kiện cho txtPrice và txtQuantity
            if (!IsNonNegativeNumber(txtPrice.Text) || !IsNonNegativeNumber(txtQuantity.Text))
            {
                MessageBox.Show("Price and Quantity must be non-negative numbers.");
                return false;
            }

            // Kiểm tra điều kiện cho txtBookName
            string bookName = txtBookName.Text.Trim();
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

            if (!IsTitleCase(bookName))
            {
                MessageBox.Show("Book Name must start with an uppercase letter.");
                return false;
            }

            return true;
        }

        private bool IsNonNegativeNumber(string input)
        {
            if (!double.TryParse(input, out double result) || result < 0)
            {
                return false;
            }
            return true;
        }

        private bool IsTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word) || !char.IsUpper(word[0]))
                {
                    return false;
                }
            }

            return true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtBookID.Text) ||
               string.IsNullOrEmpty(txtBookName.Text) ||
               string.IsNullOrEmpty(txtDescription.Text) ||
               string.IsNullOrEmpty(txtPrice.Text) ||
               string.IsNullOrEmpty(txtQuantity.Text) ||
               string.IsNullOrEmpty(dtpReleaaseDate.Text)
               || string.IsNullOrEmpty(cboCategory.Text))
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


                var book = new Book()
                {
                    BookId = int.Parse(txtBookID.Text),
                    BookName = txtBookName.Text,
                    Description = txtDescription.Text,
                    ReleaseDate = dtpReleaaseDate.Value.Date,
                    Quantity = int.Parse(txtQuantity.Text),
                    Price = double.Parse(txtPrice.Text),

                    BookCategoryId = int.Parse(cboCategory.SelectedValue.ToString()),
                    Author = txtAuthor.Text,


                };
                if (InsertOrUpdate)
                {
                    bookRepository.update(book);
                    MessageBox.Show("Update successful");
                }
                else
                {
                    bookRepository.insert(book);
                    MessageBox.Show("Add successful");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
