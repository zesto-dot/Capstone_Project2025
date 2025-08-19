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
    public class Laboratory
    {
        public static int ID { get; set; }
        public static string test_name { get; set; }
        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.MasterFiles.Laboratory.ucLaboratory(), p);
        }
        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("Select * FROM laboratorytest") as IDisposable;
            d.DataSource = dt;
            dt.Dispose();

        }
        public static void FixGrid(DataGridView d)
        {
            d.Columns[2].Visible = false;
            d.Columns[3].HeaderText = "Test Name";


        }
        public static void Add()
        {
            Controller.Service.ShowForm(new View.MasterFiles.Laboratory.frmAddEdit());

        }
        public static void Edit(DataGridView d)
        {
            if (d.CurrentRow != null)
            {
                ID = Convert.ToInt32(d.CurrentRow.Cells[2].Value);

                DataTable dt = Controller.MySQL.Pull("SELECT * FROM laboratorytest WHERE ID = " + ID);
                if (dt.Rows.Count > 0)
                {
                    var r = dt.Rows[0];
                    test_name = r["test_name"].ToString();
                   

                }

                Controller.Service.ShowForm(new View.MasterFiles.Laboratory.frmAddEdit(true));
            }

        }
        public static void Delete(DataGridView d)
        {
            Controller.MySQL.Push("delete from laboratorytest where ID =" + ID + "");
            Load(d);
        }
        public static void Save()
        {
            Controller.MySQL.Push("insert into laboratorytest set test_name ='" + test_name + "'");
        }

        public static void Update()
        {
            Controller.MySQL.Push("UPDATE laboratorytest SET " + "test_name='" + test_name + "'" + "WHERE ID=" + ID);
        }
    }
}
