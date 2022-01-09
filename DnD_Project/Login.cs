using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DnD_Project
{
    public static class Login //Login Class 
    {
        //Global Vars
        private static string username = "";
        private static string password = "";
        private static string user_id = "";
        private static string user_role = "";

        public static string User_Name
        {
            get { return username; }
            set { username = value; }
        }
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
        public static string User_ID
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public static string User_Role
        {
            get { return user_role; }
            set { user_role = value; }
        }
    }
    
    public class User //User Class
    {
        private string id;
        private string username;
        private string password;
        private string role;
        private string temp_password;
        private string temp_username;
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Temp_Username { get; set; }
        public string Temp_Password { get; set; }
        public User()
        {
        }
        public User(string id, string username, string password, string role, string temp_username, string temp_password)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.role = role;
            this.temp_username = temp_username;
            this.temp_password = temp_password;
        }
        public User U_Login(string username, string password)
        {
            User u = new User();
            string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD"; // Connection String to the db
            string SelectUser = "Select Username, Password, User_ID, User_Role from [DnD].[dbo].[Users] where Username = @User_Name and Password = @password"; //Select query at Users Table
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(SelectUser, connection);
                command.Parameters.Add("@User_Name", SqlDbType.VarChar, 50).Value = Login.User_Name;
                command.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = Login.Password;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0},{1},{2},{3}", reader["User_ID"], reader["Username"], reader["Password"], reader["User_Role"]));
                        u.Temp_Username = String.Format("{0}", reader["Username"]);
                        u.Temp_Password = String.Format("{0}", reader["Password"]);
                        u.ID = String.Format("{0}", reader["User_ID"]);
                        u.Role = String.Format("{0}", reader["User_Role"]);
                    }
                }
                finally
                {
                    reader.Close();
                }
                return u;
            }

        }
    }
}