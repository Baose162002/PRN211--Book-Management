﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using BookObject.Models;
using DataAccess.Repository;
using BookObject.DTO;
using BookObject.Mapper;
using System.DirectoryServices;

namespace BookManagement_TranQuocBao
{
    public partial class frmBookManagement : Form
    {
        public frmBookManagement()
        {
            InitializeComponent();
        }
        public void EnableCreateAndUpdate()
        {
            btnCreate.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = false;
        }

        // Method to enable view-only functionality
        public void EnableViewOnly()
        {
            btnCreate.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private BookRepository bookRepository = new BookRepository();
        private BookCategoryRepository bookCategoryRepository = new BookCategoryRepository();
        private BindingSource bookSource;

        public void LoadBook(List<Book> books)
        {
            bookSource = new BindingSource();
            if (books != null && books.Count == 0)
            {
                dgvBook.DataSource = null;
                return;
            }

            books = books == null ? bookRepository.GetAllBook() : books;
            var config = new MapperConfiguration(cfg =>
            {
                BookConfig.createMap(cfg);
            });

            var mapperBookCon = config.CreateMapper();

            var list = books.Select(
                air => mapperBookCon
                .Map<Book, BookDTO>(air)
                );
            bookSource.DataSource = list;

            txtBookID.DataBindings.Clear();
            txtBookName.DataBindings.Clear();
            txtDescription.DataBindings.Clear();
            dtpReleaseDate.DataBindings.Clear();
            txtQuanity.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtAuthor.DataBindings.Clear();
            cboCategory.DataBindings.Clear();

            txtBookID.DataBindings.Add("Text", bookSource, "BookId");
            txtBookName.DataBindings.Add("Text", bookSource, "BookName");
            txtDescription.DataBindings.Add("Text", bookSource, "Description");
            dtpReleaseDate.DataBindings.Add("Text", bookSource, "ReleaseDate");
            txtQuanity.DataBindings.Add("Text", bookSource, "Quantity");
            txtPrice.DataBindings.Add("Text", bookSource, "Price");
            txtAuthor.DataBindings.Add("Text", bookSource, "Author");

            dgvBook.DataSource = null;
            dgvBook.DataSource = bookSource;

            cboCategory.DataSource = bookCategoryRepository.GetBookCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";
            cboCategory.DataBindings.Add("SelectedValue", bookSource, "BookCategoryId");



        }

        private void frmBookManagement_Load(object sender, EventArgs e)
        {
            LoadBook(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you ready want to delete", "Book Manager", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.OK)
            {
                bookRepository.delete(int.Parse(txtBookID.Text));
                LoadBook(null);
            }


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmBook frmBook = new frmBook
            {
                Text = "Add Book",
                InsertOrUpdate = false,
                

                bookRepository = bookRepository,
                bookCategoryRepository = bookCategoryRepository,
            };
            if (frmBook.ShowDialog() == DialogResult.OK)
            {
                LoadBook(null);
            }
        }
        public Book GetBook()
        {
            Book book = null;
            try
            {
                int index = dgvBook.CurrentCell.RowIndex;
                var dummy = (Book)dgvBook.Rows[index].DataBoundItem;
                book = bookRepository.GetBookById(dummy.BookId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return book;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmBook frmBook = new frmBook
            {
                Text = "Update Book",
                InsertOrUpdate = true,
                BookInfor = GetBook(),
                bookRepository = bookRepository,
                bookCategoryRepository = bookCategoryRepository,
            };
            if (frmBook.ShowDialog() == DialogResult.OK)
            {
                LoadBook(null);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchKeyword))
            {
                var searchResults = bookRepository.SearchBooks(searchKeyword);

                if (searchResults.Count > 0)
                {
                    bookSource.DataSource = searchResults;
                    ResetBindings();
                }
                else
                {
                    MessageBox.Show("No matching books found.");
                }
            }
            else
            {
                // If the search keyword is empty, reload all books
                LoadBook(null);
            }
        }

        // Helper method to reset the data bindings
        private void ResetBindings()
        {
            dgvBook.DataSource = null;
            dgvBook.DataSource = bookSource;
            dgvBook.Columns["BookCategory"].Visible = false;

            // Remove existing bindings from cboCategory before adding new ones
            cboCategory.DataBindings.Clear();

            cboCategory.DataSource = bookCategoryRepository.GetBookCategories();
            cboCategory.DisplayMember = "BookGenreType";
            cboCategory.ValueMember = "BookCategoryId";
            cboCategory.DataBindings.Add("SelectedValue", bookSource, "BookCategoryId");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadBook(null);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
