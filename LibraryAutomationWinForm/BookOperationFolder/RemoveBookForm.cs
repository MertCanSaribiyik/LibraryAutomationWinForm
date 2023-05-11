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
    public partial class RemoveBookForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        public void list()      //Veri tabanındaki kitaplar tablosunu listelemeyi sağlar.
        {
            var books = db.Books.ToList();
            dataGridView1.DataSource = books;
        }

        public RemoveBookForm()
        {
            InitializeComponent();
        }

        private void RemoveBookForm_Load(object sender, EventArgs e)
        {
            list();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var book = db.Books.Where(x => x.book_id == selectedID).FirstOrDefault();  //Seçilen id numarası books tablosunda aranır ve o id numarasına sahip değerler book değişkenine kaydedilir.
            db.Books.Remove(book);
            db.SaveChanges();
            list();
        }
    }
}
