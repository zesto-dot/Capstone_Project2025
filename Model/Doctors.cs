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
    public class Doctors
    {
        public static int ID { get; set; }
        public static string Lname { get; set; }
        public static string Fname { get; set; }
        public static string Mname { get; set; }
        public static string Sex { get; set; }
        public static string ContactNumber { get; set; }
        public static int SpecializationID { get; set; }
        public static DateTime Created_At { get; set; }

        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.Doctors.ucDoctors(), p);
        }
        
        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("SELECT `doctors`.`ID` AS `ID`, CONCAT(UPPER(LEFT(`doctors`.`Fname`, 1)), LOWER(SUBSTR(`doctors`.`Fname`, 2)), ' ', UPPER(LEFT(`doctors`.`Mname`, 1)), '. ', UPPER(LEFT(`doctors`.`Lname`, 1)), LOWER(SUBSTR(`doctors`.`Lname`, 2)), ' ') AS `FullName`, `doctors`.`Sex` AS `Sex`, `doctors`.`ContactNumber` AS `ContactNumber`, `specialization`.`Description` AS `Specialization`, `doctors`.`Created_At` AS `Created_At` FROM (`doctors` JOIN `specialization` ON ((`doctors`.`SpecializationID` = `specialization`.`ID`)))") as IDisposable;
            d.DataSource = dt;
            dt.Dispose();
            
        }

        public static void FixGrid(DataGridView d)
        {
            d.Columns[2].Visible = false;
            d.Columns[3].HeaderText = "Full Name";
            d.Columns[4].HeaderText = "Sex";
            d.Columns[5].HeaderText = "Contact Number";
            d.Columns[6].HeaderText = "Specialization";
            d.Columns[7].HeaderText = "Created_At";

        }
        public static void Add()
        {
            Controller.Service.ShowForm(new View.Doctors.frmAddEdit());

        }
       public static void Edit(DataGridView d)
        {
            if (d.CurrentRow != null)
            {
                ID = Convert.ToInt32(d.CurrentRow.Cells[2].Value);

                DataTable dt = Controller.MySQL.Pull("SELECT * FROM doctors WHERE ID = " + ID);
                if (dt.Rows.Count > 0)
                {
                    var r = dt.Rows[0];
                    Lname = r["Lname"].ToString();
                    Fname = r["Fname"].ToString();
                    Mname = r["Mname"].ToString();
                    Sex = r["Sex"].ToString();
                    ContactNumber = r["ContactNumber"].ToString();
                    SpecializationID = Convert.ToInt32(r["SpecializationID"]);

                }

                Controller.Service.ShowForm(new View.Doctors.frmAddEdit(true));
            }
        }


        public static void Delete(DataGridView d)
        {
            Controller.MySQL.Push("delete from doctors where ID =" + ID + "");
            Load(d);
        }
        public static void Save()
        {

            Controller.MySQL.Push("insert into doctors set Lname ='" + Lname + "',Fname='" + Fname + "',Mname='" + Mname + "', Sex='" + Sex + "', ContactNumber='" + ContactNumber + "',SpecializationID='" + SpecializationID + "',Created_At='" + Created_At.ToString("yyyy-MM-dd") + "'");
        }
        public static void Update()
        {

            Controller.MySQL.Push("UPDATE doctors SET " + "Lname='" + Lname + "', " + "Fname='" + Fname + "', " + "Mname='" + Mname + "', " + "Sex='" + Sex + "', " + "ContactNumber='" +ContactNumber +"',"+"SpecializationID='"+SpecializationID+"'"+ "WHERE ID=" + ID);


        }
        public static void Cmb(ComboBox c)
        {
            var dt = Controller.MySQL.Pull("SELECT ID, CONCAT(FullName, '/', Specialization) AS FullName FROM `v.doctors`");
            c.DataSource = dt;
            c.DisplayMember = "FullName";
            c.ValueMember = "ID";

        }

    }

}
