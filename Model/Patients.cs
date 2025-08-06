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

    public class Patients
    {
        public static int ID { get; set; }
        public static string Lname { get; set; }
        public static string Fname { get; set; }
        public static string Mname { get; set; }
        public static string Suffix { get; set; }
        public static string Sex { get; set; }
        public static DateTime Birthdate { get; set; }
        public static string Birthplace { get; set; }
        public static string Bloodtype { get; set; }
        public static string Address { get; set; }
        public static string ContactNumber { get; set; }
        public static string CivilStatus { get; set; }
        public static string SpouseName { get; set; }
        public static string MotherName { get; set; }
        public static string EducationalAttainment { get; set; }
        public static string EmploymentStatus { get; set; }
        public static string FamilyPosition { get; set; }
        public static bool Dswd_Nhts { get; set; }
        public static string FacilityHouseHoldNo { get; set; }
        public static bool FourPsMember { get; set; }
        public static string HouseHoldno { get; set; }
        public static bool PhilHealthMember { get; set; }
        public static string PhilHealthType { get; set; }
        public static string PhilHealthNo { get; set; }
        public static string IfMember { get; set; }
        public static bool PcbMember { get; set; }
        public static DateTime Created_At { get; set; }
        public static void Clear()
        {

        }
        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.ucPatient(), p);
        }
        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("SELECT * FROM `v.patients`") as IDisposable;
            d.DataSource = dt;
            dt.Dispose();
            FixGrid(d);
        }
        public static void FixGrid(DataGridView d)
        {
            d.Columns[0].Visible = false;
            d.Columns[1].HeaderText = "Full Name";
            d.Columns[2].HeaderText = "Sex";
            d.Columns[3].HeaderText = "Birth Date";
            d.Columns[4].HeaderText = "Blood Type";
            d.Columns[5].HeaderText = "Address";
            d.Columns[6].HeaderText = "Contact Number";
            d.Columns[7].HeaderText = "Created_At";
            
        }
        public static void Add()
        {
            Controller.Service.ShowForm(new View.frmAddEdit());
            
        }
        public static void Edit(DataGridView d)
        {
            if (d.CurrentRow != null)
            {
                ID = Convert.ToInt32(d.CurrentRow.Cells[0].Value);

                DataTable dt = Controller.MySQL.Pull("SELECT * FROM patients WHERE ID = " + ID);
                if (dt.Rows.Count > 0)
                {
                    var r = dt.Rows[0];
                    Lname = r["Lname"].ToString();
                    Fname = r["Fname"].ToString();
                    Mname = r["Mname"].ToString();
                    Suffix = r["Suffix"].ToString();
                    Sex = r["Sex"].ToString();
                    Birthdate = Convert.ToDateTime(r["Birthdate"]);
                    Birthplace = r["Birthplace"].ToString();
                    Bloodtype = r["Bloodtype"].ToString();
                    Address = r["Address"].ToString();
                    ContactNumber = r["ContactNumber"].ToString();
                    CivilStatus = r["CivilStatus"].ToString();
                    SpouseName = r["SpouseName"].ToString();
                    MotherName = r["MotherName"].ToString();
                    EducationalAttainment = r["EducationalAttainment"].ToString();
                    EmploymentStatus = r["EmploymentStatus"].ToString();
                    FamilyPosition = r["FamilyPosition"].ToString();
                    Dswd_Nhts = Convert.ToBoolean(r["Dswd_Nhts"]);
                    FacilityHouseHoldNo = r["FacilityHouseHoldNo"].ToString();
                    FourPsMember = Convert.ToBoolean(r["FourPsMember"]);
                    HouseHoldno = r["HouseHoldNo"].ToString();
                    PhilHealthMember = Convert.ToBoolean(r["PhilHealthMember"]);
                    PhilHealthType = r["PhilHealthType"].ToString();
                    PhilHealthNo = r["PhilHealthNo"].ToString();
                    IfMember = r["IfMember"].ToString();
                    PcbMember = Convert.ToBoolean(r["PcbMember"]);
                    
                }

                Controller.Service.ShowForm(new View.frmAddEdit(true));
            }
        }
        public static void Delete(DataGridView d)
        {
            Controller.MySQL.Push("delete from patients where ID =" + ID + "");
            Load(d);
        }

        public static void Save()
        {
            
                Controller.MySQL.Push("insert into patients set Lname ='" + Lname + "',Fname='" + Fname + "',Mname='" + Mname + "', Suffix='" + Suffix + "', Sex='" + Sex + "', Birthdate='" + Birthdate.ToString("yyyy-MM-dd") + "', Birthplace='" + Birthplace + "', Bloodtype='" + Bloodtype + "', Address='" + Address + "', ContactNumber='" + ContactNumber + "', CivilStatus='" + CivilStatus + "', SpouseName='" + SpouseName + "', MotherName='" + MotherName + "', EducationalAttainment='" + EducationalAttainment + "', EmploymentStatus='" + EmploymentStatus + "', FamilyPosition='" + FamilyPosition + "', Dswd_Nhts='" + (Dswd_Nhts ? 1 : 0) + "', FacilityHouseHoldNo='" + FacilityHouseHoldNo + "', FourPsMember='" + (FourPsMember ? 1 : 0) + "', HouseHoldNo='" + HouseHoldno + "', PhilHealthMember='" + (PhilHealthMember ? 1 : 0) + "', PhilHealthType='" + PhilHealthType + "', PhilHealthNo='" + PhilHealthNo + "', IfMember='" + IfMember + "', PcbMember='" + (PcbMember ? 1 : 0) + "',Created_At='" + Created_At.ToString("yyyy-MM-dd") + "'");
          
            
        }
        public static void Update()
        {
            Controller.MySQL.Push("UPDATE patients SET " + "Lname='" + Lname + "', " + "Fname='" + Fname + "', " + "Mname='" + Mname + "', " + "Suffix='" + Suffix + "', " + "Sex='" + Sex + "', " + "Birthdate='" + Birthdate.ToString("yyyy-MM-dd") + "', " + "Birthplace='" + Birthplace + "', " + "Bloodtype='" + Bloodtype + "', " + "Address='" + Address + "', " + "ContactNumber='" + ContactNumber + "', " + "CivilStatus='" + CivilStatus + "', " + "SpouseName='" + SpouseName + "', " + "MotherName='" + MotherName + "', " + "EducationalAttainment='" + EducationalAttainment + "', " + "EmploymentStatus='" + EmploymentStatus + "', " + "FamilyPosition='" + FamilyPosition + "', " + "Dswd_Nhts=" + (Dswd_Nhts ? 1 : 0) + ", " + "FacilityHouseHoldNo='" + FacilityHouseHoldNo + "', " + "FourPsMember=" + (FourPsMember ? 1 : 0) + ", " + "HouseHoldNo='" + HouseHoldno + "', " + "PhilHealthMember=" + (PhilHealthMember ? 1 : 0) + ", " + "PhilHealthType='" + PhilHealthType + "', " + "PhilHealthNo='" + PhilHealthNo + "', " + "IfMember='" + IfMember + "', " + "PcbMember=" + (PcbMember ? 1 : 0) + " " + "WHERE ID=" + ID);
        }
    }
}
