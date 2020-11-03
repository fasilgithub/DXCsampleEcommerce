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
        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                refreshdata();
            }
        }

            public void refreshdata()
            {

                string ProductId = Request.QueryString["ProductId"];
            OleDbConnection con = new OleDbConnection(connStr);
            string query = "select * from Product where ProductId =" + ProductId;
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter olda = new OleDbDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //olda.Fill(dt);
          
            con.Open();
            //OleDbDataReader sdr = cmd.ExecuteReader();
            olda.SelectCommand = cmd;
            DataSet ds = new DataSet();
            olda.Fill(ds);



            DataList1.DataSource = ds;
                DataList1.DataBind();
            con.Close();


            }
        
    }
}