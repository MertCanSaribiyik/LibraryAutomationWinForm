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
    public partial class EditUserForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        public void list()      //Veri tabanındaki kullanıcılar tablosunu listelemeyi sağlar.
        {
            var users = db.Users.ToList();
            dataGridView1.DataSource = users;
        }

        public EditUserForm()
        {
            InitializeComponent();
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            list();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nametxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lastnametxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            TCtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            phonetxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            mailtxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            finetxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            if(dataGridView1.CurrentRow.Cells[3].Value.ToString().Equals("M"))
                MaleRadioButton.Checked = true;
            else
                femaleRadioButton.Checked = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var user = db.Users.Where(x => x.userr_id == selectedID).FirstOrDefault();

            user.userr_name = nametxt.Text;
            user.user_lastname = lastnametxt.Text;
            user.user_TC = TCtxt.Text;
            user.user_phone = phonetxt.Text;
            user.user_mail = mailtxt.Text;
            user.user_fine = Convert.ToDouble(finetxt.Text);

            if (MaleRadioButton.Checked)
                user.user_gender = "M";

            else if (femaleRadioButton.Checked)
                user.user_gender = "F";

            db.SaveChanges();
            list();
        }
    }
}
