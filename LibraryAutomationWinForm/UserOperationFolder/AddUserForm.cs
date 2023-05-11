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
    public partial class AddUserForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        public void list()      //Veri tabanındaki kullanıcılar tablosunu listelemeyi sağlar.
        {
            var users = db.Users.ToList();
            dataGridView1.DataSource = users;
        }

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            list();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            User users = new User();

            users.userr_name = nametxt.Text;
            users.user_lastname = lastnametxt.Text;
            users.user_TC = TCtxt.Text;
            users.user_phone = phonetxt.Text;
            users.user_mail = mailtxt.Text;
            users.user_fine = Convert.ToDouble(finetxt.Text);

            if (MaleRadioButton.Checked)
                users.user_gender = "M";
                
            else if (femaleRadioButton.Checked)
                users.user_gender = "F";
          
            db.Users.Add(users);
            db.SaveChanges();
            
            list();
        }

    }
}
