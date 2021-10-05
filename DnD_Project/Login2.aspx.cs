using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DnD_Project
{
    public partial class Login2 : System.Web.UI.Page
    {
        public string Error = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            div1.Visible = false;

        }
        protected void B1(object sender, EventArgs e)
        {

            Login.User_Name = Request.Form["Username"];
            Login.Password = Request.Form["loginPassword"];


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
                Error = "Wrong Credentials";
                div1.Visible = true;
            }

        }
        protected void B2(object sender, EventArgs e)
        {
            div1.Visible = false;
        }
    }
}