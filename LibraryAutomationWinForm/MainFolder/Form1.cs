using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomationWinForm
{
    public partial class Form1 : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();     //Veri tabanına erişim.

        public Form1()
        {
            InitializeComponent();
        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
            string userName = nametxt.Text;         //Kullanıcının textbox`a girdiklerini name ve password değişkenlerine kaydeder.
            string password = passwordtxt.Text;

            //Aşağıda kullanıcının yazdığı user name ve password`un veri tabanındaki Personals tablosunda uyuşup uyuşmadığını kontrol eder.
            //Uyuşmaz ise personal değişkenine NULL atanır.
            var personal = db.Personals.Where(x => x.Personal_userName.Equals(userName) && x.Personal_password.Equals(password)).FirstOrDefault();

            if(personal == null)
            {
                MessageBox.Show("Personal name or password is error !");
            }
            else
            {
                MessageBox.Show("Succesfull !");
                ActionForm form = new ActionForm();
                form.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = true;
        }
    }
}
