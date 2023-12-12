using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FTU_StudentOnlineService
{
    public partial class MiniForm_StudentAccount : Form
    {
        internal DataValidation dv = new DataValidation();
        private Color ClickBackColor = Color.Blue;
        private Color ClickForeColor = Color.White;
        private Color StandBackColor = Color.PeachPuff;
        private Color StandForeColor = Color.Black;
        public string Status = "None";
        public MiniForm_StudentAccount() 
        {
            InitializeComponent();
        }

        private void MiniForm_StudentAccount_Load(object sender, EventArgs e)
        {
            StudentAccountForm_cbbSearch.SelectedItem = StudentAccountForm_cbbSearch.Items[0];
            StudentAccountForm_tableUsersList_CellClick(null, null);
            LoadColumnUsersList();
            LoadDataUsers();
            StudentAccountForm_btnEdit_Enter(null, null);
        }

        private void LoadColumnUsersList()
        {
            StudentAccountForm_tableUsersList.ColumnCount = 7;
            StudentAccountForm_tableUsersList.Columns[0].Name = "ID User";
            StudentAccountForm_tableUsersList.Columns[1].Name = "User Name";
            StudentAccountForm_tableUsersList.Columns[2].Name = "Password";
            StudentAccountForm_tableUsersList.Columns[3].Name = "Phone Number ";
            StudentAccountForm_tableUsersList.Columns[4].Name = "Gmail";
            StudentAccountForm_tableUsersList.Columns[5].Name = "Student Status";
            StudentAccountForm_tableUsersList.Columns[6].Name = "Major";
        }

        private void LoadDataUsers()
        {
            StudentAccountForm_tableUsersList.Rows.Clear();
            UsersDAO usersDAO = new UsersDAO();
            List<Users> users = usersDAO.getUsers().Where(u => u.roletypeID == "2" && u.studentStatus == "Active") .ToList();

            foreach (Users U in users)
            {
                string[] row = { U.userID.ToString(), U.name.ToString(), U.password.ToString(), U.phonenumber.ToString(), U.gmail.ToString(), U.studentStatus.ToString(), U.major.ToString() };
                StudentAccountForm_tableUsersList.Rows.Add(row);
            }
        }


        private void StudentAccountForm_tableUsersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentAccountForm_tableUsersList.ReadOnly = true;
            if (StudentAccountForm_tableUsersList.RowCount > 1)
                if (StudentAccountForm_tableUsersList.CurrentRow != null)
                {
                    int rowindex = StudentAccountForm_tableUsersList.CurrentCell.RowIndex;
                    if (StudentAccountForm_tableUsersList.Rows.Count - 2 >= rowindex)
                    {
                        string idUsers = StudentAccountForm_tableUsersList.Rows[rowindex].Cells[0].Value.ToString();
                        string name = StudentAccountForm_tableUsersList.Rows[rowindex].Cells[1].Value.ToString();
                        string password = StudentAccountForm_tableUsersList.Rows[rowindex].Cells[2].Value.ToString();
                        string numberphone = StudentAccountForm_tableUsersList.Rows[rowindex].Cells[3].Value.ToString();
                        string gmail = StudentAccountForm_tableUsersList.Rows[rowindex].Cells[4].Value.ToString();
                        string studentstatus = StudentAccountForm_tableUsersList.Rows[rowindex].Cells[5].Value.ToString();
                        string Major = StudentAccountForm_tableUsersList.Rows[rowindex].Cells[6].Value.ToString();

                        StudentAccountForm_tbUserID.Text = idUsers;
                        StudentAccountForm_tbName.Text = name;
                        StudentAccountForm_tbPassword.Text = password;
                        StudentAccountForm_tbPhoneNumber.Text = numberphone;
                        StudentAccountForm_tbGamil.Text = gmail;
                        StudentAccountForm_cbbStudentStatus.Text = studentstatus;
                        StudentAccountForm_cbbMajor.Text = Major;
                        BalanceDAO balanceDAO = new BalanceDAO();
                        List<Balance> balance = balanceDAO.GetBalances();
                        Balance foundBalance = balance.FirstOrDefault(b => b.UserID == idUsers);
                        tb_balance.Text = Convert.ToString(foundBalance.CurrentBalance);
                    }
                }
        }

        private string GenerateUniqueKey(List<Users> users)
        {
            int maxId = 0;

            foreach (Users u in users)
            {
                string usersID = u.userID;
                int idNumber = 0;
                idNumber = int.Parse(usersID);
                if (idNumber > maxId)
                {
                    maxId = idNumber;
                }
            }

            string newId = ""+(maxId + 1);

            return newId;
        }

        private bool IsAllFieldsFilled()
        {
            bool isUpdate = (Status == "Update");

            return !string.IsNullOrEmpty(StudentAccountForm_tbName.Text)
                && !string.IsNullOrEmpty(StudentAccountForm_tbPassword.Text)
                && !string.IsNullOrEmpty(StudentAccountForm_tbPhoneNumber.Text)
                && dv.IsPhoneNumberValid(StudentAccountForm_tbPhoneNumber.Text)
                && !string.IsNullOrEmpty(StudentAccountForm_tbGamil.Text)
                && dv.IsEmailTrueFrom(StudentAccountForm_tbGamil.Text, isUpdate ? "2" : "1")
                && !string.IsNullOrEmpty(StudentAccountForm_cbbStudentStatus.Text)
                && !string.IsNullOrEmpty(StudentAccountForm_cbbMajor.Text);
        }

    private void ClearFields()
        {
            StudentAccountForm_tbName.Text = null;
            StudentAccountForm_tbPassword.Text = null;
            StudentAccountForm_tbPhoneNumber.Text = null;
            StudentAccountForm_tbGamil.Text = null;
            StudentAccountForm_cbbStudentStatus.Text = null;
            StudentAccountForm_cbbMajor.Text = null;
        }

        private void StudentAccountForm_btnSave_Click(object sender, EventArgs e)
        {
            if (Status == "Add")
            {
                if (IsAllFieldsFilled())
                {
                    DialogResult result = MessageBox.Show("Are you sure to save this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            UsersDAO usersDAO = new UsersDAO();
                            List<Users> users = usersDAO.getUsers();
                            string newId = GenerateUniqueKey(users);

                            string hashedPassword = EncryptionHelper.HashPassword(StudentAccountForm_tbPassword.Text.ToString());

                            Users u = new Users(newId, "2", StudentAccountForm_tbName.Text.ToString(), hashedPassword, StudentAccountForm_tbPhoneNumber.Text.ToString(), StudentAccountForm_tbGamil.Text.ToString(), StudentAccountForm_cbbStudentStatus.Text.ToString(), StudentAccountForm_cbbMajor.Text.ToString());
                            usersDAO.addUsers(u);

                            StudentAccountForm_tbUserID.Text = newId;

                            BalanceDAO balanceDAO = new BalanceDAO();
                            balanceDAO.AddBalance(newId, newId, 100);

                            MessageBox.Show("Add Complete Refresh To See In Table!!! UserID" + newId);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadDataUsers();
            }

            if (Status == "Update")
            {
                if (IsAllFieldsFilled())
                {
                    // Display confirmation dialog
                    DialogResult result = MessageBox.Show("Are you sure to save this Users?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Check if the user clicked Yes
                    if (result == DialogResult.Yes)
                    {
                        // Call the function to save data
                        UsersDAO usersDAO = new UsersDAO();
                        try
                        {
                            Users users = new Users(StudentAccountForm_tbUserID.Text.ToString(),"2", StudentAccountForm_tbName.Text, StudentAccountForm_tbPassword.Text, StudentAccountForm_tbPhoneNumber.Text.ToString(), StudentAccountForm_tbGamil.Text.ToString(), StudentAccountForm_cbbStudentStatus.Text.ToString(), StudentAccountForm_cbbMajor.Text.ToString());
                            usersDAO.UpdateUsers(users);
                            MessageBox.Show("Update Complete.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void StudentAccountForm_btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataUsers();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (StudentAccountForm_cbbSearch.Text =="Search by Username")
            {
                StudentAccountForm_tableUsersList.Rows.Clear();
                UsersDAO usersDAO = new UsersDAO();
                List<Users> users = usersDAO.SearchUsersByEmail(StudentAccountForm_tbSearch.Text);
                foreach (Users U in users)
                {
                    string[] row = { U.userID.ToString(), U.roletypeID.ToString(), U.name.ToString(), U.password.ToString(), U.phonenumber.ToString(), U.gmail.ToString(), U.studentStatus.ToString(), U.major.ToString() };
                    StudentAccountForm_tableUsersList.Rows.Add(row);
                }
            }
        }

        private void StudentAccountForm_btnEdit_Enter(object sender, EventArgs e)
        {
            Status = "Update";
            StudentAccountForm_txtStatus.Text = "Status: " + Status;
            StudentAccountForm_btnEdit.BackColor = ClickBackColor;
            StudentAccountForm_btnEdit.ForeColor = ClickForeColor;
            StudentAccountForm_btnAdd.BackColor = StandBackColor;
            StudentAccountForm_btnAdd.ForeColor = StandForeColor;
            StudentAccountForm_tableUsersList_CellClick(null, null);
        }

        private void StudentAccountForm_btnAdd_Enter(object sender, EventArgs e)
        {
            StudentAccountForm_btnAdd.BackColor = ClickBackColor;
            StudentAccountForm_btnAdd.ForeColor = ClickForeColor;
            StudentAccountForm_btnEdit.BackColor = StandBackColor;
            StudentAccountForm_btnEdit.ForeColor = StandForeColor;
            tb_balance.Text = "100";
            Status = "Add";
            StudentAccountForm_txtStatus.Text = "Status: " + Status;
            StudentAccountForm_tbUserID.Text = "Auto";
        }

        private void StudentAccountForm_btnAccountDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Balance is: ");
        }

        private void StudentAccountForm_cbbStudentStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Status == "Add")
            {
                StudentAccountForm_cbbStudentStatus.Text = "Active";
            }
        }

        private void tb_balance_TextChanged(object sender, EventArgs e)
        {
            if (Status == "Add")
            {
                tb_balance.Text = "100";
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            ClearFields();
            StudentAccountForm_tbName.Focus();
            if (Status == "Add")
            {
                StudentAccountForm_tbUserID.Text = "Auto";
            }
        }

        private void StudentAccountForm_tbUserID_TextChanged(object sender, EventArgs e)
        {
            if (Status == "Add")
            {
                StudentAccountForm_tbUserID.Text = "Auto";
            }
        }
    }
}
