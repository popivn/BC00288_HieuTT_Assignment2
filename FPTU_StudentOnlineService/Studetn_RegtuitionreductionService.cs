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

namespace FTU_StudentOnlineService
{
    public partial class Studetn_RegtuitionreductionService : Form
    {
        DataValidation dataValidation = new DataValidation();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public string Username { get; set; }
        public string Role { get; set; }
        public string UserID { get; set; }
        public int Balance { get; set; }
        public int totalAmount { get; set; }
        public int quantity { get; set; }
        public Studetn_RegtuitionreductionService()
        {
            InitializeComponent();
        }

        private void Studetn_RegtuitionreductionService_Load(object sender, EventArgs e)
        {
            tb_balance.Text = Convert.ToString(Balance);
            tb_fee.Text = totalAmount.ToString();
            ServiceDAO serviceDAO = new ServiceDAO();
            TuitionReductionServiceDAO trDAO = new TuitionReductionServiceDAO();
            List<TuitionReductionService> tr = trDAO.GetTuitionReductionServices();
            List<Service> service = serviceDAO.GetAllServices();
            tb_ServiceID.Text = GenerateUniqueKeyService(service);
            tb_reductionID.Text = GenerateUniqueKeytr(tr);
            UsersDAO usersDAO = new UsersDAO();
            List<Users> u = usersDAO.getUsers();
            Users FoundUserMajor = u.FirstOrDefault(u1 => u1.userID == UserID);
            tb_major.Text = FoundUserMajor.major;
            tb_PhoneNumber.Text = FoundUserMajor.phonenumber;
        }

        private string GenerateUniqueKeytr(List<TuitionReductionService> tr)
        {
            int maxId = 0;

            foreach (TuitionReductionService s in tr)
            {
                string serviceID = s.ReductionIDProp;
                int idNumber = 0;
                idNumber = int.Parse(serviceID);
                if (idNumber > maxId)
                {
                    maxId = idNumber;
                }
            }

            string newId = "" + (maxId + 1);

            return newId;
        }
    
        private string GenerateUniqueKeyService(List<Service> services)
        {
            int maxId = 0;

            foreach (Service s in services)
            {
                string serviceID = s.serviceID;
                int idNumber = 0;
                idNumber = int.Parse(serviceID);
                if (idNumber > maxId)
                {
                    maxId = idNumber;
                }
            }

            string newId = "" + (maxId + 1);

            return newId;
        }
        public bool AddService()
        {
            try
            {
                ServiceDAO serviceDAO = new ServiceDAO();
                Service s = new Service(tb_ServiceID.Text.ToString(), UserID.ToString(), "2", "1", tb_fee.Text.ToString(), quantity.ToString(), "Pending");
                serviceDAO.AddServices(s);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public void Addtr()
        {
            try
            {
                TuitionReductionServiceDAO trDAO = new TuitionReductionServiceDAO();
                TuitionReductionService tr = new TuitionReductionService(tb_reductionID.Text.ToString(), tb_ServiceID.Text, cbb_course.Text, Convert.ToDecimal(tb_fee.Text), tb_file.Text, tb_major.Text, Convert.ToDateTime(dtp_registrationDate.Text),tb_PhoneNumber.Text, tb_deliveryMethod.Text, tb_resuiltDeliveryMethod.Text);
                trDAO.AddTuitionReductionService(tr);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong");
                throw;
            }
        }

        private void ClearAllTextBoxesAndComboBoxes()
        {
            // Iterate through all controls in the Form
            foreach (Control control in Controls)
            {
                // Check if it is a TextBox or ComboBox
                if (control is TextBox || control is ComboBox)
                {
                    // Set empty values (null or empty string) for TextBoxes and ComboBoxes
                    (control as TextBox)?.Clear();
                    (control as ComboBox)?.Items.Clear();
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                AddService();
                Addtr();
                BalanceDAO balanceDAO = new BalanceDAO();
                decimal a = Convert.ToDecimal(tb_balance.Text);
                decimal b = Convert.ToDecimal(tb_fee.Text);
                decimal newBalance = Convert.ToDecimal(a - b);
                balanceDAO.UpdateBalance(UserID, newBalance);
                StudentForm_Home student = new StudentForm_Home();
                student.Username = Username;
                student.Role = Role;
                student.UserID = UserID;
                student.Balance = Convert.ToInt32(tb_balance.Text);
                ClearAllTextBoxesAndComboBoxes();
                this.Hide();
                student.Show();
            }
            catch (Exception)
            {
                throw;
            }

            MessageBox.Show("Successful registration");
        }

        private void OpenFileSelectionDialog()
        {
            openFileDialog.Filter = "Word Documents (*.doc; *.docx)|*.doc;*.docx|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                tb_file.Text = Path.GetFileName(selectedFilePath);
                if (!dataValidation.IsFileExtensionValid(selectedFilePath, ".doc", ".docx"))
                {
                    MessageBox.Show("Invalid file format. Please choose a .doc or .docx file.");
                    tb_file.Text = "";
                }
            }
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            OpenFileSelectionDialog();
        }

    }
}
