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

            string CategoryID = Request.QueryString["CategoryID"];
            OleDbConnection con = new OleDbConnection(connStr);
            string query = "select * from Product where CategoryID=" + CategoryID;
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataAdapter olda = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                olda.Fill(dt);


            GridView3.DataSource = dt;
            GridView3.DataBind();


            }

        protected void Add_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProduct.aspx");
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProduct.aspx");
        }

        protected void Catogory_Add_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCategory.aspx");
        }
    }
}