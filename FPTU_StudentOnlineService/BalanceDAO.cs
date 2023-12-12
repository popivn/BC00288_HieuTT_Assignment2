using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FTU_StudentOnlineService
{
    internal class BalanceDAO
    {
        private connect conn = new connect();

        public BalanceDAO()
        {

        }

        public List<Balance> GetBalances()
        {
            List<Balance> balances = new List<Balance>();

            try
            {
                SqlCommand command = new SqlCommand();
                conn.Conn.Open();
                command.Connection = conn.Conn;
                string query = "SELECT * FROM AccountBalance";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string balanceID = reader["BalanceID"].ToString();
                        string userID = reader["UserID"].ToString();
                        decimal currentBalance = Convert.ToDecimal(reader["CurrentBalance"]);

                        Balance balance = new Balance(balanceID, userID, currentBalance);
                        balances.Add(balance);
                    }
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Conn.Close();
            }

            return balances;
        }

        public void UpdateBalance(string userID, decimal newBalance)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = $"UPDATE AccountBalance SET CurrentBalance = {newBalance} WHERE UserID = {userID}";
                command.CommandText = query;
                command.ExecuteNonQuery();
                Console.WriteLine($"Balance updated for UserID {userID}. New balance: {newBalance}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Conn.Close();
            }
        }
        public void AddBalance(string balanceID, string userID, decimal initialBalance)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                conn.Conn.Open();
                command.Connection = conn.Conn;

                string query = $"INSERT INTO AccountBalance (BalanceID, UserID, CurrentBalance) VALUES ({balanceID},{userID}, {initialBalance})";
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Conn.Close();
            }
        }
    }
}
