using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomationWinForm.Record_Operation
{
    public partial class LendForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        public void recordList()      
        {
            var records = from Record in db.Records select new { Record.record_id, Record.User.userr_name, Record.Book.book_name,
                                                                Record.startDate, Record.finishDate };     
            
            dataGridView1.DataSource = records.ToList();
        }

        public void bookList()
        {
            var books = db.Books.ToList();          //Veri tabanındaki kitaplar tablosunu datagridview2`e listeliyoruz.
            dataGridView2.DataSource = books;
        }

        public LendForm()
        {
            InitializeComponent();
        }

        private void LendForm_Load(object sender, EventArgs e)
        {
            recordList();
            bookList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searched = TCtxt.Text;
            var user = db.Users.Where(x => x.user_TC.Equals(searched)).FirstOrDefault();     //Text`e girilen TC veri tabanında bulunup user değişkenine atanır. Eğer veri tabanında yoksa user değişkeni null olur

            if (user != null)
                label2.Text = user.userr_name + " " + user.user_lastname;
            else
                label2.Text = "User not found...";
        }

        private void bookNametxt_TextChanged(object sender, EventArgs e)
        {
            string bookName = bookNametxt.Text;
            var book = db.Books.Where(x => x.book_name.Contains(bookName)).ToList();
            dataGridView2.DataSource = book;
        }

        private void lendBtn_Click(object sender, EventArgs e)
        {
            string searchedUser = TCtxt.Text;
            var user = db.Users.Where(x => x.user_TC.Equals(searchedUser)).FirstOrDefault();        //Text`e girilen kişinin bilgilerini veri tabanından alıp user değişkenine kaydettik.

            int bookID = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var book = db.Books.Where(x => x.book_id == bookID).FirstOrDefault();       //Book id`ye göre kitap bilgilerini veri tabanından alıp book değişkenine kaydettik.

            Record newRecord = new Record();
            newRecord.userr_id = user.userr_id;
            newRecord.book_id = book.book_id;
            newRecord.startDate = DateTime.Today;
            newRecord.finishDate = DateTime.Today.AddDays(15);
            newRecord.statuss = false;
            db.Records.Add(newRecord);
            db.SaveChanges();
            recordList();
        }
    }
}
