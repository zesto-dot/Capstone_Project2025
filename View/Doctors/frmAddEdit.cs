using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.Doctors
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
                txtLastname.Text = Model.Doctors.Lname;
                txtFirstname.Text = Model.Doctors.Fname;
                TxtMiddlename.Text = Model.Doctors.Mname;
                
                cmbSex.Text = Model.Doctors.Sex;
                
                txtContactnumber.Text = Model.Doctors.ContactNumber;
                
                cmbSpecialization.SelectedValue = Model.Doctors.SpecializationID;

                

                lblText.Text = "Edit Doctor";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Doctors.Lname = txtLastname.Text;
            Model.Doctors.Fname = txtFirstname.Text;
            Model.Doctors.Mname = TxtMiddlename.Text;
            Model.Doctors.Sex = cmbSex.Text;
            Model.Doctors.ContactNumber = txtContactnumber.Text;
            Model.Doctors.SpecializationID = Convert.ToInt32(cmbSpecialization.SelectedValue);
            Model.Doctors.Created_At = DateTime.Now;

            if (isEdit)
                Model.Doctors.Update();
            else
                Model.Doctors.Save();
            this.Dispose();
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            Model.Specialization.Cmb(cmbSpecialization);
        }

       
    }

       
    }
