using System;
using System.Collections.Generic;
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

        }
        protected void LogOut_Button(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}