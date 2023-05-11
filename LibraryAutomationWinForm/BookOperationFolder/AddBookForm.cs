using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomationWinForm.BookOperationFolder
{
    public partial class AddBookForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        public void list()      //Veri tabanındaki kitaplar tablosunu listelemeyi sağlar.
        {
            var books = db.Books.ToList();
            dataGridView1.DataSource = books;
        }

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Book books = new Book();

            books.book_name = nametxt.Text;
            books.book_authorName = authornametxt.Text;
            books.book_publisher = publishertxt.Text;
            books.book_page = (int)numericUpDown1.Value;
            books.book_publicationDate = dateTimePicker1.Value;

            db.Books.Add(books);
            db.SaveChanges();

            list();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            list();
        }
    }
}
