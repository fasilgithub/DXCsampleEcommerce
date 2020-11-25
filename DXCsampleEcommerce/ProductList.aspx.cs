using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace DXCsampleEcommerce
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        
        {

                if (!IsPostBack)
                {
                    RefreshData();
                }
        }

            public void RefreshData()
            {

             string categoryId = Request.QueryString["CategoryID"];
             OleDbConnection con = new OleDbConnection(connectionString);
             string query = "select * from Product where CategoryID=" + categoryId;
             con.Open();
             OleDbCommand cmd = new OleDbCommand(query, con);
             OleDbDataAdapter olda = new OleDbDataAdapter(cmd);
             DataTable dt = new DataTable();
             olda.Fill(dt);
             GridView3.DataSource = dt;
             GridView3.DataBind();
             con.Close();

            }
        
  
    }
}