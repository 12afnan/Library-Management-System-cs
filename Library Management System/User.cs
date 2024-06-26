using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);

        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.libraryDataSet.User);
        }
    }
}
