using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capstone_project.Controller
{
    class Users
    {
        public static void LoginUser(string username, string password, Form currentForm)
        {
            Model.Users user = new Model.Users
            {
                Username = username,
                Password = password
            };
            if (user.Login())
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                View.frmMain mainForm = new View.frmMain();
                mainForm.Show();
                currentForm.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
