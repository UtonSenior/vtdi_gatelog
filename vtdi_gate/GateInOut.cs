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
        //Create an instance of the database
        private vtdi_gatelog_dbEntities ctx = new vtdi_gatelog_dbEntities();

        public GateInOut()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DateTime.Now gets the current date time.
            var recordDate = DateTime.Now;

            var firstName = tbFirstName.Text;
            var lastName = tbLastName.Text;
            var plateNumber = tbPlateNumber.Text;
            var vehicle = cbbVehicleType.SelectedValue;
            var purpose = cbbPurpose.SelectedValue;
            var declare = cbbDeclare.SelectedValue;

            //

            if (String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(plateNumber))
            {
                MessageBox.Show("Last Name and Plate Number is Required!");
            }
            else
            {
                var getLogInfo = new tblGateInOut()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    PlateNumber = plateNumber,
                    VehicleTypeId = (int)vehicle,
                    PurposeId = Convert.ToInt32(purpose),
                    ItemsToDeclareId = (int)declare,
                    DateTimeIn = recordDate,
                    UserId = 1 //Task to Find a way to include the user id after login
                };
                ctx.tblGateInOuts.Add(getLogInfo);
                ctx.SaveChanges();
            }
        }

        private void GateInOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vtdi_gatelog_dbDataSet3.tblVehicleTypes' table. You can move, or remove it, as needed.
            this.tblVehicleTypesTableAdapter.Fill(this.vtdi_gatelog_dbDataSet3.tblVehicleTypes);
            // TODO: This line of code loads data into the 'vtdi_gatelog_dbDataSet2.tblItemsToDeclare' table. You can move, or remove it, as needed.
            this.tblItemsToDeclareTableAdapter.Fill(this.vtdi_gatelog_dbDataSet2.tblItemsToDeclare);
            // TODO: This line of code loads data into the 'vtdi_gatelog_dbDataSet1.tblPurposeOfVisit' table. You can move, or remove it, as needed.
            this.tblPurposeOfVisitTableAdapter1.Fill(this.vtdi_gatelog_dbDataSet1.tblPurposeOfVisit);

        }
    }
}
