using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.Services
{
    public partial class ucServices : UserControl
    {
        public ucServices()
        {
            InitializeComponent();
        }

        private void ucServices_Load(object sender, EventArgs e)
        {
            Model.Services.Load(dgvServices);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Model.Services.Add();
            Model.Services.Load(dgvServices);
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvServices.Columns[e.ColumnIndex].Name == "EditButton")
                {
                   
                    Model.Services.Edit(dgvServices);
                    Model.Services.Load(dgvServices);
                }
                else if (dgvServices.Columns[e.ColumnIndex].Name == "DeleteButton")
                {
                    if (MessageBox.Show("Do you really want to delete this Record?", "Delete",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Model.Services.ID = Convert.ToInt32(dgvServices.CurrentRow.Cells[2].Value);
                        Model.Services.Delete(dgvServices);
                    }
                }
            }
        }
    }
}
