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
    public class Settings
    {
        public static void UI(Panel p)
        {
            Controller.Service.ShowUC(new View.Settings.ucSettings(), p);

        }
    }
}
