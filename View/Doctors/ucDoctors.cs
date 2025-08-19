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

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvDoctors.Columns[e.ColumnIndex].Name == "EditButton")
                {
                    Model.Doctors.Edit(dgvDoctors);
                    Model.Doctors.Load(dgvDoctors);
                }
                else if (dgvDoctors.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    if (MessageBox.Show("Do you really want to delete this Record?", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Model.Doctors.ID = Convert.ToInt32(dgvDoctors.CurrentRow.Cells[2].Value);
                        Model.Doctors.Delete(dgvDoctors);
                    }
                }
            }
        }
    }
}
