using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.MasterFiles.Laboratory
{
    public partial class ucLaboratory : UserControl
    {
        public ucLaboratory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Laboratory.Add();
            Model.Laboratory.Load(dgvLaboratory);
        }

        private void ucLaboratory_Load(object sender, EventArgs e)
        {
            Model.Laboratory.Load(dgvLaboratory);
        }

        private void dgvLaboratory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvLaboratory.Columns[e.ColumnIndex].Name == "EditButton")
                {

                    Model.Laboratory.Edit(dgvLaboratory);
                    Model.Laboratory.Load(dgvLaboratory);
                }
                else if (dgvLaboratory.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    if (MessageBox.Show("Do you really want to delete this Record?", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Model.Laboratory.ID = Convert.ToInt32(dgvLaboratory.CurrentRow.Cells[2].Value);
                        Model.Laboratory.Delete(dgvLaboratory);
                    }
                }
            }
        }
    }
}
