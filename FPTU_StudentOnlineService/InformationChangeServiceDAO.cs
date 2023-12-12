using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class InformationChangeServiceDAO
    {
        private connect conn = new connect();

        public List<InformationChangeService> GetInformationChangeServices()
        {
            List<InformationChangeService> listICS = new List<InformationChangeService>();
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = "SELECT ICS.*FROM InformationChangeServiceDetail ICS INNER JOIN Service S ON ICS.ServiceID = S.ServiceID INNER JOIN Users U ON S.UserID = U.UserID WHERE U.StudentStatus = 'Active';";
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string changeID = reader["ChangeID"].ToString();
                        string serviceID = reader["ServiceID"].ToString();
                        string changeType = reader["ChangType"].ToString();
                        decimal fee = Convert.ToDecimal(reader["Fee"]);
                        DateTime registrationDate = Convert.ToDateTime(reader["RegistrationDate"]);
                        string major = reader["Major"].ToString();
                        string description = reader["Description"].ToString();
                        string fileAttached = reader["FileAttached"].ToString();

                        InformationChangeService infoChangeService = new InformationChangeService(
                            changeID, serviceID, changeType, fee, registrationDate, major, description, fileAttached);

                        listICS.Add(infoChangeService);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Conn.Close();
            }

            return listICS;
        }
        public void UpdateInformationChangeService(InformationChangeService infoChangeService)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = @"UPDATE InformationChangeServiceDetail SET " +
                                "ServiceID = @ServiceID, ChangType = @ChangType, Fee = @Fee, " +
                                "RegistrationDate = @RegistrationDate, Major = @Major, " +
                                "Description = @Description, FileAttached = @FileAttached " +
                                "WHERE ChangeID = @ChangeID";

                command.CommandText = query;
                command.Parameters.AddWithValue("@ChangeID", infoChangeService.ChangeIDProp);
                command.Parameters.AddWithValue("@ServiceID", infoChangeService.ServiceIDProp);
                command.Parameters.AddWithValue("@ChangType", infoChangeService.ChangeTypeProp);
                command.Parameters.AddWithValue("@Fee", infoChangeService.FeeProp);
                command.Parameters.AddWithValue("@RegistrationDate", infoChangeService.RegistrationDateProp);
                command.Parameters.AddWithValue("@Major", infoChangeService.MajorProp);
                command.Parameters.AddWithValue("@Description", infoChangeService.DescriptionProp);
                command.Parameters.AddWithValue("@FileAttached", infoChangeService.FileAttachedProp);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Conn.Close();
            }
        }

        public void DeleteInformationChangeService(string changeID)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = "DELETE FROM InformationChangeServiceDetail WHERE ChangeID = @ChangeID";

                command.CommandText = query;
                command.Parameters.AddWithValue("@ChangeID", changeID);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Conn.Close();
            }
        }

        public void AddInformationChangeService(InformationChangeService infoChangeService)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = @"INSERT INTO InformationChangeServiceDetail (ChangeID, ServiceID, ChangType, Fee, RegistrationDate, Major, Description, FileAttached) " +
                               "VALUES (@ChangeID, @ServiceID, @ChangType, @Fee, @RegistrationDate, @Major, @Description, @FileAttached)";

                command.CommandText = query;
                command.Parameters.AddWithValue("@ChangeID", infoChangeService.ChangeIDProp);
                command.Parameters.AddWithValue("@ServiceID", infoChangeService.ServiceIDProp);
                command.Parameters.AddWithValue("@ChangType", infoChangeService.ChangeTypeProp);
                command.Parameters.AddWithValue("@Fee", infoChangeService.FeeProp);
                command.Parameters.AddWithValue("@RegistrationDate", infoChangeService.RegistrationDateProp);
                command.Parameters.AddWithValue("@Major", infoChangeService.MajorProp);
                command.Parameters.AddWithValue("@Description", infoChangeService.DescriptionProp);
                command.Parameters.AddWithValue("@FileAttached", infoChangeService.FileAttachedProp);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Conn.Close();
            }

        }
        public string GetUserNameByServiceID(string serviceID)
        {
            string userName = "";

            try
            {
                conn.Conn.Open();

                string query = "SELECT U.UserID, U.Name FROM Service S JOIN Users U ON S.UserID = U.UserID WHERE S.ServiceID = @ServiceID";

                using (SqlCommand command = new SqlCommand(query, conn.Conn))
                {
                    command.Parameters.AddWithValue("@ServiceID", serviceID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            userName = reader["Name"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Conn.Close();
            }

            return userName;
        }
        public List<InformationChangeService> SearchInformationChangeServicesByUsername(string username)
        {
            List<InformationChangeService> result = new List<InformationChangeService>();

            try
            {
                conn.Conn.Open();

                string query = @"
            SELECT ICS.*
            FROM InformationChangeServiceDetail ICS
            INNER JOIN Service S ON ICS.ServiceID = S.ServiceID
            INNER JOIN Users U ON S.UserID = U.UserID
            WHERE U.StudentStatus = 'Active' 
              AND U.Gmail LIKE '%' + @Username + '%@gmail.com'
              AND S.ServiceTypeID = 1;";

                using (SqlCommand command = new SqlCommand(query, conn.Conn))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read data from columns and create an InformationChangeService object
                            string changeID = reader["ChangeID"].ToString();
                            string serviceID = reader["ServiceID"].ToString();
                            string changeType = reader["ChangType"].ToString();
                            decimal fee = Convert.ToDecimal(reader["Fee"]);
                            DateTime registrationDate = Convert.ToDateTime(reader["RegistrationDate"]);
                            string major = reader["Major"].ToString();
                            string description = reader["Description"].ToString();
                            string fileAttached = reader["FileAttached"].ToString();

                            InformationChangeService informationChangeService = new InformationChangeService(
                                changeID, serviceID, changeType, fee, registrationDate, major, description, fileAttached);

                            result.Add(informationChangeService);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Conn.Close();
            }

            return result;
        }
    }
}
