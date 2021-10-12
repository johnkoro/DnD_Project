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

        }
        protected void LogOut_Button(object sender, EventArgs e)
        {
            Response.Redirect("Login2.aspx");
        }
        protected void CampaingButton(object sender, EventArgs e)
        {

        }
        protected void D6(object sender, EventArgs e)
        {
            Timer.Enabled = true;
            div0.Visible = true;
            

        }
        protected void Timer1(object sender, EventArgs e)
        {
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
    }
}