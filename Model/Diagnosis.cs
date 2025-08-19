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
    public class Diagnosis
    {
        public static void Load(DataGridView d)
        {
            var dt = Controller.MySQL.Pull("Select * FROM diagnosis") as IDisposable;
            d.DataSource = dt;
            dt.Dispose();

        }
        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.MasterFiles.Diagnosis.ucDiagnosis(), p);
        }
    }
}
