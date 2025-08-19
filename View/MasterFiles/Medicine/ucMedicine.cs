using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.MasterFiles.Medicine
{
    public partial class ucMedicine : UserControl
    {
        public ucMedicine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Medicine.Add();
            Model.Medicine.Load(dgvMedicine);
        }

        private void dgvMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvMedicine.Columns[e.ColumnIndex].Name == "EditButton")
                {

                    Model.Medicine.Edit(dgvMedicine);
                    Model.Medicine.Load(dgvMedicine);
                }
                else if (dgvMedicine.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    if (MessageBox.Show("Do you really want to delete this Record?", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Model.Medicine.ID = Convert.ToInt32(dgvMedicine.CurrentRow.Cells[2].Value);
                        Model.Medicine.Delete(dgvMedicine);
                    }
                }
            }
        }

        private void ucMedicine_Load(object sender, EventArgs e)
        {
            Model.Medicine.Load(dgvMedicine);
        }
    }
}
