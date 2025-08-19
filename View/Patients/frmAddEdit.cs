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
                txtMiddlename.Text = Model.Patients.Mname;
                cmbSuffix.Text = Model.Patients.Suffix;
                cmbSex.Text = Model.Patients.Sex;
                dtpBirthdate.Value = Model.Patients.Birthdate;
                txtBirthplace.Text = Model.Patients.Birthplace;
                cmbBloodtype.Text = Model.Patients.Bloodtype;
                txtStreet.Text = Model.Patients.Address;
                txtContactnumber.Text = Model.Patients.ContactNumber;
                cmbCivilstatus.Text = Model.Patients.CivilStatus;
                txtSpousename.Text = Model.Patients.SpouseName;
                txtMothername.Text = Model.Patients.MotherName;
                cmbEducationalAttainment.Text = Model.Patients.EducationalAttainment;
                cmbEmploymentStatus.Text = Model.Patients.EmploymentStatus;
                cmbFamilyPosition.Text = Model.Patients.FamilyPosition;
               
                txtFacilityHouseHoldNo.Text = Model.Patients.FacilityHouseHoldNo;
                rb4PSyes.Checked = Model.Patients.FourPsMember;
                txtHouseholdNo.Text = Model.Patients.HouseHoldno;
               
                lblText.Text = "Edit Patient";
            }
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Patients.Lname = txtLastname.Text;
            Model.Patients.Fname = txtFirstname.Text;
            Model.Patients.Mname = txtMiddlename.Text;
            Model.Patients.Suffix = cmbSuffix.Text;
            Model.Patients.Sex = cmbSex.Text;
            Model.Patients.Birthdate = dtpBirthdate.Value;
            Model.Patients.Birthplace = txtBirthplace.Text;
            Model.Patients.Bloodtype = cmbBloodtype.Text;
            Model.Patients.Address = txtStreet.Text;
            Model.Patients.ContactNumber = txtContactnumber.Text;
            Model.Patients.CivilStatus = cmbCivilstatus.Text;
            Model.Patients.SpouseName = txtSpousename.Text;
            Model.Patients.MotherName = txtMothername.Text;
            Model.Patients.EducationalAttainment = cmbEducationalAttainment.Text;
            Model.Patients.EmploymentStatus = cmbEmploymentStatus.Text;
            Model.Patients.FamilyPosition = cmbFamilyPosition.Text;
           
            Model.Patients.FacilityHouseHoldNo = txtFacilityHouseHoldNo.Text;
            Model.Patients.FourPsMember = rb4PSyes.Checked;
            Model.Patients.HouseHoldno = txtHouseholdNo.Text;
            
            
            Model.Patients.Created_At = DateTime.Now;
            

            if (isEdit)
                Model.Patients.Update();
            else
                Model.Patients.Save();
            this.Dispose();
            
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            Model.Patients.LoadProvinces(cmbProvince);
        }
    }
}
