using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View
{
    public partial class frmAddEdit : Form
    {
        private bool isEdit = false;
        public frmAddEdit(bool edit = false)
        {
            InitializeComponent();
            isEdit = edit;

            if (isEdit)
            {
                txtLastname.Text = Model.Patients.Lname;
                txtFirstname.Text = Model.Patients.Fname;
                TxtMiddlename.Text = Model.Patients.Mname;
                txtSuffix.Text = Model.Patients.Suffix;
                cmbSex.Text = Model.Patients.Sex;
                dtpBirthdate.Value = Model.Patients.Birthdate;
                txtBirthplace.Text = Model.Patients.Birthplace;
                cmbBloodtype.Text = Model.Patients.Bloodtype;
                txtResidentialAddress.Text = Model.Patients.Address;
                txtContactnumber.Text = Model.Patients.ContactNumber;
                cmbCivilstatus.Text = Model.Patients.CivilStatus;
                txtSpousename.Text = Model.Patients.SpouseName;
                txtMothername.Text = Model.Patients.MotherName;
                cmbEducationalAttainment.Text = Model.Patients.EducationalAttainment;
                cmbEmploymentStatus.Text = Model.Patients.EmploymentStatus;
                cmbFamilyPosition.Text = Model.Patients.FamilyPosition;
                rbDSWDYes.Checked = Model.Patients.Dswd_Nhts;
                txtFacilityHouseHoldNo.Text = Model.Patients.FacilityHouseHoldNo;
                rb4PSyes.Checked = Model.Patients.FourPsMember;
                txtHouseholdNo.Text = Model.Patients.HouseHoldno;
                rbPHyes.Checked = Model.Patients.PhilHealthMember;
                cmbStatusType.Text = Model.Patients.PhilHealthType;
                txtPhilhealthNo.Text = Model.Patients.PhilHealthNo;
                txtMember.Text = Model.Patients.IfMember;
                rbPCByes.Checked = Model.Patients.PcbMember;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Patients.Lname = txtLastname.Text;
            Model.Patients.Fname = txtFirstname.Text;
            Model.Patients.Mname = TxtMiddlename.Text;
            Model.Patients.Suffix = txtSuffix.Text;
            Model.Patients.Sex = cmbSex.Text;
            Model.Patients.Birthdate = dtpBirthdate.Value;
            Model.Patients.Birthplace = txtBirthplace.Text;
            Model.Patients.Bloodtype = cmbBloodtype.Text;
            Model.Patients.Address = txtResidentialAddress.Text;
            Model.Patients.ContactNumber = txtContactnumber.Text;
            Model.Patients.CivilStatus = cmbCivilstatus.Text;
            Model.Patients.SpouseName = txtSpousename.Text;
            Model.Patients.MotherName = txtMothername.Text;
            Model.Patients.EducationalAttainment = cmbEducationalAttainment.Text;
            Model.Patients.EmploymentStatus = cmbEmploymentStatus.Text;
            Model.Patients.FamilyPosition = cmbFamilyPosition.Text;
            Model.Patients.Dswd_Nhts = rbDSWDYes.Checked;
            Model.Patients.FacilityHouseHoldNo = txtFacilityHouseHoldNo.Text;
            Model.Patients.FourPsMember = rb4PSyes.Checked;
            Model.Patients.HouseHoldno = txtHouseholdNo.Text;
            Model.Patients.PhilHealthMember = rbPHyes.Checked;
            Model.Patients.PhilHealthType = cmbStatusType.Text;
            Model.Patients.PhilHealthNo = txtPhilhealthNo.Text;
            Model.Patients.IfMember = txtMember.Text;
            Model.Patients.PcbMember = rbPCByes.Checked;
            Model.Patients.Created_At = DateTime.Now;
            

            if (isEdit)
                Model.Patients.Update();
            else
                Model.Patients.Save();
            this.Dispose();
            
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            
        }
    }
}
