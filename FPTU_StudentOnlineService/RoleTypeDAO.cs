using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class RoleTypeDAO
    {
        connect conn = new connect();
        public List<RoleType>GetRoles()
        {
            List<RoleType> listR = new List<RoleType>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "SELECT * FROM RoleType";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string userID = reader["RoleTypeID"].ToString();
                    string roletypeID = reader["RoleName"].ToString();
                    string name = reader["Description"].ToString();

                    RoleType role = new RoleType(userID, roletypeID, name);
                    listR.Add(role);
                }
            }
            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return listR;
        }
        public void UpdateUserRoleType(string userID, string newRoleTypeID)
        {
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;

            // Use parameters to prevent SQL injection
            string query = "UPDATE Users SET RoleTypeID = @NewRoleTypeID WHERE UserID = @UserID";
            command.CommandText = query;

            // Add parameters
            command.Parameters.AddWithValue("@NewRoleTypeID", newRoleTypeID);
            command.Parameters.AddWithValue("@UserID", userID);

            // Execute the update query
            command.ExecuteNonQuery();

            conn.Conn.Close();
            command.Dispose();
        }
    }
}
