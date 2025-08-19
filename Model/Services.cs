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
    public class Services
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static string Description { get; set; }
        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.Services.ucServices(), p);
        }

        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("Select * FROM services") as IDisposable;
            d.DataSource = dt;
            dt.Dispose();

        }
        public static void FixGrid(DataGridView d)
        {
            d.Columns[2].Visible = false;
            d.Columns[3].HeaderText = "Name";
            d.Columns[4].HeaderText = "Description";
           

        }
        public static void Add()
        {
            Controller.Service.ShowForm(new View.Services.frmAddEdit());

        }
        public static void Edit(DataGridView d)
        {
            if (d.CurrentRow != null)
            {
                ID = Convert.ToInt32(d.CurrentRow.Cells[2].Value);

                DataTable dt = Controller.MySQL.Pull("SELECT * FROM services WHERE ID = " + ID);
                if (dt.Rows.Count > 0)
                {
                    var r = dt.Rows[0];
                    Name = r["Name"].ToString();
                    Description = r["Description"].ToString();

                }

                Controller.Service.ShowForm(new View.Services.frmAddEdit(true));
            }
            
        }
        public static void Delete(DataGridView d)
        {
            Controller.MySQL.Push("delete from services where ID =" + ID + "");
            Load(d);
        }
        public static void Save()
        {
            Controller.MySQL.Push("insert into services set Name ='" + Name + "',Description='" + Description + "'");
        }

        public static void Update()
        {
            Controller.MySQL.Push("UPDATE services SET " + "Name='" + Name + "', " + "Description='" + Description +"'"+"WHERE ID=" + ID);
        }
    }
}
