using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gate
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String username = tbUserName.Text;
            String password = tbPassword.Text;

            // vtdi_gatelog_dbEntities ctx = new vtdi_gatelog_dbEntities(); or

            //Declaring an object of the database model
            var ctx = new vtdi_gatelog_dbEntities();
            var userCount = ctx.tblUsers.Count(q => q.Username == username && q.Password == password);

            //String.IsNullOrEmpty
            if (String.IsNullOrEmpty(username) && String.IsNullOrEmpty(password))
            {
                MessageBox.Show("You did not enter any values");
            }
            // You can use the String.Equals() function to compare
            // two tring values and see if they are eqaul.
            else if (userCount == 1)
            {
                MessageBox.Show($"Login was successfull for {username}");
                //Declaring an object of type Form1
                var parent = (Form1)this.MdiParent;
                parent.isLogIn = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
