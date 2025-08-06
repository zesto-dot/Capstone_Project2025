using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View
{
    public partial class ucPatient : UserControl
    {
        public ucPatient()
        {
            InitializeComponent();
        }

        private void ucPatient_Load(object sender, EventArgs e)
        {
            Model.Patients.Load(dgvPatient);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Patients.Add();
            Model.Patients.Load(dgvPatient);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you really want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && (dgvPatient.RowCount > 0))
            {
                Model.Patients.ID = Convert.ToInt32(dgvPatient.CurrentRow.Cells[0].Value);
                Model.Patients.Delete(dgvPatient);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Model.Patients.Edit(dgvPatient);
            Model.Patients.Load(dgvPatient);

        }
    }
}
