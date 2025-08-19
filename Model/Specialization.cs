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
    public class Specialization
    {
        public static int ID { get; set; }
        public static string Description { get; set; }

        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.Doctors.ucSpecialization(), p);
        }

        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("Select * FROM specialization") as IDisposable;
            d.DataSource = dt;
            dt.Dispose();

        }
        public static void FixGrid(DataGridView d)
        {
            d.Columns[0].Visible = false;
            d.Columns[1].HeaderText = "Specialization";

        }

        public static void Add()
        {
            Controller.Service.ShowForm(new View.Doctors.frmSpecializationAddEdit());

        }

        public static void Edit(DataGridView d)
        {
            if (d.CurrentRow != null)
            {
                ID = Convert.ToInt32(d.CurrentRow.Cells[2].Value);

                DataTable dt = Controller.MySQL.Pull("SELECT * FROM specialization WHERE ID = " + ID);
                if (dt.Rows.Count > 0)
                {
                    var r = dt.Rows[0];
                    Description = r["Description"].ToString();
                   

                }

                Controller.Service.ShowForm(new View.Doctors.frmSpecializationAddEdit(true));
            }

        }
        public static void Delete(DataGridView d)
        {
            Controller.MySQL.Push("delete from specialization where ID =" + ID + "");
            Load(d);
        }

        public static void Save()
        {
            Controller.MySQL.Push("insert into specialization set Description ='" + Description + "'");
        }
        public static void Update()
        {
            Controller.MySQL.Push("UPDATE specialization SET "  + "Description='" + Description + "'" + "WHERE ID=" + ID);
        }
        public static void Cmb(ComboBox c)
        {
            var dt = Controller.MySQL.Pull("SELECT ID, Description FROM specialization");
            c.DataSource = dt;
            c.DisplayMember = "Description";
            c.ValueMember = "ID";

        }
    }
}
