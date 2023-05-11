using LibraryAutomationWinForm.BookOperationFolder;
using LibraryAutomationWinForm.UserOperationFolder;
using LibraryAutomationWinForm.Record_Operation;
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
    public partial class ActionForm : Form
    {
        public ActionForm()
        {
            InitializeComponent();
        }

        private void ActionForm_Load(object sender, EventArgs e)
        {
            //Users butonları girişte kapalıdır.
            AddUserbtn.Visible = false;
            EditUserbtn.Visible = false;    
            RemoveUserbtn.Visible = false;

            //Books butonları girişte kapalıdır.
            AddBookbtn.Visible = false;
            EditBookbtn.Visible = false;
            RemoveBookbtn.Visible = false;
        }

        private void Usersbtn_Click(object sender, EventArgs e)
        {
            if (!AddUserbtn.Visible)                    //Eğer users butonua tıklandığında diğer butonlar kapalıysa açılır.
            {
                AddUserbtn.Visible = true;
                EditUserbtn.Visible = true;
                RemoveUserbtn.Visible = true;
            }
            else                                       //Eğer users butonuna tıklandığında diğer butonlar açıksa kapanır.
            {
                AddUserbtn.Visible = false;
                EditUserbtn.Visible = false;
                RemoveUserbtn.Visible = false;
            }

            UserListForm form = new UserListForm();
            form.MdiParent = this;
            form.Show();
        }

        private void AddUserbtn_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();
            form.MdiParent= this;
            form.Show();
        }

        private void EditUserbtn_Click(object sender, EventArgs e)
        {
            EditUserForm form = new EditUserForm();
            form.MdiParent = this;
            form.Show();
        }

        private void RemoveUserbtn_Click(object sender, EventArgs e)
        {
            RemoveUserForm form = new RemoveUserForm();
            form.MdiParent = this;
            form.Show();
        }

        private void Booksbtn_Click(object sender, EventArgs e)
        {
            if (!AddBookbtn.Visible)        //Eğer books butonua tıklandığında diğer butonlar kapalıysa açılır.
            {
                AddBookbtn.Visible = true;
                EditBookbtn.Visible = true;
                RemoveBookbtn.Visible = true;
            }
            else                            //Eğer books butonuna tıklandığında diğer butonlar açıksa kapanır.    
            {
                AddBookbtn.Visible = false;
                EditBookbtn.Visible = false;
                RemoveBookbtn.Visible = false;
            }

            BookListForm form = new BookListForm();
            form.MdiParent = this;         
            form.Show();
        }

        private void AddBookbtn_Click(object sender, EventArgs e)
        {
            AddBookForm form = new AddBookForm();
            form.MdiParent = this;
            form.Show();
        }

        private void EditBookbtn_Click(object sender, EventArgs e)
        {
            EditBookForm form = new EditBookForm();
            form.MdiParent = this;
            form.Show();
        }

        private void RemoveBookbtn_Click(object sender, EventArgs e)
        {
            RemoveBookForm form = new RemoveBookForm();
            form.MdiParent = this;
            form.Show();
        }

        private void Lendbtn_Click(object sender, EventArgs e)
        {
            LendForm form = new LendForm();
            form.MdiParent = this;
            form.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            BackForm form = new BackForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
