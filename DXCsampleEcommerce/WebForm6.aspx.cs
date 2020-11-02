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
    public partial class WebForm6 : System.Web.UI.Page
    {
        public OleDbConnection con;
        public OleDbDataAdapter dad;
        public OleDbCommand com;
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


            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mb74\OneDrive - DXC Production\Desktop\personal\DXCSampleEcommerceProject\MSAccessDAtabase\db1.accdb");
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
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mb74\OneDrive - DXC Production\Desktop\personal\DXCSampleEcommerceProject\MSAccessDAtabase\db1.accdb");
            con.Open();
            String data1;
            data1 = "Update Product set ProductName='" + TextBox5.Text + "', BrandName= '" + TextBox4.Text + "', Stock='" + TextBox3.Text + "', Price='" + TextBox2.Text + "', Discount='" + TextBox6.Text + "', CategoryID='" + TextBox7.Text + "', Description='" + TextBox8.Text + "' where ProductID=" + TextBox1.Text;
            com = new OleDbCommand(data1, con);
            com.ExecuteNonQuery();
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