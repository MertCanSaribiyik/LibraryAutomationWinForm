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
    public partial class EditBookForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        public void list()      //Veri tabanındaki kitaplar tablosunu listelemeyi sağlar.
        {
            var books = db.Books.ToList();
            dataGridView1.DataSource = books;
        }

        public EditBookForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nametxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            authornametxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            publishertxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);  
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var book = db.Books.Where(x => x.book_id == selectedID).FirstOrDefault();

            book.book_name = nametxt.Text;
            book.book_authorName = authornametxt.Text;
            book.book_publisher = publishertxt.Text;
            book.book_page = Convert.ToInt16(numericUpDown1.Value);
            book.book_publicationDate = dateTimePicker1.Value;

            db.SaveChanges();
            list();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            list();
        }
    }
}
