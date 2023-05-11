using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomationWinForm.UserOperationFolder
{
    public partial class RemoveUserForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();
        public void list()      //Veri tabanındaki kullanıcılar tablosunu listelemeyi sağlar.
        {
            var users = db.Users.ToList();
            dataGridView1.DataSource = users;
        }

        public RemoveUserForm()
        {
            InitializeComponent();
        }

        private void RemoveUserForm_Load(object sender, EventArgs e)
        {
            list();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            int selectedID = (int) dataGridView1.CurrentRow.Cells[0].Value;
            var user = db.Users.Where(x => x.userr_id == selectedID).FirstOrDefault();  //Seçilen satırdaki id numarası veri tabanındaki users tablosunda aranır.
            db.Users.Remove(user);
            db.SaveChanges();
            list();
        }
    }
}
