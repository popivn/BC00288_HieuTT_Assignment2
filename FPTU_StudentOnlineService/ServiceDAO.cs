using FTU_StudentOnlineService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FTU_StudentOnlineService
{
    internal class ServiceDAO
    {
        private connect conn;

        public ServiceDAO()
        {
            conn = new connect();
        }

        public List<Service> GetServicesForDataGridView()
        {
            List<Service> services = new List<Service>();
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                // Assuming the Service table has a foreign key relationship with the Users table on UserID
                string query = "SELECT * FROM Service s INNER JOIN Users u ON s.UserID = u.UserID WHERE u.StudentStatus = 'Active'";
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Assuming column names, adjust them based on your database schema
                        string serviceID = reader["ServiceID"].ToString();
                        string userID = reader["UserID"].ToString();
                        string serviceTypeID = reader["ServiceTypeID"].ToString();
                        string departmentID = reader["DepartmentID"].ToString();
                        string totalAmount = reader["TotalAmount"].ToString();
                        string quantity = reader["Quantity"].ToString();
                        string serviceFormStatus = reader["ServiceFormStatus"].ToString();

                        Service service = new Service(serviceID, userID, serviceTypeID, departmentID, totalAmount, quantity, serviceFormStatus);
                        services.Add(service);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Conn.Close();
                command.Dispose();
            }

            return services;
        }

        public List<Service> GetAllServices()
        {
            List<Service> services = new List<Service>();
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                // Assuming the Service table has a foreign key relationship with the Users table on UserID
                string query = "SELECT * FROM Service ";
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Assuming column names, adjust them based on your database schema
                        string serviceID = reader["ServiceID"].ToString();
                        string userID = reader["UserID"].ToString();
                        string serviceTypeID = reader["ServiceTypeID"].ToString();
                        string departmentID = reader["DepartmentID"].ToString();
                        string totalAmount = reader["TotalAmount"].ToString();
                        string quantity = reader["Quantity"].ToString();
                        string serviceFormStatus = reader["ServiceFormStatus"].ToString();

                        Service service = new Service(serviceID, userID, serviceTypeID, departmentID, totalAmount, quantity, serviceFormStatus);
                        services.Add(service);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Conn.Close();
                command.Dispose();
            }

            return services;
        }

        public void EditServiceStatus(string serviceID, string newStatus)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = "UPDATE Service SET ServiceFormStatus = @NewStatus WHERE ServiceID = @ServiceID";
                command.CommandText = query;
                command.Parameters.AddWithValue("@NewStatus", newStatus);
                command.Parameters.AddWithValue("@ServiceID", serviceID);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Conn.Close();
                command.Dispose();
            }
        }

        public List<Service> SearchServicesByUserID(string userID)
        {
            List<Service> services = new List<Service>();
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                // Assuming the Service table has a foreign key relationship with the Users table on UserID
                string query = "SELECT * FROM Service s INNER JOIN Users u ON s.UserID = u.UserID WHERE u.UserID = @UserID AND u.StudentStatus = 'Active'";
                command.CommandText = query;
                command.Parameters.AddWithValue("@UserID", userID);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Assuming column names, adjust them based on your database schema
                        string serviceID = reader["ServiceID"].ToString();
                        string serviceTypeID = reader["ServiceTypeID"].ToString();
                        string departmentID = reader["DepartmentID"].ToString();
                        string totalAmount = reader["TotalAmount"].ToString();
                        string quantity = reader["Quantity"].ToString();
                        string serviceFormStatus = reader["ServiceFormStatus"].ToString();

                        Service service = new Service(serviceID, userID, serviceTypeID, departmentID, totalAmount, quantity, serviceFormStatus);
                        services.Add(service);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Conn.Close();
                command.Dispose();
            }

            return services;
        }
        public void AddServices(Service service)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = "INSERT INTO Service (ServiceID, UserID, ServiceTypeID, DepartmentID, TotalAmount, Quantity, ServiceFormStatus) " +
                               "VALUES (@ServiceID, @UserID, @ServiceTypeID, @DepartmentID, @TotalAmount, @Quantity, @ServiceFormStatus)";

                command.CommandText = query;

                // Add parameters to prevent SQL injection for each service in the list
                command.Parameters.Clear(); // Clear previous parameters
                command.Parameters.AddWithValue("@ServiceID", service.serviceID);
                command.Parameters.AddWithValue("@UserID", service.userID);
                command.Parameters.AddWithValue("@ServiceTypeID", service.serviceTypeID);
                command.Parameters.AddWithValue("@DepartmentID", service.departmentID);
                command.Parameters.AddWithValue("@TotalAmount", service.totalAmount);
                command.Parameters.AddWithValue("@Quantity", service.quantity);
                command.Parameters.AddWithValue("@ServiceFormStatus", service.serviceFormStatus);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Conn.Close();
                command.Dispose();
            }
        }

    }
}
