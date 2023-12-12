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
    public partial class StudentForm_Home : Form
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string UserID { get; set; }
        public int Balance = 0;

        public bool isExitButtonClicked = true;
        private Color ClickBackColor = Color.Blue;
        private Color ClickForeColor = Color.White;
        private Color StandBackColor = Color.PeachPuff;
        private Color StandForeColor = Color.Black;
        public StudentForm_Home()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void GetBalance()
        {
            int balanceValue = 0;
            BalanceDAO balanceDAO = new BalanceDAO();
            List<Balance> balances = balanceDAO.GetBalances();

            Balance balance = balances.FirstOrDefault(b => b.UserID == UserID);
            if (balance != null)
            {
                balanceValue = (int)balance.CurrentBalance;
            }

            Balance = balanceValue;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            isExitButtonClicked = true;

            // Display a confirmation dialog before closing the application
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // If the user selects "Yes", exit the application
                Application.Exit();
            }
            else
            {
                // If the user selects "No" or closes the dialog, reset the flag
                isExitButtonClicked = false;
                //Login_btnExit.BackColor = StandBackColor;
                //Login_btnExit.ForeColor = StandForeColor;
            }
        }

        private void btn_registration_Enter(object sender, EventArgs e)
        {
            btn_registration.BackColor = ClickBackColor;
            btn_registration.ForeColor = ClickForeColor;
            panel_home.Controls.Clear();
            Student_registrationService f = new Student_registrationService();
            f.UserID = UserID;
            f.Username = Username;
            f.Role = Role;
            f.Balance = Balance;
            f.TopLevel = false;
            panel_home.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void btn_registration_Leave(object sender, EventArgs e)
        {
            btn_registration.ForeColor = StandForeColor;
            btn_registration.BackColor = StandBackColor;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentForm_Home_Load(object sender, EventArgs e)
        {
            GetBalance();
            txt_welcome.Text = $"Welcome {Username} - BC{UserID} - {Role} - Balance: {Balance}";
            if (Role == "Student")
            {
                btn_swithView.Visible = false;
            }
        }

        private void btn_swithView_Enter(object sender, EventArgs e)
        {
            Home_Form1 home_Form1 = new Home_Form1();
            home_Form1.Username = Username;
            home_Form1.Role = Role;
            home_Form1.UserID = UserID;
            home_Form1.Balance = Balance;
            this.Hide();
            home_Form1.Show();
        }

        private void btn_transactionHistory_Enter(object sender, EventArgs e)
        {
            btn_transactionHistory.BackColor = ClickBackColor;
            btn_transactionHistory.ForeColor = ClickForeColor;
            panel_home.Controls.Clear();
            ServiceRegistrationHistory f = new ServiceRegistrationHistory();
            f.UserID = UserID;
            f.Username = Username;
            f.Role = Role;
            f.Balance = Balance;
            f.TopLevel = false;
            panel_home.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void btn_transactionHistory_Leave(object sender, EventArgs e)
        {
            btn_transactionHistory.BackColor = StandBackColor;
            btn_transactionHistory.ForeColor = StandForeColor;
        }
    }
}
