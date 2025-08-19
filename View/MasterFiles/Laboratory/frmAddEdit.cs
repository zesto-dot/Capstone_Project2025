using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.MasterFiles.Laboratory
{
    public partial class frmAddEdit : Form
    {
        private bool isEdit = false;
        public frmAddEdit(bool edit = false)
        {
            InitializeComponent();
            isEdit = edit;
            if (isEdit)
            {
                txtLabtest.Text = Model.Laboratory.test_name;
                lblText.Text = "Edit Laboratory";
            }

                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Laboratory.test_name = txtLabtest.Text;

            if (isEdit)
                Model.Laboratory.Update();
            else
                Model.Laboratory.Save();
            this.Dispose();
        }
    }
}
