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
        }

        
    }
}
