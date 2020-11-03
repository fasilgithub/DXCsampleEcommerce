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
    
    public partial class WebForm6 : System.Web.UI.Page
    {

        string connStr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public OleDbConnection con;
       public OleDbDataAdapter dad;
       // public OleDbCommand com;
        public DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {

            //TextBox2.Text = "";
            //TextBox3.Text = "";
            //TextBox4.Text = "";
            //TextBox5.Text = "";
            //TextBox6.Text = "";
            //TextBox7.Text = "";
            //TextBox8.Text = "";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";


            OleDbConnection con = new OleDbConnection(connStr);
            con.Open();
            String data1;
          
            data1 = "select ProductName,BrandName,Stock,Price,Discount,CategoryID,Description from Product where ProductID=" +TextBox1.Text;
            dad = new OleDbDataAdapter(data1, con);
            ds = new DataSet();
            dad.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
            {
                Label1.Text = "Record with Product ID " + TextBox1.Text + " Found";

                TextBox5.Text = ds.Tables[0].Rows[0]["ProductName"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["BrandName"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["Stock"].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0]["Discount"].ToString();
                TextBox7.Text = ds.Tables[0].Rows[0]["CategoryID"].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0]["Description"].ToString();


            }
            else
            {
                Label1.Text = "Record with Product ID " + TextBox1.Text + " Not Found";

            }
            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(connStr);
            con.Open();
            String data1;
            //data1 = "Update Product set ProductName='" + TextBox5.Text + "', BrandName= '" + TextBox4.Text + "', Stock='" + TextBox3.Text + "', Price='" + TextBox2.Text + "', Discount='" + TextBox6.Text + "', CategoryID='" + TextBox7.Text + "', Description='" + TextBox8.Text + "' where ProductID=" + TextBox1.Text;

             OleDbCommand cmd = new OleDbCommand();
            
            data1 = "Update Product set ProductName=@ProductName, BrandName=@BrandName, Stock=@Stock, Price=@Price, Discount=@Discount, CategoryID=@CategoryID, Description=@Description where ProductID=@ProductID";
            cmd = new OleDbCommand(data1, con);

            cmd.Parameters.AddWithValue("@ProductName", TextBox5.Text);
            cmd.Parameters.AddWithValue("@BrandName", TextBox4.Text);
            cmd.Parameters.AddWithValue("@Stock", TextBox3.Text);
            cmd.Parameters.AddWithValue("@Price", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Discount", TextBox6.Text);
           
            cmd.Parameters.AddWithValue("@CategoryID", TextBox7.Text);
            cmd.Parameters.AddWithValue("@Description", TextBox8.Text);
            cmd.Parameters.AddWithValue("@ProductID", TextBox1.Text);




          
            cmd.ExecuteNonQuery();
            Label2.Text = "Data has been Updated Successfully for ProductID " + TextBox1.Text;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";

            Label1.Text = "";
            con.Close();


        }

    }
}