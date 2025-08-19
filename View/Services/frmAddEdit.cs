using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.Services
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
                txtServices.Text = Model.Services.Name;
                txtDescription.Text = Model.Services.Description;

                lblText.Text = "Edit Services";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Services.Name = txtServices.Text;
            Model.Services.Description = txtDescription.Text;
            if (isEdit)
                Model.Services.Update();
            else
                Model.Services.Save();
            this.Dispose();
        }
    }
}
