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
    public partial class Student_registrationService : Form
    {
        DataValidation data = new DataValidation();
        public string Username { get; set; }
        public string Role { get; set; }
        public string UserID { get; set; }
        public int Balance { get; set; }

        public int infcFee = 5;
        public int scFee = 6;
        public int trFee = 7;
        public Student_registrationService()
        {
            InitializeComponent();
        }

        private void Student_registrationService_Load(object sender, EventArgs e)
        {
            cbb_chooseService.SelectedIndex = 0;
        }

        public bool AreFieldsFilled()
        {
            return !string.IsNullOrEmpty(tb_quantity.Text);
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (data.IsNumeric(tb_quantity.Text))
            {
                if (cbb_chooseService.Text == "Information Change Service")
                {
                    if (AreFieldsFilled())
                    {
                        int quantity = Convert.ToInt32(tb_quantity.Text);
                        tb_totalAmount.Text = Convert.ToString(quantity * infcFee);

                        Student_RegInformationChangeService f = new Student_RegInformationChangeService();
                        f.Username = Username;
                        f.Role = Role;
                        f.UserID = UserID;
                        f.Balance = Balance;
                        f.totalAmount = Convert.ToInt32(tb_totalAmount.Text);
                        f.quantity = quantity;
                        f.TopLevel = false;
                        panel_informationchange.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Fill Enough Information");
                    }
                }
                if (cbb_chooseService.Text == "Tuition Reduction Service")
                {
                    if (AreFieldsFilled())
                    {
                        int quantity = Convert.ToInt32(tb_quantity.Text);
                        tb_totalAmount.Text = Convert.ToString(quantity * trFee);

                        Studetn_RegtuitionreductionService f = new Studetn_RegtuitionreductionService();
                        f.Username = Username;
                        f.Role = Role;
                        f.UserID = UserID;
                        f.Balance = Balance;
                        f.totalAmount = Convert.ToInt32(tb_totalAmount.Text);
                        f.quantity = quantity;
                        f.TopLevel = false;
                        panel_informationchange.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Fill Enough Information");
                    }
                }
                if (cbb_chooseService.Text == "Student Confirmation Service")
                {
                    if (AreFieldsFilled())
                    {
                        int quantity = Convert.ToInt32(tb_quantity.Text);
                        tb_totalAmount.Text = Convert.ToString(quantity * scFee);

                        Student_RegstudentconfirmationService f = new Student_RegstudentconfirmationService();
                        f.Username = Username;
                        f.Role = Role;
                        f.UserID = UserID;
                        f.Balance = Balance;
                        f.totalAmount = Convert.ToInt32(tb_totalAmount.Text);
                        f.quantity = quantity;
                        f.TopLevel = false;
                        panel_informationchange.Controls.Add(f);
                        f.Dock = DockStyle.Fill;
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Fill Enough Information");
                    }
                }
            }
        }

        private void tb_quantity_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumeric(tb_quantity.Text))
            {
                tb_quantity.Text = null;
            }
            
        }

        private bool IsNumeric(string text)
        {
            return double.TryParse(text, out _);
        }
    }
}
