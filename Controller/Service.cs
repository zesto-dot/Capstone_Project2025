using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.Controller
{
    public class Service
    {
        public static void ShowUC(UserControl x, Panel y)
        {
            y.Controls.Clear();
            _ = new UserControl();
            UserControl UC = x;
            UC.Dock = DockStyle.Fill;
            y.Controls.Add(UC);
            UC.Focus();
        }
        public static void ShowForm(Form x)
        {
            _ = new Form();
            Form frm = x;
            x.ShowDialog();
        }

        public static string EscapeQuote(string msdata)
        {
            return msdata.Replace("'", "''");
        }

    }
}
