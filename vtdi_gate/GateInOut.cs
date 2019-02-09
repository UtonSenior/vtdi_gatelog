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
    public partial class GateInOut : Form
    {
        public GateInOut()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DateTime.Now gets the current date time.
            var recordDate = DateTime.Now;

            String firstName = tbFirstName.Text;
            String lastName = tbLastName.Text;
            String vehicle = tbVechicleType.Text;
            int plateNumber = Convert.ToInt16(tbPlateNumber.Text);

            if (String.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name is Required!");
            }
            else
            {
                MessageBox.Show
                    (
                        "FirstName: "
                    );
            }
        }
    }
}
