using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FTU_StudentOnlineService
{
    internal class StudentConfirmationDAO
    {
        private connect conn = new connect();

        public List<StudentConfirmationService> GetStudentConfirmationServices()
        {
            List<StudentConfirmationService> listSCS = new List<StudentConfirmationService>();
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = "SELECT SCS.* FROM StudentConfirmationServiceDetails SCS INNER JOIN Service S ON SCS.ServiceID = S.ServiceID INNER JOIN Users U ON S.UserID = U.UserID WHERE U.StudentStatus = 'Active';";
                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string confirmationID = reader["ConfirmationID"].ToString();
                        string serviceID = reader["ServiceID"].ToString();
                        decimal fee = Convert.ToDecimal(reader["Fee"]);
                        string major = reader["Major"].ToString();
                        string confirmationType = reader["ConfirmationType"].ToString();
                        string phoneNumber = reader["PhoneNumber"].ToString();
                        string fileAttached = reader["FileAttached"].ToString();
                        DateTime registrationDate = Convert.ToDateTime(reader["RegistrationDate"]);
                        string description = reader["Description"].ToString();
                        string deliveryMethod = reader["DeliveryMethod"].ToString();
                        string resultDeliveryMethod = reader["ResuiltDeliveryMethod"].ToString(); // Corrected attribute name

                        StudentConfirmationService studentConfirmationService = new StudentConfirmationService(
                            confirmationID, serviceID, fee, major, confirmationType, phoneNumber, fileAttached, registrationDate, description, deliveryMethod, resultDeliveryMethod);

                        listSCS.Add(studentConfirmationService);
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

            return listSCS;
        }

        public void UpdateStudentConfirmationService(StudentConfirmationService studentConfirmationService)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = @"UPDATE StudentConfirmationServiceDetails SET " +
                                "ServiceID = @ServiceID, Fee = @Fee, Major = @Major, " +
                                "ConfirmationType = @ConfirmationType, PhoneNumber = @PhoneNumber, " +
                                "FileAttached = @FileAttached, RegistrationDate = @RegistrationDate, " +
                                "Description = @Description, DeliveryMethod = @DeliveryMethod, " +
                                "ResuiltDeliveryMethod = @ResuiltDeliveryMethod " +
                                "WHERE ConfirmationID = @ConfirmationID";

                command.CommandText = query;
                command.Parameters.AddWithValue("@ConfirmationID", studentConfirmationService.ConfirmationIDProp);
                command.Parameters.AddWithValue("@ServiceID", studentConfirmationService.ServiceIDProp);
                command.Parameters.AddWithValue("@Fee", studentConfirmationService.FeeProp);
                command.Parameters.AddWithValue("@Major", studentConfirmationService.MajorProp);
                command.Parameters.AddWithValue("@ConfirmationType", studentConfirmationService.ConfirmationTypeProp);
                command.Parameters.AddWithValue("@PhoneNumber", studentConfirmationService.PhoneNumberProp);
                command.Parameters.AddWithValue("@FileAttached", studentConfirmationService.FileAttachedProp);
                command.Parameters.AddWithValue("@RegistrationDate", studentConfirmationService.RegistrationDateProp);
                command.Parameters.AddWithValue("@Description", studentConfirmationService.DescriptionProp);
                command.Parameters.AddWithValue("@DeliveryMethod", studentConfirmationService.DeliveryMethodProp);
                command.Parameters.AddWithValue("@ResuiltDeliveryMethod", studentConfirmationService.ResuiltDeliveryMethodProp);

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

        public void DeleteStudentConfirmationService(string confirmationID)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = "DELETE FROM StudentConfirmationServiceDetails WHERE ConfirmationID = @ConfirmationID";

                command.CommandText = query;
                command.Parameters.AddWithValue("@ConfirmationID", confirmationID);

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

        public void AddStudentConfirmationService(StudentConfirmationService studentConfirmationService)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = @"INSERT INTO StudentConfirmationServiceDetails (ConfirmationID, ServiceID, Fee, Major, ConfirmationType, PhoneNumber, FileAttached, RegistrationDate, Description, DeliveryMethod, ResuiltDeliveryMethod) " +
                                "VALUES (@ConfirmationID, @ServiceID, @Fee, @Major, @ConfirmationType, @PhoneNumber, @FileAttached, @RegistrationDate, @Description, @DeliveryMethod, @ResuiltDeliveryMethod)";

                command.CommandText = query;
                command.Parameters.AddWithValue("@ConfirmationID", studentConfirmationService.ConfirmationIDProp);
                command.Parameters.AddWithValue("@ServiceID", studentConfirmationService.ServiceIDProp);
                command.Parameters.AddWithValue("@Fee", studentConfirmationService.FeeProp);
                command.Parameters.AddWithValue("@Major", studentConfirmationService.MajorProp);
                command.Parameters.AddWithValue("@ConfirmationType", studentConfirmationService.ConfirmationTypeProp);
                command.Parameters.AddWithValue("@PhoneNumber", studentConfirmationService.PhoneNumberProp);
                command.Parameters.AddWithValue("@FileAttached", studentConfirmationService.FileAttachedProp);
                command.Parameters.AddWithValue("@RegistrationDate", studentConfirmationService.RegistrationDateProp);
                command.Parameters.AddWithValue("@Description", studentConfirmationService.DescriptionProp);
                command.Parameters.AddWithValue("@DeliveryMethod", studentConfirmationService.DeliveryMethodProp);
                command.Parameters.AddWithValue("@ResuiltDeliveryMethod", studentConfirmationService.ResuiltDeliveryMethodProp);

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
        public List<StudentConfirmationService> SearchStudentConfirmationServicesByUsername(string username)
        {
            List<StudentConfirmationService> result = new List<StudentConfirmationService>();

            try
            {
                conn.Conn.Open();

                string query = @"
        SELECT SCS.*
        FROM StudentConfirmationServiceDetails SCS
        INNER JOIN Service S ON SCS.ServiceID = S.ServiceID
        INNER JOIN Users U ON S.UserID = U.UserID
        WHERE U.StudentStatus = 'Active' 
          AND U.Gmail LIKE '%' + @Username + '%@gmail.com'
          AND S.ServiceTypeID = 3;";

                using (SqlCommand command = new SqlCommand(query, conn.Conn))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read data from columns and create a StudentConfirmationService object
                            string confirmationID = reader["ConfirmationID"].ToString();
                            string serviceID = reader["ServiceID"].ToString();
                            decimal fee = Convert.ToDecimal(reader["Fee"]);
                            string major = reader["Major"].ToString();
                            string confirmationType = reader["ConfirmationType"].ToString();
                            string phoneNumber = reader["PhoneNumber"].ToString();
                            string fileAttached = reader["FileAttached"].ToString();
                            DateTime registrationDate = Convert.ToDateTime(reader["RegistrationDate"]);
                            string description = reader["Description"].ToString();
                            string deliveryMethod = reader["DeliveryMethod"].ToString();
                            string resultDeliveryMethod = reader["ResuiltDeliveryMethod"].ToString();

                            StudentConfirmationService studentConfirmationService = new StudentConfirmationService(
                                confirmationID, serviceID, fee, major, confirmationType, phoneNumber, fileAttached,
                                registrationDate, description, deliveryMethod, resultDeliveryMethod);

                            result.Add(studentConfirmationService);
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
