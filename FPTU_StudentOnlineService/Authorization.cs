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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void LoadColumnRoleListAdmin()
        {
            table_adminList.ColumnCount = 3;
            table_adminList.Columns[0].Name = "User ID";
            table_adminList.Columns[1].Name = "Name";
            table_adminList.Columns[2].Name = "Permission";
        }

        private void LoadDataRoleListAdmin()
        {
            table_adminList.Rows.Clear();
            UsersDAO uDAO = new UsersDAO();
            RoleTypeDAO roleTypeDAO = new RoleTypeDAO();
            List<RoleType> roleType = roleTypeDAO.GetRoles();
            List<Users> u = uDAO.getUsers().Where(us => us.roletypeID == "1" && us.studentStatus == "Active").ToList();

            foreach (Users us in u)
            {
                string[] row = { us.userID.ToString(), us.name.ToString(), us.roletypeID.ToString() };
                table_adminList.Rows.Add(row);
            }
            if (cbb_permission.Items.Count == 0)
            {
                foreach (RoleType item in roleType)
                {
                    cbb_permission.Items.Add($"{item.RoleTypeIDProp} - {item.RoleNameProp}");
                }
            }
        }

        private void LoadColumnRoleListStudent()
        {
            table_studentList.ColumnCount = 3;
            table_studentList.Columns[0].Name = "User ID";
            table_studentList.Columns[1].Name = "Name";
            table_studentList.Columns[2].Name = "Permission";
        }

        private void LoadDataRoleListStudent()
        {
            table_studentList.Rows.Clear();
            UsersDAO uDAO = new UsersDAO();
            RoleTypeDAO roleTypeDAO = new RoleTypeDAO();
            List<RoleType> roleType = roleTypeDAO.GetRoles();
            List<Users> u = uDAO.getUsers().Where(us => us.roletypeID == "2" && us.studentStatus == "Active").ToList();

            foreach (Users us in u)
            {
                string[] row = { us.userID.ToString(), us.name.ToString(), us.roletypeID.ToString() };
                table_studentList.Rows.Add(row);
            }
            if (cbb_permission.Items.Count == 0)
            {
                foreach (RoleType item in roleType)
                {
                    cbb_permission.Items.Add($"{item.RoleTypeIDProp} - {item.RoleNameProp}");
                }
            }
        }

        private void table_adminList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            table_adminList.ReadOnly = true;
            if (table_adminList.RowCount > 1)
                if (table_adminList.CurrentRow != null)
                {
                    int rowindex = table_adminList.CurrentCell.RowIndex;
                    if (table_adminList.Rows.Count - 2 >= rowindex)
                    {
                        string idUsers = table_adminList.Rows[rowindex].Cells[0].Value.ToString();
                        string name = table_adminList.Rows[rowindex].Cells[1].Value.ToString();
                        string permission = table_adminList.Rows[rowindex].Cells[2].Value.ToString();

                        tb_userID.Text = idUsers;
                        tb_name.Text = name;
                        RoleTypeDAO roleTypeDAO = new RoleTypeDAO();
                        List<RoleType> roleType = roleTypeDAO.GetRoles();
                        RoleType foundRolename = roleType.FirstOrDefault(r => r.RoleTypeIDProp == permission);
                        cbb_permission.Text = $"{permission} - {foundRolename.RoleNameProp}";
                    }
                }
        }

        private void table_studentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            table_studentList.ReadOnly = true;
            if (table_studentList.RowCount > 1)
                if (table_studentList.CurrentRow != null)
                {
                    int rowindex = table_studentList.CurrentCell.RowIndex;
                    if (table_studentList.Rows.Count - 2 >= rowindex)
                    {
                        string idUsers = table_studentList.Rows[rowindex].Cells[0].Value.ToString();
                        string name = table_studentList.Rows[rowindex].Cells[1].Value.ToString();
                        string permission = table_studentList.Rows[rowindex].Cells[2].Value.ToString();

                        tb_userID.Text = idUsers;
                        tb_name.Text = name;
                        RoleTypeDAO roleTypeDAO = new RoleTypeDAO();
                        List<RoleType> roleType = roleTypeDAO.GetRoles();
                        RoleType foundRolename = roleType.FirstOrDefault(r => r.RoleTypeIDProp == permission);
                        cbb_permission.Text = $"{permission} - {foundRolename.RoleNameProp}";
                    }
                }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to UPDATE this Service?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RoleTypeDAO roleTypeDAO = new RoleTypeDAO();
                string newrole = cbb_permission.Text.Split('-')[0];
                roleTypeDAO.UpdateUserRoleType(tb_userID.Text, newrole);
                Authorization_Load(null, null);
            }
            else if (result == DialogResult.No)
            {
                tb_userID.Text = string.Empty;
                tb_name.Text = string.Empty;
                cbb_permission.SelectedIndex = -1; // or set it to the default value
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            LoadColumnRoleListAdmin();
            LoadDataRoleListAdmin();
            LoadColumnRoleListStudent();
            LoadDataRoleListStudent();
        }

        private void tb_userID_TextChanged(object sender, EventArgs e)
        {
            if (tb_userID.Text == string.Empty)
            {
                cbb_permission.Enabled = false;
            }
            else
            {
                cbb_permission.Enabled = true;
            }
        }
    }
}
