using FTU_StudentOnlineService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class DepartmentDAO
    {
        connect conn = new connect();

        public DepartmentDAO()
        {
        }

        public List<Department> getDepartments()
        {
            List<Department> listD = new List<Department>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "SELECT * FROM RegistrationDepartments";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string departmentID = reader["DepartmentID"].ToString();
                    string departmentName = reader["DepartmentName"].ToString();
                    string contactEmail = reader["ContactEmail"].ToString();
                    string contactPhone = reader["ContactPhone"].ToString();
                    string location = reader["Location"].ToString();
                    string responsibilities = reader["Responsibilities"].ToString();

                    Department department = new Department(departmentID, departmentName, contactEmail, contactPhone, location, responsibilities);
                    listD.Add(department);
                }
            }

            conn.Conn.Close();
            command.Dispose();
            reader.Close();
            return listD;
        }

        public void addDepartment(Department department)
        {
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"INSERT INTO RegistrationDepartments(DepartmentID, DepartmentName, ContactEmail, ContactPhone, Location, Responsibilities) 
                             VALUES(@DepartmentID, @DepartmentName, @ContactEmail, @ContactPhone, @Location, @Responsibilities)";

            command.CommandText = query;
            command.Parameters.AddWithValue("@DepartmentID", department.departmentID);
            command.Parameters.AddWithValue("@DepartmentName", department.departmentName);
            command.Parameters.AddWithValue("@ContactEmail", department.contactEmail);
            command.Parameters.AddWithValue("@ContactPhone", department.contactPhone);
            command.Parameters.AddWithValue("@Location", department.location);
            command.Parameters.AddWithValue("@Responsibilities", department.responsibilities);
            command.ExecuteNonQuery();

            conn.Conn.Close();
        }

        public void updateDepartment(Department department)
        {
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = @"UPDATE RegistrationDepartments 
                             SET DepartmentName=@DepartmentName, ContactEmail=@ContactEmail, 
                                 ContactPhone=@ContactPhone, Location=@Location, 
                                 Responsibilities=@Responsibilities
                             WHERE DepartmentID=@DepartmentID";

            command.CommandText = query;
            command.Parameters.AddWithValue("@DepartmentID", department.departmentID);
            command.Parameters.AddWithValue("@DepartmentName", department.departmentName);
            command.Parameters.AddWithValue("@ContactEmail", department.contactEmail);
            command.Parameters.AddWithValue("@ContactPhone", department.contactPhone);
            command.Parameters.AddWithValue("@Location", department.location);
            command.Parameters.AddWithValue("@Responsibilities", department.responsibilities);
            command.ExecuteNonQuery();

            conn.Conn.Close();
        }

        public void deleteDepartment(string departmentID)
        {
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "DELETE FROM RegistrationDepartments WHERE DepartmentID=@DepartmentID";
            command.CommandText = query;
            command.Parameters.AddWithValue("@DepartmentID", departmentID);
            command.ExecuteNonQuery();
            conn.Conn.Close();
        }

    }
}
