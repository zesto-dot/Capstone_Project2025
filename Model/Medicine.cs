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
    public class Medicine
    {
        public static int ID { get; set; }
        public static string Code { get; set; }
        public static string Description { get; set; }
        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.MasterFiles.Medicine.ucMedicine(), p);
        }
        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("Select * FROM medicine") as IDisposable;
            d.DataSource = dt;
            dt.Dispose();

        }
        public static void FixGrid(DataGridView d)
        {
            d.Columns[2].Visible = false;
            d.Columns[3].HeaderText = "Code";
            d.Columns[4].HeaderText = "Description";

        }
        public static void Add()
        {
            Controller.Service.ShowForm(new View.MasterFiles.Medicine.frmAddEdit());

        }
        public static void Edit(DataGridView d)
        {
            if (d.CurrentRow != null)
            {
                ID = Convert.ToInt32(d.CurrentRow.Cells[2].Value);

                DataTable dt = Controller.MySQL.Pull("SELECT * FROM medicine WHERE ID = " + ID);
                if (dt.Rows.Count > 0)
                {
                    var r = dt.Rows[0];
                    Code = r["Code"].ToString();
                    Description = r["Description"].ToString();

                }

                Controller.Service.ShowForm(new View.MasterFiles.Medicine.frmAddEdit(true));
            }

        }
        public static void Delete(DataGridView d)
        {
            Controller.MySQL.Push("delete from medicine where ID =" + ID + "");
            Load(d);
        }
        public static void Save()
        {
            Controller.MySQL.Push("insert into medicine set Code ='" + Code + "',Description='" + Description + "'");
        }

        public static void Update()
        {
            Controller.MySQL.Push("UPDATE medicine SET " + "Code='" + Code + "', " + "Description='" + Description + "'" + "WHERE ID=" + ID);
        }
    }
}
