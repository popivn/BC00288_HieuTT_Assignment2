using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FTU_StudentOnlineService
{
    public partial class RepositoryService : Form
    {
        public string Status = "None";
        public static string Username = null;
        public static string Password = null;
        private Color ClickBackColor = Color.Blue;
        private Color ClickForeColor = Color.White;
        private Color StandBackColor = Color.PeachPuff;
        private Color StandForeColor = Color.Black;
        public RepositoryService()
        {
            InitializeComponent();
        }
        private void LoadColumnRepositoryList()
        {
            table_repositoryService.ColumnCount = 7;
            table_repositoryService.Columns[0].Name = "Service ID";
            table_repositoryService.Columns[1].Name = "User ID";
            table_repositoryService.Columns[2].Name = "Service Type ID";
            table_repositoryService.Columns[3].Name = "Department ID";
            table_repositoryService.Columns[4].Name = "Total Amount ";
            table_repositoryService.Columns[5].Name = "Quantity";
            table_repositoryService.Columns[6].Name = "Status";
        }

        private void LoadDataRepositoryService()
        {
            table_repositoryService.Rows.Clear();
            ServiceDAO sDAO = new ServiceDAO();
            List<Service> services = sDAO.GetServicesForDataGridView();

            foreach (Service service in services)
            {
                string[] row = { service.serviceID.ToString(), service.userID.ToString(), service.serviceTypeID.ToString(), service.departmentID.ToString(), service.totalAmount.ToString(), service.quantity.ToString(), service.serviceFormStatus.ToString() };
                table_repositoryService.Rows.Add(row);
            }
        }

        private void table_repositoryService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            table_repositoryService.ReadOnly = true;

            if (table_repositoryService.RowCount > 1 && table_repositoryService.CurrentRow != null)
            {
                int rowIndex = table_repositoryService.CurrentCell.RowIndex;

                if (table_repositoryService.Rows.Count - 2 >= rowIndex)
                {
                    string serviceID = table_repositoryService.Rows[rowIndex].Cells[0].Value.ToString();
                    string userID = table_repositoryService.Rows[rowIndex].Cells[1].Value.ToString();
                    string serviceTypeID = table_repositoryService.Rows[rowIndex].Cells[2].Value.ToString();
                    string departmentID = table_repositoryService.Rows[rowIndex].Cells[3].Value.ToString();
                    string totalAmount = table_repositoryService.Rows[rowIndex].Cells[4].Value.ToString();
                    string quantity = table_repositoryService.Rows[rowIndex].Cells[5].Value.ToString();
                    string serviceFormStatus = table_repositoryService.Rows[rowIndex].Cells[6].Value.ToString();

                    tb_serviceID.Text = serviceID;
                    UsersDAO usersDAO = new UsersDAO();
                    List<Users> users = usersDAO.getUsers();
                    Users foundUser = users.FirstOrDefault(user => user.userID == userID);
                    tb_userID.Text = $"{userID} - {foundUser.name}";
                    ServiceTypeDAO servicetypeDAO = new ServiceTypeDAO();
                    List<ServiceType> serviceTypes = servicetypeDAO.GetServiceTypes();
                    ServiceType foundServiceType = serviceTypes.FirstOrDefault(serviceType => serviceType.serviceTypeID == serviceTypeID);
                    tb_servicetypeID.Text = $"{serviceTypeID} - {foundServiceType.serviceName}";
                    DepartmentDAO departmentDAO = new DepartmentDAO();
                    List<Department> departments = departmentDAO.getDepartments();
                    Department founddepartment = departments.FirstOrDefault(s => s.departmentID == departmentID);
                    tb_departmentID.Text = $"{departmentID} - {founddepartment.departmentName}";
                    tb_totalAmount.Text = totalAmount;
                    tb_quantity.Text = quantity;
                    cbb_status.Text = serviceFormStatus;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_userID.Text))
            {
                btn_save.ForeColor = ClickForeColor;
                btn_save.BackColor = ClickBackColor;
                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure to  Change this Status?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Call the function to save data
                    ServiceDAO sDAO = new ServiceDAO();
                    try
                    {
                        string feePart = tb_userID.Text.Split('-')[0];
                        sDAO.EditServiceStatus(feePart, cbb_status.Text);
                        MessageBox.Show("Change Complete.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Any wrong here maybe lost infomation");
                    }
                }
                btn_save.ForeColor = StandForeColor;
                btn_save.BackColor = StandBackColor;
            }
            else
            {
                MessageBox.Show("Need ID");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadDataRepositoryService();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cbb_search.Text == "Search by UserID")
            {
                table_repositoryService.Rows.Clear();
                ServiceDAO sDAO = new ServiceDAO();
                List<Service> s = sDAO.SearchServicesByUserID(tb_search.Text);
                foreach (Service service in s)
                {
                    string[] row = { service.serviceID.ToString(), service.userID.ToString(), service.serviceTypeID.ToString(), service.departmentID.ToString(), service.totalAmount.ToString(), service.quantity.ToString(), service.serviceFormStatus.ToString() };
                    table_repositoryService.Rows.Add(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_Form1 f = new Home_Form1();
            f.BtnDepartmentEnterClicked += (s, ev) =>
            {
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Show();
            };
            f.TriggerBtnDepartmentEnterClicked();
        }

        private void RepositoryService_Load(object sender, EventArgs e)
        {
            cbb_search.SelectedIndex = 0;
            LoadColumnRepositoryList();
            LoadDataRepositoryService();
        }
    }
}

