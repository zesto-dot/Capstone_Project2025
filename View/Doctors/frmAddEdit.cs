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
        public frmAddEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Doctors.Lname = txtLastname.Text;
            Model.Doctors.Fname = txtFirstname.Text;
            Model.Doctors.Mname = TxtMiddlename.Text;
            Model.Doctors.Sex = cmbSex.Text;
            Model.Doctors.ContactNumber = txtContactnumber.Text;
            Model.Doctors.SpecializationID = cmbSpecialization.Text;
            Model.Doctors.Created_At = DateTime.Now;
            Model.Doctors.Save();
            this.Dispose();
        }
    }
}
