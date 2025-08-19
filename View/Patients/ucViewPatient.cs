using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.Patients
{
    public partial class ucViewPatient : UserControl
    {

        public ucViewPatient()
        {

            InitializeComponent();
        }

        private void ucViewPatient_Load(object sender, EventArgs e)
        {
            lblLastname.Text = Model.Patients.Lname;
            lblFirstname.Text = Model.Patients.Fname;
            lblMiddlename.Text = Model.Patients.Mname;
            lblSuffix.Text = Model.Patients.Suffix;
            lblSex.Text = Model.Patients.Sex;
            lblAge.Text = Model.Patients.Age.ToString();
            lblBirthdate.Text = Model.Patients.Birthdate.ToString("MMMM dd, yyyy");
            lblBirthplace.Text = Model.Patients.Birthplace;
            lblBloodtype.Text = Model.Patients.Bloodtype;
            lblResidentialAddress.Text = Model.Patients.Address;
            lblContactNumber.Text = Model.Patients.ContactNumber;
            lblCivilStatus.Text = Model.Patients.CivilStatus;
            lblSpousename.Text = Model.Patients.SpouseName;
            lblMothername.Text = Model.Patients.MotherName;
            lblEducationalAttainment.Text = Model.Patients.EducationalAttainment;
            lblEmploymentStatus.Text = Model.Patients.EmploymentStatus;
            lblFamilyPosition.Text = Model.Patients.FamilyPosition;
            rbDSWDYes.Checked = Model.Patients.Dswd_Nhts;
            lblFacilityHouseHoldNo.Text = Model.Patients.FacilityHouseHoldNo;
            rb4PSyes.Checked = Model.Patients.FourPsMember;
            lblHouseholdNo.Text = Model.Patients.HouseHoldno;
            rbPHyes.Checked = Model.Patients.PhilHealthMember;
            lblStatusType.Text = Model.Patients.PhilHealthType;
            lblPhilhealthNo.Text = Model.Patients.PhilHealthNo;
            lblMember.Text = Model.Patients.IfMember;
            rbPCByes.Checked = Model.Patients.PcbMember;

            Model.PatientRecord.Load(dgvRecord);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.PatientRecord.PatientID = Model.Patients.ID;
            Model.PatientRecord.Add();
            Model.PatientRecord.Load(dgvRecord);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Model.Patients.Back(this.Parent as Panel);
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvRecord.Columns[e.ColumnIndex].Name == "ViewButton")
                {
                    
                }
               
                else if (dgvRecord.Columns[e.ColumnIndex].Name == "EditButton")
                {
                    Model.PatientRecord.Edit(dgvRecord);
                    Model.PatientRecord.Load(dgvRecord);
                }
                 else if (dgvRecord.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    if (MessageBox.Show("Do you really want to delete this Record?", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Model.PatientRecord.ID = Convert.ToInt32(dgvRecord.CurrentRow.Cells[3].Value);
                        Model.PatientRecord.Delete(dgvRecord);
                    }
                }
            }
        }
    }
}
