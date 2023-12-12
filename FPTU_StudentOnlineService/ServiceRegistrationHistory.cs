using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FTU_StudentOnlineService
{
    public partial class ServiceRegistrationHistory : Form
    {
        internal connect connect = new connect();

        public string Username { get; set; }
        public string Role { get; set; }
        public string UserID { get; set; }
        public int Balance { get; set; }

        public ServiceRegistrationHistory()
        {
            InitializeComponent();
        }

        private void InitializeDataGridView()
        {
            table_servicetransactionHistory.ColumnCount = 6;
            table_servicetransactionHistory.Columns[0].Name = "Service ID";
            table_servicetransactionHistory.Columns[1].Name = "Service Name";
            table_servicetransactionHistory.Columns[2].Name = "Total Amount";
            table_servicetransactionHistory.Columns[3].Name = "Quantity ";
            table_servicetransactionHistory.Columns[4].Name = "Status";
            table_servicetransactionHistory.Columns[5].Name = "Registration Date";
        }

        private void LoadDataUsers()
        {
            table_servicetransactionHistory.Rows.Clear();
            List<ServiceTransactionHistory> users = LoadData();
            foreach (ServiceTransactionHistory U in users)
            {
                string[] row = { U.ServiceID.ToString(), U.ServiceName.ToString(), U.TotalAmount.ToString(), U.Quantity.ToString(), U.ServiceFormStatus.ToString(), U.RegistrationDate.ToString() };
                table_servicetransactionHistory.Rows.Add(row);
            }
        }

        private List<ServiceTransactionHistory> LoadData()
        {
            List<ServiceTransactionHistory> serviceDataList = new List<ServiceTransactionHistory>();

            try
            {
                connect.Conn.Open();
                using (SqlCommand command = new SqlCommand(
                    "SELECT s.ServiceID, " +
                    "st.ServiceName, " +
                    "s.TotalAmount, " +
                    "s.Quantity, " +
                    "s.ServiceFormStatus, " +
                    "CASE " +
                    "    WHEN st.ServiceTypeID = 1 THEN ic.RegistrationDate " +
                    "    WHEN st.ServiceTypeID = 2 THEN tr.RegistrationDate " +
                    "    WHEN st.ServiceTypeID = 3 THEN sc.RegistrationDate " +
                    "    ELSE NULL " +
                    "END AS RegistrationDate " +
                    "FROM Service s " +
                    "JOIN Users u ON s.UserID = u.UserID " +
                    "JOIN ServiceType st ON s.ServiceTypeID = st.ServiceTypeID " +
                    "LEFT JOIN InformationChangeServiceDetail ic ON s.ServiceID = ic.ServiceID AND st.ServiceTypeID = 1 " +
                    "LEFT JOIN TuitionReductionServiceDetails tr ON s.ServiceID = tr.ServiceID AND st.ServiceTypeID = 2 " +
                    "LEFT JOIN StudentConfirmationServiceDetails sc ON s.ServiceID = sc.ServiceID AND st.ServiceTypeID = 3 " +
                    "WHERE u.UserID = @UserID", connect.Conn))
                {
                    // Add the parameter for UserID
                    command.Parameters.AddWithValue("@UserID", Convert.ToInt32(UserID));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string serviceID = reader["ServiceID"].ToString();
                            string serviceName = reader["ServiceName"].ToString();
                            decimal totalAmount = (decimal)reader["TotalAmount"];
                            int quantity = (int)reader["Quantity"];
                            string serviceFormStatus = reader["ServiceFormStatus"].ToString();
                            DateTime? registrationDate = reader["RegistrationDate"] != DBNull.Value ? (DateTime?)reader["RegistrationDate"] : null;
                            ServiceTransactionHistory user = new ServiceTransactionHistory(serviceID, serviceName, totalAmount, quantity, serviceFormStatus, registrationDate);
                            serviceDataList.Add(user);
                        }
                    }
                }
                connect.Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return serviceDataList;
        }

        private void ServiceRegistrationHistory_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            LoadDataUsers();
        }
    }
}
