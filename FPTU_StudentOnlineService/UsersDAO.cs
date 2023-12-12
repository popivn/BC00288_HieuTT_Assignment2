using FTU_StudentOnlineService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class UsersDAO
    {
        connect conn = new connect();
        public UsersDAO()
        {

        }
        public List<Users> getUsers()
        {
            List<Users> listU = new List<Users>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "SELECT *FROM Users";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string userID = reader["UserID"].ToString();
                    string roletypeID = reader["RoleTypeID"].ToString();
                    string name = reader["Name"].ToString();
                    string password = reader["Password"].ToString();
                    string phonenumber = reader["PhoneNumber"].ToString();
                    string gmail = reader["Gmail"].ToString();
                    string studentstatus = reader["StudentStatus"].ToString();
                    string major = reader["Major"].ToString();
                    Users users = new Users(userID, roletypeID, name, password, phonenumber, gmail, studentstatus, major);
                    listU.Add(users);
                }
            }

            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return listU;
        }
        public List<Users> getAllUsers()
        {
            List<Users> listU = new List<Users>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "SELECT *FROM Users ";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string userID = reader["UserID"].ToString();
                    string roletypeID = reader["RoleTypeID"].ToString();
                    string name = reader["Name"].ToString();
                    string password = reader["Password"].ToString();
                    string phonenumber = reader["PhoneNumber"].ToString();
                    string gmail = reader["Gmail"].ToString();
                    string studentstatus = reader["StudentStatus"].ToString();
                    string major = reader["Major"].ToString();
                    Users users = new Users(userID, roletypeID, name, password, phonenumber, gmail, studentstatus, major);
                    listU.Add(users);
                }
            }

            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return listU;
        }

        public void addUsers(Users U)
        {
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"insert into Users(UserID,RoleTypeID,Name,Password,PhoneNumber,Gmail,StudentStatus,Major)" + " values(@UserID,@RoleTypeID,@Name,@Password,@PhoneNumber,@Gmail,@StudentStatus,@Major)";
            command.CommandText = query;
            command.Parameters.AddWithValue("@UserID", U.userID);
            command.Parameters.AddWithValue("@RoleTypeID", U.roletypeID);
            command.Parameters.AddWithValue("@Name", U.name);
            command.Parameters.AddWithValue("@Password", U.password);
            command.Parameters.AddWithValue("@PhoneNumber", U.phonenumber);
            command.Parameters.AddWithValue("@Gmail", U.gmail);
            command.Parameters.AddWithValue("@StudentStatus", U.studentStatus);
            command.Parameters.AddWithValue("@Major", U.major);
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }
        public void RemoveUsers(string UserID)
        {
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"DELETE FROM Users WHERE UserID=@UserID";
            command.CommandText = query;
            command.Parameters.AddWithValue("@UserID", UserID);
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }
        public void UpdateUsers(Users U)
        {
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"update  Users set UserID=@UserID, RoleTypeID=@RoleTypeID,Name = @Name, Password=@Password, PhoneNumber=@PhoneNumber, Gmail=@Gmail,StudentStatus=@StudentStatus, Major=@Major where  UserID=@UserID  ";

            command.CommandText = query;
            command.Parameters.AddWithValue("@UserID", U.userID);
            command.Parameters.AddWithValue("@RoleTypeID", U.roletypeID);
            command.Parameters.AddWithValue("@Name", U.name);
            command.Parameters.AddWithValue("@Password", U.password);
            command.Parameters.AddWithValue("@PhoneNumber", U.phonenumber);
            command.Parameters.AddWithValue("@Gmail", U.gmail);
            command.Parameters.AddWithValue("@StudentStatus", U.studentStatus);
            command.Parameters.AddWithValue("@Major", U.major);
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }

        public List<Users> SearchUsersByEmail(string emailSubstring)
        {
            List<Users> resultList = new List<Users>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;

            string query = "SELECT * FROM Users WHERE Gmail LIKE @EmailSubstring AND StudentStatus = 'Active'";
            command.CommandText = query;
            command.Parameters.AddWithValue("@EmailSubstring", "%" + emailSubstring + "%");

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string userID = reader["UserID"].ToString();
                    string roletypeID = reader["RoleTypeID"].ToString();
                    string name = reader["Name"].ToString();
                    string password = reader["Password"].ToString();
                    string phonenumber = reader["PhoneNumber"].ToString();
                    string gmail = reader["Gmail"].ToString();
                    string studentstatus = reader["StudentStatus"].ToString();
                    string major = reader["Major"].ToString();

                    Users user = new Users(userID, roletypeID, name, password, phonenumber, gmail, studentstatus, major);
                    resultList.Add(user);
                }
            }

            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return resultList;
        }

    }
}
