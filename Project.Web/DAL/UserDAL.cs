using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Web.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Project.Web.DAL
{
    public class UserDAL : IUserDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["cardsConn"].ConnectionString;
        private const string SQL_UserExists = "select count(userName) as 'count' from users where userName = @userName";
        private const string SQL_CorrectPW = "SELECT user_pw FROM users where userName = @userName";
        private const string SQL_QueryUserInfo = "SELECT * FROM users where userName = @userName";



        public bool UserExists(string userName)
        {            
            int recordCount = 0;
            bool userNameInDB = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(SQL_UserExists, conn);
                    cmd.Parameters.AddWithValue("@userName", userName);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if(reader.Read())
                    {
                        recordCount = Convert.ToInt32(reader["count"]);
                        if(recordCount == 1)
                        {
                            userNameInDB = true;                            
                        }
                    }                    
                }
            }
            catch
            {
                throw;
            }
            return userNameInDB;
        }



        public bool CorrectPW(string userName, string passWord)
        {
            bool pwCorrect = false;
            string pwInDB = "";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_CorrectPW, conn);
                    cmd.Parameters.AddWithValue("@userName", userName);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        pwInDB = Convert.ToString(reader["user_pw"]);
                        if(pwInDB == passWord)
                        {
                            pwCorrect = true;
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
            return pwCorrect;
        }

       

        bool IUserDAL.VerifyUserNameAndPW(string userName, string passWord)
        {
            bool accessIsGranted = false;
            bool userNameVerified = UserExists(userName);
            

            if(userNameVerified == true)
            {
                bool pwVerified = CorrectPW(userName, passWord);
                if (pwVerified == true)
                {
                    accessIsGranted = true;
                }              
            }
            return accessIsGranted;
        }
    }
}