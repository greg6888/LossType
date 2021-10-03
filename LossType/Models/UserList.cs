using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LossType.Models
{
    public class UserList
    {
        public List<User> userList = new List<User>();
        public bool CheckUsers(string username, string password)
        {
            bool checkValue = false;
            string connection = "Server=interview-testing-server.database.windows.net; Database=Interview; User Id=TestLogin; Password=5D9ej2G64s3sd^;";    //ConfigurationManager.AppSettings["LossTypeConnect"];
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    SqlCommand command = new SqlCommand(
                      "select * from Users where UserName='" + username + "' and Password='" +password +"'",
                      conn);
                    conn.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        checkValue = true;
                    }
                }
                finally { conn.Close(); }
                return checkValue;
            }
        }
    }
}