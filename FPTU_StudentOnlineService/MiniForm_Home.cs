using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTU_StudentOnlineService
{
    public partial class MiniForm_Home : Form
    {
        public static string role;
        public static string name;
        public MiniForm_Home()
        {
            InitializeComponent();
            UsersDAO usersDAO = new UsersDAO();
            usersDAO.getUsers();
        }

        public MiniForm_Home(string Role, string Name)
        {
            role = Role;
            name = Name;
        }

        private void MiniForm_Home_Load(object sender, EventArgs e)
        {
            Home_textContent.Text = $"Welcome {role} {name}";
        }
    }
}
