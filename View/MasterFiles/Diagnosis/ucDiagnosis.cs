using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.MasterFiles.Diagnosis
{
    public partial class ucDiagnosis : UserControl
    {
        public ucDiagnosis()
        {
            InitializeComponent();
        }

        private void ucDiagnosis_Load(object sender, EventArgs e)
        {
            Model.Diagnosis.Load(dgvDiagnosis);
        }
    }
}
