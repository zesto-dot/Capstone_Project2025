using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.Model
{
    public class PatientRecord
    {
        public static int ID { get; set; }
        public static int PatientID { get; set; }
        public static string VisitType { get; set; }
        public static int ServiceID { get; set; }
        public static string BloodPressure { get; set; }
        public static string Temperature { get; set; }
        public static string Height { get; set; }
        public static string Weight { get; set; }
        public static string ChiefComplaint { get; set; }
        public static string Diagnosis { get; set; }
        public static string MedicationTreatment { get; set; }
        public static string LaboratoryFindings { get; set; }
        public static int DoctorID { get; set; }
        public static DateTime Created_at { get; set; }


        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("SELECT * FROM `v.patientrecord` WHERE PatientID = "+ Model.Patients.ID) as IDisposable;
            d.DataSource = dt;


        }

        public static void FixGrid(DataGridView d)
        {
           

        }
        public static void View(DataGridView d)
        {
            if (d.CurrentRow != null)
            {
                ID = Convert.ToInt32(d.CurrentRow.Cells[3].Value);

                DataTable dt = Controller.MySQL.Pull("SELECT * FROM patientrecord WHERE ID = " + ID);
                if (dt.Rows.Count > 0)
                {

                    var r = dt.Rows[0];
                    VisitType = r["NatureOfVisit"].ToString();
                    ServiceID = Convert.ToInt32(r["ServiceID"]);
                    BloodPressure = r["Bloodpressure"].ToString();
                    Temperature = r["Temperature"].ToString();
                    Height = r["Height"].ToString();
                    Weight = r["Weight"].ToString();
                    ChiefComplaint = r["Chiefcomplaint"].ToString();
                    Diagnosis = r["Diagnosis"].ToString();
                    MedicationTreatment = r["Medicationtreatment"].ToString();
                    LaboratoryFindings = r["LaboratoryFindings"].ToString();
                    DoctorID = Convert.ToInt32(r["DoctorID"]);
                    

                }

                Controller.Service.ShowForm(new View.Patients.frmRecordAddEdit());
            }

        }
        public static void Add()
        {
            Controller.Service.ShowForm(new View.Patients.frmRecordAddEdit());

        }
        public static void Edit(DataGridView d)
        {
            if (d.CurrentRow != null)
            {
                ID = Convert.ToInt32(d.CurrentRow.Cells[3].Value);

                DataTable dt = Controller.MySQL.Pull("SELECT * FROM patientrecord WHERE ID = " + ID);
                if (dt.Rows.Count > 0)
                {

                    var r = dt.Rows[0];
                    VisitType = r["NatureOfVisit"].ToString();
                    ServiceID = Convert.ToInt32(r["ServiceID"]);
                    BloodPressure = r["Bloodpressure"].ToString();
                    Temperature = r["Temperature"].ToString();
                    Height = r["Height"].ToString();
                    Weight = r["Weight"].ToString();
                    ChiefComplaint = r["Chiefcomplaint"].ToString();
                    Diagnosis = r["Diagnosis"].ToString();
                    MedicationTreatment = r["Medicationtreatment"].ToString();
                    LaboratoryFindings = r["LaboratoryFindings"].ToString();
                    DoctorID = Convert.ToInt32(r["DoctorID"]);


                }

                Controller.Service.ShowForm(new View.Patients.frmRecordAddEdit(true));
            }
        }
        public static void Delete(DataGridView d)  
        {
            Controller.MySQL.Push("delete from patientrecord where ID =" + ID + "");
            Load(d);
        }
        public static void Cmb(ComboBox c)
        {
            DataTable dt = Controller.MySQL.Pull("SELECT ID, Name FROM services");
            c.DataSource = dt;
            c.DisplayMember = "Name";
            c.ValueMember = "ID";

        }
        public static void Save()
        {
            Controller.MySQL.Push("insert into patientrecord set PatientID ='"+PatientID+"',NatureOfVisit ='" + VisitType + "',ServiceID='" + ServiceID + "',Bloodpressure='" + BloodPressure + "', Temperature='" + Temperature + "', Height='" + Height + "', Weight='" + Weight + "', Chiefcomplaint='" + ChiefComplaint + "', Diagnosis='" + Diagnosis + "', Medicationtreatment='" + MedicationTreatment + "', LaboratoryFindings='" + LaboratoryFindings + "', DoctorID='" + DoctorID + "',Created_At='" + Created_at.ToString("yyyy-MM-dd") + "'");

        }
        public static void Update()
        {

            Controller.MySQL.Push("UPDATE patientrecord SET " + "NatureOfVisit ='" + VisitType + "', " + "ServiceID='" + ServiceID + "', " + "Bloodpressure='" + BloodPressure + "', " + "Temperature='" + Temperature + "', " + "Height='" + Height + "'," + "Weight='" + Weight + "Chiefcomplaint='" + ChiefComplaint + "Diagnosis='" + Diagnosis + "Medicationtreatment='" + MedicationTreatment + "LaboratoryFindings='" + LaboratoryFindings + "DoctorID='" + DoctorID + "'" + "WHERE ID=" + ID);


        }
    }


}
