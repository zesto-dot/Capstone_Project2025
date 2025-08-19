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
    public partial class frmSpecializationAddEdit : Form
    {
        private bool isEdit = false;
        public frmSpecializationAddEdit(bool edit = false)
        {
            InitializeComponent();
            isEdit = edit;
            if (isEdit)
            {
                txtSpecialization.Text = Model.Specialization.Description;
                lblText.Text = "Edit Specialization";
            }

                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Specialization.Description = txtSpecialization.Text;

            if (isEdit)
                Model.Specialization.Update();
            else
                Model.Specialization.Save();
            this.Dispose();
        }
    }
}
