using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class StatisticalDAO
    {
        connect conn = new connect();
        public StatisticalDAO()
        {

        }
        public List<Statistical> GetStatisticals()
        {
            List<Statistical> listS = new List<Statistical>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "\r\nSELECT \r\n    S.Quantity,\r\n    I.RegistrationDate,\r\n    CASE \r\n        WHEN S.ServiceTypeID = 1 THEN 'Information Change Service'\r\n\r\n    END AS ServiceTypeDescription\r\nFROM [StudentOnlineServiceSystem].[dbo].[Service] S\r\nLEFT JOIN [StudentOnlineServiceSystem].[dbo].[InformationChangeServiceDetail] I ON S.ServiceID = I.ServiceID\r\nWHERE S.ServiceTypeID = 1\r\n\r\nUNION ALL\r\n\r\nSELECT \r\n    S.Quantity,\r\n    T.RegistrationDate,\r\n    CASE \r\n\r\n        WHEN S.ServiceTypeID = 2 THEN 'Tuition Reduction Service'\r\n\r\n    END AS ServiceTypeDescription\r\nFROM [StudentOnlineServiceSystem].[dbo].[Service] S\r\nLEFT JOIN [StudentOnlineServiceSystem].[dbo].[TuitionReductionServiceDetails] T ON S.ServiceID = T.ServiceID\r\nWHERE S.ServiceTypeID = 2\r\n\r\nUNION ALL\r\n\r\nSELECT \r\n    S.Quantity,\r\n    C.RegistrationDate,\r\n    CASE \r\n\r\n        WHEN S.ServiceTypeID = 3 THEN 'Student Confirmation Service'\r\n    END AS ServiceTypeDescription\r\nFROM [StudentOnlineServiceSystem].[dbo].[Service] S\r\nLEFT JOIN [StudentOnlineServiceSystem].[dbo].[StudentConfirmationServiceDetails] C ON S.ServiceID = C.ServiceID\r\nWHERE S.ServiceTypeID = 3;\r\n\r\n";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string quantity = reader["Quantity"].ToString();
                    string registrationDate = reader["RegistrationDate"].ToString();
                    string description = reader["ServiceTypeDescription"].ToString();
                    Statistical statistical = new Statistical( quantity, registrationDate, description);
                    listS.Add(statistical);
                }
            }
            return listS;
        }
        public List<Statistical> GetStatisticalsSum()
        {
            List<Statistical> listS = new List<Statistical>();
            SqlCommand command = new SqlCommand();
            conn.Conn.Open();
            command.Connection = conn.Conn;
            string query = "SELECT     " +
                "Month,   " +
                " ISNULL([Information Change Service], 0) AS [Information Change Service],   " +
                "ISNULL([Tuition Reduction Service], 0) AS [Tuition Reduction Service],   " +
                " ISNULL([Student Confirmation Service], 0) AS [Student Confirmation Service] FROM (   " +
                "SELECT        " +
                "DATENAME(MONTH, I.RegistrationDate) AS Month,        " +
                "'Information Change Service' AS ServiceTypeDescription,        " +
                "SUM(S.Quantity) AS Quantity    " +
                "FROM [StudentOnlineServiceSystem].[dbo].[Service] S    " +
                "LEFT JOIN [StudentOnlineServiceSystem].[dbo].[InformationChangeServiceDetail] I ON S.ServiceID = I.ServiceID    " +
                "WHERE S.ServiceTypeID = 1    " +
                "GROUP BY DATENAME(MONTH, I.RegistrationDate)    " +
                "UNION ALL   " +
                "SELECT        " +
                " DATENAME(MONTH, T.RegistrationDate) AS Month,       " +
                " 'Tuition Reduction Service' AS ServiceTypeDescription,      " +
                " SUM(S.Quantity) AS Quantity  " +
                " FROM [StudentOnlineServiceSystem].[dbo].[Service] S   " +
                "LEFT JOIN [StudentOnlineServiceSystem].[dbo].[TuitionReductionServiceDetails] T ON S.ServiceID = T.ServiceID   " +
                " WHERE S.ServiceTypeID = 2    " +
                "GROUP BY DATENAME(MONTH, T.RegistrationDate)    " +
                "UNION ALL   " +
                "SELECT        " +
                "DATENAME(MONTH, C.RegistrationDate) AS Month,        " +
                "'Student Confirmation Service' AS ServiceTypeDescription,       " +
                "SUM(S.Quantity) AS Quantity    " +
                "FROM [StudentOnlineServiceSystem].[dbo].[Service] S    " +
                "LEFT JOIN [StudentOnlineServiceSystem].[dbo].[StudentConfirmationServiceDetails] C ON S.ServiceID = C.ServiceID    " +
                "WHERE S.ServiceTypeID = 3    " +
                "GROUP BY DATENAME(MONTH, C.RegistrationDate)) AS PivotData PIVOT (    SUM(Quantity)    " +
                "FOR ServiceTypeDescription IN ([Information Change Service], [Tuition Reduction Service], [Student Confirmation Service])) AS PivotTable ORDER BY CONVERT(DATETIME, '1 ' + Month + ' 2000', 100);";
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string month = reader["Month"].ToString();
                    string infc = reader["Information Change Service"].ToString();
                    string td = reader["Tuition Reduction Service"].ToString();
                    string sc = reader["Student Confirmation Service"].ToString();
                    Statistical statistical = new Statistical(month, infc, td,sc);
                    listS.Add(statistical);
                }
            }
            return listS;
        }
    }
}
