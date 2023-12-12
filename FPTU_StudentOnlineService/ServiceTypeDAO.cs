using FTU_StudentOnlineService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FTU_StudentOnlineService
{
    internal class ServiceTypeDAO
    {
        connect conn = new connect();
        public ServiceTypeDAO()
        {

        }
        public List<ServiceType> GetServiceTypes()
        {
            List<ServiceType> serviceTypes = new List<ServiceType>();

            try
            {
                SqlCommand command = new SqlCommand();
                conn.Conn.Open();
                command.Connection = conn.Conn;
                string query = "SELECT * FROM ServiceType";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string serviceTypeID = reader["ServiceTypeID"].ToString();
                        string serviceName = reader["ServiceName"].ToString();
                        string description = reader["Description"].ToString();

                        ServiceType serviceType = new ServiceType(serviceTypeID, serviceName, description);
                        serviceTypes.Add(serviceType);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Conn.Close();
            }

            return serviceTypes;
        }
    }
}