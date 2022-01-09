using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DnD_Project
{
    public partial class DM_Home_Page : System.Web.UI.Page
    {
        
        public string Username = Login.User_Name;
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            div0.Visible = false;
            div1.Visible = false;
            div2.Visible = false;
            div3.Visible = false;
            div4.Visible = false;
            div5.Visible = false;
            div6.Visible = false;
            div7.Visible = false;
            div8.Visible = false;
            div9.Visible = false;
            div10.Visible = false;
            div11.Visible = false;
            div12.Visible = false;
            div13.Visible = false;
            div14.Visible = false;
            div15.Visible = false;
            div16.Visible = false;
            div17.Visible = false;
            div18.Visible = false;
            div19.Visible = false;
            div20.Visible = false;
            div21.Visible = false;
            div22.Visible = false;
            div23.Visible = false;
            div24.Visible = false;
            div25.Visible = false;
            div26.Visible = false;
            div27.Visible = false;
            div28.Visible = false;
            div29.Visible = false;
            div30.Visible = false;
            div31.Visible = false;
            div32.Visible = false;
            div33.Visible = false;
            div34.Visible = false;
            div35.Visible = false;
            div36.Visible = false;
            div37.Visible = false;
            div38.Visible = false;
            div39.Visible = false;
            div40.Visible = false;
            div41.Visible = false;
            div42.Visible = false;
            div43.Visible = false;
            div44.Visible = false;
            div45.Visible = false;
            div46.Visible = false;
            div47.Visible = false;
            div48.Visible = false;
            div49.Visible = false;
            div50.Visible = false;
            div51.Visible = false;
            div52.Visible = false;
            div53.Visible = false;
            div54.Visible = false;
            div55.Visible = false;
            div56.Visible = false;
            
            
    }
        protected void LogOut_Button(object sender, EventArgs e)
        {
            Response.Redirect("Login2.aspx");
        }
        protected void CampaingButton(object sender, EventArgs e)
        {

        }
        protected void D12(object sender, EventArgs e)
        {
            tb1.Text = "";
            Results.Text = "";
            int multiplier = Int32.Parse(multy.Value);
            int result = 0;
            if (multiplier == 1)
            {
                Timer.Enabled = true;
                div0.Visible = true;
            }
            else
            {
                Random rd = new Random();
                for (int i = 0; i < multiplier; i++)
                {

                    int rand = rd.Next(1, 13);
                    result = result + rand;
                    res.Visible = false;
                    resu.Value = result.ToString();
                    Timer12.Enabled = true;
                }
                Dice_Log D = new Dice_Log();
                Results.Text = Username + " rolled a " + result.ToString() + " on " + multiplier + "d12";
                D.Add_Log(Results.Text);
                string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
                SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
                string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
                string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
                SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(trun, connection);
                    SqlCommand command2 = new SqlCommand(Select, connection);
                    connection.Open();
                    
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    Select2.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                        }
                        connection.Close();
                    }
                }
            }

        }
        protected void D4(object sender, EventArgs e)
        {
            Results.Text = "";
            tb1.Text = "";
            int multiplier = Int32.Parse(multy.Value);
            int result=0;
            if (multiplier == 1)
            {
                Timerd4.Enabled = true;
                div13.Visible = true;
            }
            else
            {
                Random rd = new Random();
                for (int i=0; i<multiplier; i++)
                {
                    
                    int rand = rd.Next(1, 5);
                    result = result + rand;
                    res.Visible = false;
                    resu.Value = result.ToString();
                    Timer12.Enabled = true;
                }
                Dice_Log D = new Dice_Log();
                Results.Text = Username + " rolled a " + result.ToString() + " on " + multiplier + "d4";
                D.Add_Log(Results.Text);
                string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
                SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
                string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
                string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
                SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(trun, connection);
                    SqlCommand command2 = new SqlCommand(Select, connection);
                    connection.Open();
                    
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    Select2.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                        }
                        connection.Close();
                    }
                }
            }
            

        }
        protected void D6(object sender, EventArgs e)
        {
            Results.Text = "";
            tb1.Text = "";
            int multiplier = Int32.Parse(multy.Value);
            int result = 0;
            if (multiplier == 1)
            {
                Timerd6.Enabled = true;
                div18.Visible = true;
            }
            else
            {
                Random rd = new Random();
                for (int i = 0; i < multiplier; i++)
                {

                    int rand = rd.Next(1, 7);
                    result = result + rand;
                    res.Visible = false;
                    resu.Value = result.ToString();
                    Timer12.Enabled = true;
                }
                Dice_Log D = new Dice_Log();
                Results.Text = Username + " rolled a " + result.ToString() + " on " + multiplier + "d6";
                D.Add_Log(Results.Text);
                string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
                SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
                string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
                string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
                SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(trun, connection);
                    SqlCommand command2 = new SqlCommand(Select, connection);
                    connection.Open();
                    
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    Select2.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                        }
                        connection.Close();
                    }
                }
            }

        }
        protected void D10(object sender, EventArgs e)
        {
            Results.Text = "";
            tb1.Text = "";
            int multiplier = Int32.Parse(multy.Value);
            int result = 0;
            if (multiplier == 1)
            {
                Timerd8.Enabled = true;
                div25.Visible = true;
            }
            else
            {
                Random rd = new Random();
                for (int i = 0; i < multiplier; i++)
                {

                    int rand = rd.Next(1, 11);
                    result = result + rand;
                    res.Visible = false;
                    resu.Value = result.ToString();
                    Timer12.Enabled = true;
                }
                Dice_Log D = new Dice_Log();
                Results.Text = Username + " rolled a " + result.ToString() + " on " + multiplier + "d10";
                D.Add_Log(Results.Text);
                string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
                SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
                string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
                string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
                SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(trun, connection);
                    SqlCommand command2 = new SqlCommand(Select, connection);
                    connection.Open();
                    
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    Select2.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                        }
                        connection.Close();
                    }
                }
            }

        }
        protected void D20(object sender, EventArgs e)
        {
            Results.Text = "";
            tb1.Text = "";
            int multiplier = Int32.Parse(multy.Value);
            int result = 0;
            if (multiplier == 1)
            {
                Timerd10.Enabled = true;
                div36.Visible = true;
            }
            else
            {
                Random rd = new Random();
                for (int i = 0; i < multiplier; i++)
                {

                    int rand = rd.Next(1, 21);
                    result = result + rand;
                    res.Visible = false;
                    resu.Value = result.ToString();
                    Timer12.Enabled = true;
                }
                Dice_Log D = new Dice_Log();
                Results.Text = Username + " rolled a " + result.ToString() + " on " + multiplier + "d20";
                D.Add_Log(Results.Text);
                string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
                SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
                string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
                string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
                SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(trun, connection);
                    SqlCommand command2 = new SqlCommand(Select, connection);
                    connection.Open();
                    
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    Select2.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                        }
                        connection.Close();
                    }
                }
            }


        }
        protected void Timer1(object sender, EventArgs e)
        {
            tb1.Text = "";
            Results.Text = "";
            Random rd = new Random();
            int rand = rd.Next(1, 12);
            div0.Visible = false;
            if (rand == 1)
            {
                div1.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 2)
            {
                div2.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 3)
            {
                div3.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 4)
            {
                div4.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 5)
            {
                div5.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 6)
            {
                div6.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 7)
            {
                div7.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 8)
            {
                div8.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 9)
            {
                div9.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 10)
            {
                div10.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 11)
            {
                div11.Visible = true;
                Timer3.Enabled = true;
            }
            else if (rand == 12)
            {
                div12.Visible = true;
                Timer3.Enabled = true;
            }
            Timer.Enabled = false;
            Dice_Log D = new Dice_Log();
            Results.Text = Username + " rolled a " + rand.ToString() + " on 1d12";
            D.Add_Log(Results.Text);
            string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
            string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
            string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
            SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(trun, connection);
                SqlCommand command2 = new SqlCommand(Select, connection);
                connection.Open();
                
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                DataTable dt = new DataTable();
                Select2.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                    }
                    connection.Close();
                }
            }
        }
        protected void Timer2(object sender, EventArgs e)
        {
            div1.Visible = false;
            div2.Visible = false;
            div3.Visible = false;
            div4.Visible = false;
            div5.Visible = false;
            div6.Visible = false;
            div7.Visible = false;
            div8.Visible = false;
            div9.Visible = false;
            div10.Visible = false;
            div11.Visible = false;
            div12.Visible = false;
            Timer3.Enabled = false;
            
        }
        protected void Timer4(object sender, EventArgs e)
        {
            tb1.Text = "";
            Results.Text = "";
            Random rd = new Random();
            int rand = rd.Next(1, 4);
            div13.Visible = false;
            if (rand == 1)
            {
                div14.Visible = true;
                Timerd5.Enabled = true;
            }
            else if (rand == 2)
            {
                div15.Visible = true;
                Timerd5.Enabled = true;
            }
            else if (rand == 3)
            {
                div16.Visible = true;
                Timerd5.Enabled = true;
            }
            else if (rand == 4)
            {
                div17.Visible = true;
                Timerd5.Enabled = true;
            }
            Timerd4.Enabled = false;
            Dice_Log D = new Dice_Log();
            Results.Text = Username + " rolled a " + rand.ToString() + " on 1d4";
            D.Add_Log(Results.Text);
            string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
            string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
            string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
            SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(trun, connection);
                SqlCommand command2 = new SqlCommand(Select, connection);
                connection.Open();
                
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                DataTable dt = new DataTable();
                Select2.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                    }
                    connection.Close();
                }
            }
        }
        protected void Timer5(object sender, EventArgs e)
        {
            div14.Visible = false;
            div15.Visible = false;
            div16.Visible = false;
            div17.Visible = false;
            Timerd5.Enabled = false;

        }
        protected void Timer6(object sender, EventArgs e)
        {
            tb1.Text = "";
            Results.Text = "";
            Random rd = new Random();
            int rand = rd.Next(1, 6);
            div18.Visible = false;
            if (rand == 1)
            {
                div19.Visible = true;
                Timerd7.Enabled = true;
            }
            else if (rand == 2)
            {
                div20.Visible = true;
                Timerd7.Enabled = true;
            }
            else if (rand == 3)
            {
                div21.Visible = true;
                Timerd7.Enabled = true;
            }
            else if (rand == 4)
            {
                div22.Visible = true;
                Timerd7.Enabled = true;
            }
            else if (rand == 5)
            {
                div23.Visible = true;
                Timerd7.Enabled = true;
            }
            else if (rand == 6)
            {
                div24.Visible = true;
                Timerd7.Enabled = true;
            }
            Timerd6.Enabled = false;
            Dice_Log D = new Dice_Log();
            Results.Text = Username + " rolled a " + rand.ToString() + " on 1d6";
            D.Add_Log(Results.Text);
            string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
            string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
            string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
            SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(trun, connection);
                SqlCommand command2 = new SqlCommand(Select, connection);
                connection.Open();

                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                DataTable dt = new DataTable();
                Select2.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                    }
                    connection.Close();
                }
            }

        }
        protected void Timer7(object sender, EventArgs e)
        {
            div18.Visible = false;
            div19.Visible = false;
            div20.Visible = false;
            div21.Visible = false;
            div22.Visible = false;
            div23.Visible = false;
            Timerd7.Enabled = false;

        }
        protected void Timer8(object sender, EventArgs e)
        {
            tb1.Text = "";
            Results.Text = "";
            Random rd = new Random();
            int rand = rd.Next(1, 10);
            div25.Visible = false;
            if (rand == 1)
            {
                div26.Visible = true;
                Timerd9.Enabled = true;
            }
            else if (rand == 2)
            {
                div27.Visible = true;
                Timerd9.Enabled = true;
            }
            else if (rand == 3)
            {
                div28.Visible = true;
                Timerd9.Enabled = true;
            }
            else if (rand == 4)
            {
                div29.Visible = true;
                Timerd9.Enabled = true;
            }
            else if (rand == 5)
            {
                div30.Visible = true;
                Timerd9.Enabled = true;
            }
            else if (rand == 6)
            {
                div31.Visible = true;
                Timerd9.Enabled = true;
            }
            else if (rand == 7)
            {
                div32.Visible = true;
                Timerd9.Enabled = true;
            }
            else if (rand == 8)
            {
                div33.Visible = true;
                Timerd9.Enabled = true;
            }
            else if (rand == 9)
            {
                div34.Visible = true;
                Timerd9.Enabled = true;
            }
            else if (rand == 10)
            {
                div35.Visible = true;
                Timerd9.Enabled = true;
            }
            Timerd8.Enabled = false;
            Dice_Log D = new Dice_Log();
            Results.Text = Username + " rolled a " + rand.ToString() + " on 1d10";
            D.Add_Log(Results.Text);
            string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
            string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
            string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
            SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(trun, connection);
                SqlCommand command2 = new SqlCommand(Select, connection);
                connection.Open();
                
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                DataTable dt = new DataTable();
                Select2.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                    }
                    connection.Close();
                }
            }
        }
        protected void Timer9(object sender, EventArgs e)
        {
            tb1.Text = "";
            div26.Visible = false;
            div27.Visible = false;
            div28.Visible = false;
            div29.Visible = false;
            div30.Visible = false;
            div31.Visible = false;
            div32.Visible = false;
            div33.Visible = false;
            div34.Visible = false;
            div35.Visible = false;
            Timerd9.Enabled = false;

        }
        protected void Timer10(object sender, EventArgs e)
        {
            tb1.Text = "";
            Results.Text = "";
            Random rd = new Random();
            int rand = rd.Next(1, 20);
            div36.Visible = false;
            if (rand == 1)
            {
                div37.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 2)
            {
                div38.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 3)
            {
                div39.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 4)
            {
                div40.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 5)
            {
                div41.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 6)
            {
                div42.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 7)
            {
                div43.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 8)
            {
                div44.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 9)
            {
                div45.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 10)
            {
                div46.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 11)
            {
                div47.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 12)
            {
                div48.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 13)
            {
                div49.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 14)
            {
                div50.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 15)
            {
                div51.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 16)
            {
                div52.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 17)
            {
                div53.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 18)
            {
                div54.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 19)
            {
                div55.Visible = true;
                Timerd11.Enabled = true;
            }
            else if (rand == 20)
            {
                div56.Visible = true;
                Timerd11.Enabled = true;
            }
            Timerd10.Enabled = false;
            Dice_Log D = new Dice_Log();
            Results.Text = Username + " rolled a " + rand.ToString() + " on 1d20";
            D.Add_Log(Results.Text);
            string ConnectionString = "Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD";
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.6;User ID=masteruser; Password=admin;Initial Catalog=DnD");
            string trun = "Truncate table [DnD].[dbo].[Dice_temp]";
            string Select = "Insert into [DnD].[dbo].[Dice_temp] (id, Result) Select top 10 [id],[Result] from [DnD].[dbo].[Dice] order by id desc";
            SqlDataAdapter Select2 = new SqlDataAdapter("Select [Result] from [DnD].[dbo].[Dice_temp]", con);
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(trun, connection);
                SqlCommand command2 = new SqlCommand(Select, connection);
                connection.Open();
                
                command.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                DataTable dt = new DataTable();
                Select2.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        tb1.Text += dt.Rows[i].ItemArray[0].ToString() + Environment.NewLine;
                    }
                    connection.Close();
                }
            }
        }
        protected void Timer11(object sender, EventArgs e)
        {
            div37.Visible = false;
            div38.Visible = false;
            div39.Visible = false;
            div40.Visible = false;
            div41.Visible = false;
            div42.Visible = false;
            div43.Visible = false;
            div44.Visible = false;
            div45.Visible = false;
            div46.Visible = false;
            div47.Visible = false;
            div48.Visible = false;
            div49.Visible = false;
            div50.Visible = false;
            div51.Visible = false;
            div52.Visible = false;
            div53.Visible = false;
            div54.Visible = false;
            div55.Visible = false;
            div56.Visible = false;
            Timerd11.Enabled = false;

        }
        protected void Timer13(object sender, EventArgs e)
        {
            res.Visible = false;
        }
    }
}