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
    public partial class BookListForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        public BookListForm()
        {
            InitializeComponent();
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            var books = db.Books.ToList();
            dataGridView1.DataSource = books;
        }
    }
}
