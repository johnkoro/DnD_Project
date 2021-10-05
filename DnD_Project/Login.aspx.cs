using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DnD_Project
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public enum MessageType { Success, Error, Info, Warning };
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ShowMessage(string Message, MessageType type)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }
        
        

        protected void B1(object sender, EventArgs e)
        {
            Login.User_Name = Request.Form["UName"];
            Login.Password = Request.Form["password"];
            

            User u = new User();
            u.U_Login(Login.User_Name, Login.Password);
            string temp_username = u.U_Login(Login.User_Name, Login.Password).Temp_Username;
            string temp_password = u.U_Login(Login.User_Name, Login.Password).Temp_Password;
            string u_role = u.U_Login(Login.User_Name, Login.Password).Role;
            if ((Login.User_Name == temp_username) && (Login.Password == temp_password))
            {
                if (u_role == "1")
                {
                    Response.Redirect("DM_Home_Page.aspx");
                }
                
            }
            else
            {
                ShowMessage("A problem has occurred while submitting data", MessageType.Error);
            }
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {



        }
        
    }

    
}