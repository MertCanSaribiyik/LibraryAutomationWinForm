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
    public partial class UserListForm : Form
    {
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            var users = db.Users.ToList();
            dataGridView1.DataSource = users;
        }
    }
}
