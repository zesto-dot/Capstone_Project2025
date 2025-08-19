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
    public partial class ucSpecialization : UserControl
    {
        public ucSpecialization()
        {
            InitializeComponent();
        }

        private void ucSpecialization_Load(object sender, EventArgs e)
        {
            Model.Specialization.Load(dgvSpecialization);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Specialization.Add();
            Model.Specialization.Load(dgvSpecialization);
        }

       

        private void dgvSpecialization_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvSpecialization.Columns[e.ColumnIndex].Name == "EditButton")
                {

                    Model.Specialization.Edit(dgvSpecialization);
                    Model.Specialization.Load(dgvSpecialization);
                }
                else if (dgvSpecialization.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    if (MessageBox.Show("Do you really want to delete this Record?", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Model.Specialization.ID = Convert.ToInt32(dgvSpecialization.CurrentRow.Cells[2].Value);
                        Model.Specialization.Delete(dgvSpecialization);
                    }
                }
            }
        }
    }
}
