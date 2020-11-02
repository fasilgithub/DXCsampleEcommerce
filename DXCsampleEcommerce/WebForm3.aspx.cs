using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace DXCsampleEcommerce
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            if (!Page.IsPostBack)
            {
                refreshdata();
            }
        }

        public void refreshdata()
        {

            string ProductID = Request.QueryString["ProductID"];
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mb74\OneDrive - DXC Production\Desktop\personal\DXCSampleEcommerceProject\MSAccessDAtabase\db1.accdb");
            string query = "select * from Product where ProductID=" + ProductID;
            OleDbCommand cmd = new OleDbCommand(query, con);
            OleDbDataAdapter olda = new OleDbDataAdapter(cmd);
            con.Open();
            OleDbDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                TextBox1.Text = (sdr["ProductName"].ToString());
                TextBox2.Text = (sdr["BrandName"].ToString());
                TextBox3.Text = (sdr["Stock"].ToString());
                TextBox4.Text = (sdr["Price"].ToString());
                TextBox5.Text = (sdr["Discount"].ToString());
                TextBox6.Text = (sdr["Description"].ToString());


            }
                con.Close();









            //DataTable dt = new DataTable();
            //olda.Fill(dt);


                //gridview4.datasource = dt;
                //gridview4.databind();


        }
    }
}