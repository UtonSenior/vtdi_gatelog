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
    public partial class Form1 : Form
    {
        public bool isLogIn = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();  //Declaring an Object for login form
            login.MdiParent = this;             //Locking login form to parent form
            login.Show();                       //Showing login form
        }

        private void userManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management Clicked");
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduling Clicked");
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guest List Clicked");
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GateInOut gate = new GateInOut();  //Declaring an Object for login form
            gate.MdiParent = this;             //Locking login form to parent form
            gate.Show();                       //Showing login form
        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Reports Clicked");
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLogIn)
            {
                MessageBox.Show("User Logs Clicked");
            }
            else
            {
                Showloginform();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Showloginform() //Function to show form 
        {
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }
    }
}
