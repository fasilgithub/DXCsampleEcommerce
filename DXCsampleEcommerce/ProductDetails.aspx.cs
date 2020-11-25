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
    public partial class WebForm4 : System.Web.UI.Page
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

              string productId = Request.QueryString["ProductId"];
              OleDbConnection con = new OleDbConnection(connectionString);
              string query = "select * from Product where ProductId =" + productId;
              OleDbCommand cmd = new OleDbCommand(query, con);
              OleDbDataAdapter olda = new OleDbDataAdapter(cmd);
              con.Open();
              olda.SelectCommand = cmd;
              DataSet ds = new DataSet();
              olda.Fill(ds);
              DataList1.DataSource = ds;
              DataList1.DataBind();
              con.Close();


            }
        
    }
}