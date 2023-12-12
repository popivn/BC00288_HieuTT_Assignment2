using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FTU_StudentOnlineService
{
    public partial class Login_Form0 : Form
    {
        public string WannaRole = null;
        private Timer colorChangeTimer;
        private String Wandering = "Please log in using your Gmail as a username";

        private Color ClickBackColor = Color.Blue;
        private Color ClickForeColor = Color.White;
        private Color StandBackColor = Color.Orange;
        private Color StandForeColor = Color.Black;

        private bool Unmask = true;

        private const string FileName = "UserInfo.txt";

        public Login_Form0()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Login_textExit_Click(object sender, EventArgs e)
        {
            Login_btnExit.ForeColor = ClickForeColor;
            Login_btnExit.BackColor = ClickBackColor;

            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Login_btnExit.BackColor = StandBackColor;
                Login_btnExit.ForeColor = StandForeColor;
            }
        }

        private void ColorChangeTimer_Tick(object sender, EventArgs e)
        {
            colorChangeTimer.Stop();

            Login_btnCantSignin.BackColor = StandBackColor;
            Login_btnCantSignin.ForeColor = StandForeColor;
        }

        private void Login_btnCantSignin_Click(object sender, EventArgs e)
        {
            Login_btnCantSignin.BackColor = ClickBackColor;
            Login_btnCantSignin.ForeColor = ClickForeColor;

            colorChangeTimer = new Timer();
            colorChangeTimer.Interval = 1000;
            colorChangeTimer.Tick += ColorChangeTimer_Tick;
            colorChangeTimer.Start();
        }

        private void Login_btnLogin_Click(object sender, EventArgs e)
        {
            UsersDAO usersDAO = new UsersDAO();
            RoleTypeDAO roleDAO = new RoleTypeDAO();
            List<Users> users = usersDAO.getUsers();
            List<RoleType> roles = roleDAO.GetRoles();

            string enteredUsername = Login_tbUsername.Text;
            string enteredPassword = Login_tbPassword.Text;

            Users foundUser = users.FirstOrDefault(user => user.gmail == enteredUsername);

            if (foundUser != null && EncryptionHelper.HashPassword(enteredPassword) == foundUser.password)
            {
                Login_cbRememberme_CheckedChanged(null, null);
                RoleType foundRole = roles.FirstOrDefault(role => role.RoleTypeIDProp == foundUser.roletypeID);

                if (foundRole.RoleNameProp == "Admin")
                {
                    Home_Form1 home_Form1 = new Home_Form1();
                    home_Form1.Username = foundUser.name;
                    home_Form1.Role = foundRole.RoleNameProp;
                    home_Form1.UserID = foundUser.userID;
                    this.Hide();
                    home_Form1.Show();
                }
                if (foundRole.RoleNameProp == "Student")
                {
                    StudentForm_Home student = new StudentForm_Home();
                    student.Username = foundUser.name;
                    student.Role = foundRole.RoleNameProp;
                    student.UserID = foundUser.userID;
                    this.Hide();
                    student.Show();
                }
                else if (foundRole.RoleNameProp == "Student" && WannaRole == "Admin")
                {
                    MessageBox.Show("You Are Not Administrator");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Wandering);
        }

        private void Login_pbUnmaskpasswork_Click(object sender, EventArgs e)
        {
            if (Unmask == true)
            {
                Login_tbPassword.UseSystemPasswordChar = false;
                Unmask = false;
            }
            else
            {
                Login_tbPassword.UseSystemPasswordChar = true;
                Unmask = true;
            }
        }

        private void Login_Form0_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
        }

        private void Login_cbRememberme_CheckedChanged(object sender, EventArgs e)
        {
            if (Login_cbRememberme.Checked)
            {
                SaveUserInfo(Login_tbUsername.Text, Login_tbPassword.Text);
            }
        }

        private void SaveUserInfo(string username, string password)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FileName))
                {
                    writer.WriteLine(username);
                    writer.WriteLine(password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user info: {ex.Message}");
            }
        }

        private void LoadUserInfo()
        {
            try
            {
                if (File.Exists(FileName))
                {
                    string[] lines = File.ReadAllLines(FileName);
                    if (lines.Length >= 2)
                    {
                        Login_tbUsername.Text = lines[0];
                        Login_tbPassword.Text = lines[1];
                        Login_cbRememberme.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user info: {ex.Message}");
            }
        }
    }
}
