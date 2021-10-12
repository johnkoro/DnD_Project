using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace DnD_Project
{
    public partial class Campaigns2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //Populating a DataTable from database.
                DataTable dt = this.GetData();

                //Building an HTML string.
                StringBuilder html = new StringBuilder();

                //Table start.
                html.Append("<table border = '1'>");

                //Building the Header row.
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<th>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
                html.Append("</tr>");

                //Building the Data rows.
                foreach (DataRow row in dt.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataColumn column in dt.Columns)
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                    html.Append("</tr>");
                }

                //Table end.
                html.Append("</table>");

                //Append the HTML string to Placeholder.
                // PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
            }
        }
        private DataTable GetData()
        {
            string ConnectionString = "Data Source=DESKTOP-54MBNCC;User ID=sa; Password=admin1!;Initial Catalog=DnD"; // Connection String to the db
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand selectcampaign = new SqlCommand("Select Campaign_Name as 'Campaign Name',DM from [DnD].[dbo].[Campaign]"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        selectcampaign.Connection = con;
                        sda.SelectCommand = selectcampaign;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            Campaigns.DataSource = dt;
                            Campaigns.DataBind();
                            return dt;
                        }
                    }
                }
            }
        }

    }
}