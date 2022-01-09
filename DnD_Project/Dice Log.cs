using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DnD_Project
{
    public static class Results
    {
        private static string text = "";
        public static String Text
        {
            get { return text; }
            set { text = value; }
        }
    }
    public class Dice_Log
    {
        private int id;
        private string text;
        public string ID { get; set; }
        public string Text { get; set; }
        public Dice_Log()
        {

        }
        public Dice_Log (int id, string text)
        {
            this.id = id;
            this.text = text;
        }
        public Dice_Log Add_Log (string text)
        {
            Dice_Log D = new Dice_Log();
            string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
            string Insert = "Insert into [DnD].[dbo].[Dice] (Result) Values(@result)";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(Insert, connection);
                connection.Open();
                command.Parameters.Add("@result", SqlDbType.Text).Value = Results.Text;
                command.ExecuteNonQuery();
            }
            return D;
        }
        public Dice_Log Log ()
        {
            Dice_Log D = new Dice_Log();
            string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
            string trun = "Truncate [DnD].[dbo].[Dice_temp]";
            string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(trun, connection);
                SqlCommand command2 = new SqlCommand(Select, connection);
                connection.Open();
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            }
            return D;
            
        }
    }
}