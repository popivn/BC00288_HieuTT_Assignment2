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
    public partial class Student_RegInformationChangeService : Form
    {
        internal DataValidation dataValidation = new DataValidation();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        public string Username { get; set; }
        public string Role { get; set; }
        public string UserID { get; set; }
        public int Balance { get; set; }
        public int totalAmount { get; set; }
        public int quantity { get; set; }
        public Student_RegInformationChangeService()
        {
            InitializeComponent();
        }

        private void Student_RegInformationChangeService_Load(object sender, EventArgs e)
        {
            tb_balance.Text = Convert.ToString(Balance);
            tb_fee.Text = totalAmount.ToString();
            ServiceDAO serviceDAO = new ServiceDAO();
            InformationChangeServiceDAO informationChangeServiceDAO = new InformationChangeServiceDAO();
            List<InformationChangeService> infc = informationChangeServiceDAO.GetInformationChangeServices();
            List<Service> service = serviceDAO.GetAllServices();
            tb_ServiceID.Text = GenerateUniqueKeyService(service);
            tb_changeID.Text = GenerateUniqueKeyinfc(infc);
            UsersDAO usersDAO = new UsersDAO();
            List<Users> u = usersDAO.getUsers();
            Users FoundUserMajor = u.FirstOrDefault(u1 => u1.userID == UserID);
            tb_major.Text = FoundUserMajor.major;
        }
        private string GenerateUniqueKeyinfc(List<InformationChangeService> infc)
        {
            int maxId = 0;

            foreach (InformationChangeService s in infc)
            {
                string serviceID = s.ChangeIDProp;
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

        public bool AddService()
        {
            try
            {
                ServiceDAO serviceDAO = new ServiceDAO();
                Service s = new Service(tb_ServiceID.Text.ToString(), UserID.ToString(), "1", "3", tb_fee.Text.ToString(), quantity.ToString(), "Pending");
                serviceDAO.AddServices(s);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public void AddInfc()
        {
            try
            {
                InformationChangeServiceDAO infcDAO = new InformationChangeServiceDAO();
                InformationChangeService infc = new InformationChangeService(tb_changeID.Text.ToString(),tb_ServiceID.Text, cbb_changeType.Text.ToString(), Convert.ToDecimal(tb_fee.Text), Convert.ToDateTime(dtp_registrationDate.Text), tb_major.Text, tb_description.Text, tb_file.Text);
                infcDAO.AddInformationChangeService(infc);
            }
            catch (Exception)
            {
                MessageBox.Show("Something Wrong");
                throw;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try
            {
                AddService();
                AddInfc();
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
