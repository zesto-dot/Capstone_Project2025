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
        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.Doctors.ucDoctors(), p);
        }
        public static void FixGrid(DataGridView d)
        {
            d.Columns[0].Visible = false;
            d.Columns[1].HeaderText = "Full Name";
            d.Columns[2].HeaderText = "Sex";
            d.Columns[3].HeaderText = "Address";
            d.Columns[4].HeaderText = "Contact Number";
            d.Columns[5].HeaderText = "Specialization";
            d.Columns[6].HeaderText = "Created_At";

        }
        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("SELECT * FROM `v.doctors`") as IDisposable;
            d.DataSource = dt;
            dt.Dispose();
            FixGrid(d);
        }
    }

}
