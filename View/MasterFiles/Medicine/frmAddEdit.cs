using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.MasterFiles.Medicine
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
                txtCode.Text = Model.Medicine.Code;
                txtDescription.Text = Model.Medicine.Description;

                lblText.Text = "Edit Medicine";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Medicine.Code = txtCode.Text;
            Model.Medicine.Description = txtDescription.Text;
            if (isEdit)
                Model.Medicine.Update();
            else
                Model.Medicine.Save();
            this.Dispose();
        }
    }
}
