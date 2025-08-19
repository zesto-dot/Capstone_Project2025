using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.View.Backup
{
    public partial class frmRecordAddEdit : Form
    {
        private bool isEdit = false;
        public frmRecordAddEdit(bool edit = false)
        {
            InitializeComponent();
            isEdit = edit;

            if (isEdit)
            {
                cmbVisitType.Text = Model.PatientRecord.VisitType;
                cmbPurposeofVisit.SelectedValue = Model.PatientRecord.ServiceID ;
                txtBP.Text= Model.PatientRecord.BloodPressure;
                txtTemp.Text= Model.PatientRecord.Temperature;
                txtHeight.Text = Model.PatientRecord.Height;
                txtWeight.Text= Model.PatientRecord.Weight;
                txtChiefcomplaint.Text= Model.PatientRecord.ChiefComplaint;
                txtDiagnosis.Text = Model.PatientRecord.Diagnosis;
                txtMedication.Text = Model.PatientRecord.MedicationTreatment;
                txtLaboratoryFindings.Text = Model.PatientRecord.LaboratoryFindings;
                cmbAttendedby.SelectedValue = Model.PatientRecord.DoctorID;


                lblText.Text = "Edit Record";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.PatientRecord.VisitType = cmbVisitType.Text;
            Model.PatientRecord.ServiceID = Convert.ToInt32(cmbPurposeofVisit.SelectedValue);
            Model.PatientRecord.BloodPressure = txtBP.Text;
            Model.PatientRecord.Temperature = txtTemp.Text;
            Model.PatientRecord.Height = txtHeight.Text;
            Model.PatientRecord.Weight = txtWeight.Text;
            Model.PatientRecord.ChiefComplaint = txtChiefcomplaint.Text;
            Model.PatientRecord.Diagnosis = txtDiagnosis.Text;
            Model.PatientRecord.MedicationTreatment = txtMedication.Text;
            Model.PatientRecord.LaboratoryFindings = txtLaboratoryFindings.Text;
            Model.PatientRecord.DoctorID = Convert.ToInt32(cmbAttendedby.SelectedValue);
            Model.PatientRecord.Created_at = DateTime.Now;

            if (isEdit)
                Model.PatientRecord.Update();
            else
                Model.PatientRecord.Save();
            this.Dispose();
        }

        private void frmRecordAddEdit_Load(object sender, EventArgs e)
        {
            if (Model.PatientRecord.PatientID == 0)
                Model.PatientRecord.PatientID = Model.Patients.ID;
            Model.PatientRecord.Cmb(cmbPurposeofVisit);
            Model.Doctors.Cmb(cmbAttendedby);
        }
    }
}
