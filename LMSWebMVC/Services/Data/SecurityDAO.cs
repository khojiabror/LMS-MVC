using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using LMSWebMVC.Models;

namespace LMSWebMVC.Services.Data
{
    public class SecurityDAO
    {
        //connectString to the database
        string connectionString = "Data Source=10.10.10.3;Initial Catalog=DBLMS;User ID=LMSuser;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        internal bool FindByUser(UserModel user)
        {
            //if(user.Username=="Admin" && user.Password == "Secret")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            bool success = false;

            string queryString = "SELECT * FROM USERS WHERE username=@Username AND password=@Password";

            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@Username", System.Data.SqlDbType.VarChar, 50).Value = user.Username;
                command.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 100).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                    reader.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

        }
    }
}