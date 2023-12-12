using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FTU_StudentOnlineService
{
    internal class TuitionReductionServiceDAO
    {
        private connect conn = new connect();

        public TuitionReductionServiceDAO()
        {
        }

        public List<TuitionReductionService> GetTuitionReductionServices()
        {
            List<TuitionReductionService> listTRS = new List<TuitionReductionService>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;

            string query = @" SELECT TRS.*        FROM TuitionReductionServiceDetails TRS      INNER JOIN Service S ON TRS.ServiceID = S.ServiceID        INNER JOIN Users U ON S.UserID = U.UserID        WHERE U.StudentStatus = 'Active';";
            command.CommandText = query;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string reductionID = reader["ReductionID"].ToString();
                    string serviceID = reader["ServiceID"].ToString();
                    string course = reader["Course"].ToString();
                    decimal fee = Convert.ToDecimal(reader["Fee"]);
                    string certificate = reader["Certificate"].ToString();
                    string major = reader["Major"].ToString();
                    DateTime registrationDate = Convert.ToDateTime(reader["RegistrationDate"]);
                    string phoneNumber = reader["PhoneNumber"].ToString();
                    string deliveryMethod = reader["DeliveryMethod"].ToString();
                    string resultDeliveryMethod = reader["ResuiltDeliveryMethod"].ToString();

                    TuitionReductionService tuitionReductionService = new TuitionReductionService(
                        reductionID, serviceID, course, fee, certificate, major, registrationDate, phoneNumber, deliveryMethod, resultDeliveryMethod);

                    listTRS.Add(tuitionReductionService);
                }
            }

            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return listTRS;
        }

        public void AddTuitionReductionService(TuitionReductionService tuitionReductionService)
        {
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;

            string query = @"INSERT INTO TuitionReductionServiceDetails(ReductionID, ServiceID, Course, Fee, Certificate, Major, RegistrationDate, PhoneNumber, DeliveryMethod, ResuiltDeliveryMethod)" +
                            " VALUES(@ReductionID, @ServiceID, @Course, @Fee, @Certificate, @Major, @RegistrationDate, @PhoneNumber, @DeliveryMethod, @ResuiltDeliveryMethod)";

            command.CommandText = query;
            command.Parameters.AddWithValue("@ReductionID", tuitionReductionService.ReductionIDProp);
            command.Parameters.AddWithValue("@ServiceID", tuitionReductionService.ServiceIDProp);
            command.Parameters.AddWithValue("@Course", tuitionReductionService.CourseProp);
            command.Parameters.AddWithValue("@Fee", tuitionReductionService.FeeProp);
            command.Parameters.AddWithValue("@Certificate", tuitionReductionService.CertificateProp);
            command.Parameters.AddWithValue("@Major", tuitionReductionService.MajorProp);
            command.Parameters.AddWithValue("@RegistrationDate", tuitionReductionService.RegistrationDateProp);
            command.Parameters.AddWithValue("@PhoneNumber", tuitionReductionService.PhoneNumberProp);
            command.Parameters.AddWithValue("@DeliveryMethod", tuitionReductionService.DeliveryMethodProp);
            command.Parameters.AddWithValue("@ResuiltDeliveryMethod", tuitionReductionService.ResultDeliveryMethodProp);

            command.ExecuteNonQuery();
            conn.Conn.Close();
        }

        public void UpdateTuitionReductionService(TuitionReductionService tuitionReductionService)
        {
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;

            string query = @"UPDATE TuitionReductionServiceDetails SET " +
                            "ServiceID = @ServiceID, Course = @Course, Fee = @Fee, Certificate = @Certificate, Major = @Major, " +
                            "RegistrationDate = @RegistrationDate, PhoneNumber = @PhoneNumber, " +
                            "DeliveryMethod = @DeliveryMethod, ResuiltDeliveryMethod = @ResuiltDeliveryMethod " +
                            "WHERE ReductionID = @ReductionID";

            command.CommandText = query;
            command.Parameters.AddWithValue("@ReductionID", tuitionReductionService.ReductionIDProp);
            command.Parameters.AddWithValue("@ServiceID", tuitionReductionService.ServiceIDProp);
            command.Parameters.AddWithValue("@Course", tuitionReductionService.CourseProp);
            command.Parameters.AddWithValue("@Fee", tuitionReductionService.FeeProp);
            command.Parameters.AddWithValue("@Certificate", tuitionReductionService.CertificateProp);
            command.Parameters.AddWithValue("@Major", tuitionReductionService.MajorProp);
            command.Parameters.AddWithValue("@RegistrationDate", tuitionReductionService.RegistrationDateProp);
            command.Parameters.AddWithValue("@PhoneNumber", tuitionReductionService.PhoneNumberProp);
            command.Parameters.AddWithValue("@DeliveryMethod", tuitionReductionService.DeliveryMethodProp);
            command.Parameters.AddWithValue("@ResuiltDeliveryMethod", tuitionReductionService.ResultDeliveryMethodProp);

            command.ExecuteNonQuery();
            conn.Conn.Close();
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
        public List<TuitionReductionService> SearchTuitionReductionServicesByUsername(string username)
        {
            List<TuitionReductionService> result = new List<TuitionReductionService>();

            try
            {
                conn.Conn.Open();

                string query = @"
            SELECT TRS.*
            FROM TuitionReductionServiceDetails TRS
            INNER JOIN Service S ON TRS.ServiceID = S.ServiceID
            INNER JOIN Users U ON S.UserID = U.UserID
            WHERE U.StudentStatus = 'Active' 
              AND U.Gmail LIKE '%' + @Username + '%@gmail.com'
              AND S.ServiceTypeID = 2;";

                using (SqlCommand command = new SqlCommand(query, conn.Conn))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string reductionID = reader["ReductionID"].ToString();
                            string serviceID = reader["ServiceID"].ToString();
                            string course = reader["Course"].ToString();
                            decimal fee = Convert.ToDecimal(reader["Fee"]);
                            string certificate = reader["Certificate"].ToString();
                            string major = reader["Major"].ToString();
                            DateTime registrationDate = Convert.ToDateTime(reader["RegistrationDate"]);
                            string phoneNumber = reader["PhoneNumber"].ToString();
                            string deliveryMethod = reader["DeliveryMethod"].ToString();
                            string resultDeliveryMethod = reader["ResuiltDeliveryMethod"].ToString();

                            TuitionReductionService tuitionReductionService = new TuitionReductionService(
                                reductionID, serviceID, course, fee, certificate, major, registrationDate, phoneNumber, deliveryMethod, resultDeliveryMethod);

                            result.Add(tuitionReductionService);
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
