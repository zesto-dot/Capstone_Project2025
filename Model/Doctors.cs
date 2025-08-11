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
        public static string SpecializationID { get; set; }
        public static DateTime Created_At { get; set; }

        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.Doctors.ucDoctors(), p);
        }
        public static void FixGrid(DataGridView d)
        {
            d.Columns[0].Visible = false;
            d.Columns[1].HeaderText = "Full Name";
            d.Columns[2].HeaderText = "Sex";
            d.Columns[3].HeaderText = "Contact Number";
            d.Columns[4].HeaderText = "Specialization";
            d.Columns[5].HeaderText = "Created_At";

        }
        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("SELECT * FROM `v.doctors`") as IDisposable;
            d.DataSource = dt;
            dt.Dispose();
            FixGrid(d);
        }
        public static void Add()
        {
            Controller.Service.ShowForm(new View.Doctors.frmAddEdit());

        }
        public static void Edit()
        {
            Controller.Service.ShowForm(new View.Doctors.frmAddEdit());

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
       
    }

}
