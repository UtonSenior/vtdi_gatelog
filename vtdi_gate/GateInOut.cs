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
            String plateNumber = tbPlateNumber.Text;
            String purpose = tbPurpose.Text;
            String declare = clbItemsToDeclare.SelectedItem.ToString();
            String dateIn = dtpDateIn.Text;
            String timeIn = dtpTimeIn.Text;

            //

            if (String.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name is Required!");
            }
            else
            {
                MessageBox.Show
                    (
                        $"FirstName: {firstName} \n" +
                        $"LastName: {lastName} \n" +
                        $"Vehicle: {vehicle} \n" +
                        $"Plate Number: {plateNumber} \n" +
                        $"Purpose of Visit: {purpose} \n" +
                        $"Items to Declare: {declare} \n\n"+
                        $"Date In: {dateIn} \n"+
                        $"Time In: {timeIn} \n"
                    );
            }
        }
    }
}
