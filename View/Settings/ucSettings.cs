using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.Settings
{
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            
                Model.Services.UI(guna2Panel1);
            

           

        }


        private void ucSettings_Load(object sender, EventArgs e)
        {
            
            Model.Services.UI(guna2Panel1);
        }

        private void btnLaboratory_Click(object sender, EventArgs e)
        {
            Model.Laboratory.UI(guna2Panel1);
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            Model.Diagnosis.UI(guna2Panel1);
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            Model.Medicine.UI(guna2Panel1);
        }

        private void btnSpecialization_Click(object sender, EventArgs e)
        {
            Model.Specialization.UI(guna2Panel1);
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
