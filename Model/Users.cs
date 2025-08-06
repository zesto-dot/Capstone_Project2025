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

    public class Users
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Login()
        {

            DataTable dt = Controller.MySQL.Pull($"SELECT * FROM user WHERE username = '{Username}' AND password = '{Password}'");

            return dt.Rows.Count > 0;
        }

    }
}
