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
    public partial class BackForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        public void list()
        {
            var records = from Record in db.Records select new { Record.record_id, Record.User.userr_name, Record.Book.book_name,
                                                                 Record.startDate, Record.finishDate };
            
            dataGridView1.DataSource = records.ToList();
        }

        public BackForm()
        {
            InitializeComponent();
        }

        private void BackForm_Load(object sender, EventArgs e)
        {
            list();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var record = db.Records.Where(x => x.record_id == selectedID).FirstOrDefault();

            record.statuss = true;
            db.SaveChanges();
            list();
        }
    }
}
