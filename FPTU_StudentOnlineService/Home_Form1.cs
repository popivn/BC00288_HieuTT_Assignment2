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
    public partial class Home_Form1 : Form
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string UserID { get; set; }
        public int Balance = 0;

        public event EventHandler BtnDepartmentEnterClicked;
        protected virtual void OnBtnDepartmentEnterClicked(EventArgs e)
        {
            BtnDepartmentEnterClicked?.Invoke(this, e);
        }
        public void TriggerBtnDepartmentEnterClicked()
        {
            OnBtnDepartmentEnterClicked(EventArgs.Empty);
        }
        private Color ClickBackColor = Color.Blue;
        private Color ClickForeColor = Color.White;
        private Color StandBackColor = Color.Orange;
        private Color StandForeColor = Color.Black;

        public Home_Form1()
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

        private void Home_Form1_Load(object sender, EventArgs e)
        {
            GetBalance();
            txt_welcome.Text = $"Welcome {Username} - BC{UserID} - {Role} - Balance: {Balance}";
        }
     

        private void HomeForm_btnHome_Enter(object sender, EventArgs e)
        {
            HomeForm_btnHome.BackColor = ClickBackColor;
            HomeForm_btnHome.ForeColor = ClickForeColor;
            Panel_Home.Controls.Clear();
            Panel_Home.BackColor = Color.AliceBlue;
            MiniForm_Home f = new MiniForm_Home();
            f.TopLevel = false;
            Panel_Home.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void HomeForm_btnExit_Click(object sender, EventArgs e)
        {
            HomeForm_btnExit.ForeColor = ClickForeColor;
            HomeForm_btnExit.BackColor = ClickBackColor;
            // Set a flag to confirm that the user clicked the "Exit" button

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
                HomeForm_btnExit.BackColor = StandBackColor;
                HomeForm_btnExit.ForeColor = StandForeColor;
            }
        }

        private void HomeForm_btnHome_Leave(object sender, EventArgs e)
        {
            HomeForm_btnHome.ForeColor = StandForeColor;
            HomeForm_btnHome.BackColor = StandBackColor;
        }

        private void HomeForm_btnRegisted_Click(object sender, EventArgs e)
        {
            HomeForm_btnRegisted.BackColor = ClickBackColor;
            HomeForm_btnRegisted.ForeColor = ClickForeColor;
            Panel_Home.Controls.Clear();
            RepositoryService f = new RepositoryService();
            f.TopLevel = false;
            Panel_Home.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void btn_department_Enter(object sender, EventArgs e)
        {
            btn_department.BackColor = ClickBackColor;
            btn_department.ForeColor = ClickForeColor;
            Panel_Home.Controls.Clear();
            RegistrationDepartment f = new RegistrationDepartment();
            f.TopLevel = false;
            Panel_Home.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void btn_serviceDetail_Enter(object sender, EventArgs e)
        {
            btn_serviceDetail.ForeColor = ClickForeColor;
            btn_serviceDetail.BackColor = ClickBackColor;
            Panel_Home.Controls.Clear();
            ServiceDetail f = new ServiceDetail();
            f.TopLevel = false;
            Panel_Home.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void btn_serviceDetail_Leave(object sender, EventArgs e)
        {
            btn_serviceDetail.ForeColor = StandForeColor;
            btn_serviceDetail.BackColor = StandBackColor;
        }

        private void HomeForm_btnStudentAccount_Enter(object sender, EventArgs e)
        {
            HomeForm_btnStudentAccount.ForeColor = ClickForeColor;
            HomeForm_btnStudentAccount.BackColor = ClickBackColor;
            Panel_Home.Controls.Clear();
            MiniForm_StudentAccount f = new MiniForm_StudentAccount();
            f.TopLevel = false;
            Panel_Home.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void HomeForm_btnStudentAccount_Leave(object sender, EventArgs e)
        {
            HomeForm_btnStudentAccount.ForeColor = StandForeColor;
            HomeForm_btnStudentAccount.BackColor = StandBackColor;
        }

        private void btn_statistical_Enter(object sender, EventArgs e)
        {
            btn_statistical.ForeColor = ClickForeColor;
            btn_statistical.BackColor = ClickBackColor;
            Panel_Home.Controls.Clear();
            Statisticall f = new Statisticall();
            f.TopLevel = false;
            Panel_Home.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void btn_statistical_Leave(object sender, EventArgs e)
        {
            btn_statistical.ForeColor = StandForeColor;
            btn_statistical.BackColor = StandBackColor;
        }

        private void HomeForm_btnRegisted_Leave(object sender, EventArgs e)
        {
            HomeForm_btnRegisted.ForeColor = StandForeColor;
            HomeForm_btnRegisted.BackColor = StandBackColor;
        }

        private void btn_department_Leave(object sender, EventArgs e)
        {
            btn_department.ForeColor = StandForeColor;
            btn_department.BackColor = StandBackColor;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            btn_authorization.ForeColor = ClickForeColor;
            btn_authorization.BackColor = ClickBackColor;
            Panel_Home.Controls.Clear();
            Authorization f = new Authorization();
            f.TopLevel = false;
            Panel_Home.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void btn_authorization_Leave(object sender, EventArgs e)
        {
            btn_authorization.ForeColor = StandForeColor;
            btn_authorization.BackColor = StandBackColor;
        }

        private void HomeForm_btnSwithView_Enter(object sender, EventArgs e)
        {
            StudentForm_Home student = new StudentForm_Home();
            student.Username = Name;
            student.Role = Role;
            student.UserID = UserID;
            student.Balance = Balance;
            this.Hide();
            student.Show();
        }
    }
}
