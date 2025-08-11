using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.Doctors
{
    public partial class ucDoctors : UserControl
    {
        public ucDoctors()
        {
            InitializeComponent();
        }

        private void ucDoctors_Load(object sender, EventArgs e)
        {
            Model.Doctors.Load(dgvDoctors);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Doctors.Add();
            Model.Doctors.Load(dgvDoctors);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you really want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) && (dgvDoctors.RowCount > 0))
            {
                Model.Doctors.ID = Convert.ToInt32(dgvDoctors.CurrentRow.Cells[0].Value);
                Model.Doctors.Delete(dgvDoctors );
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
