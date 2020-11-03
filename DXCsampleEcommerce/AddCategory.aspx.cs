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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getcategoryid();

            }
        }

        public void getcategoryid()
        {

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mb74\OneDrive - DXC Production\Desktop\personal\DXCSampleEcommerceProject\MSAccessDAtabase\db1.accdb");
            OleDbCommand cmd = new OleDbCommand();
            String myquery = "select CategoryID from Category";

            cmd.CommandText = myquery;
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter();

            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            if (ds.Tables[0].Rows.Count < 1)
            {
                Label2.Text = "1";

            }
            else
            {


                OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mb74\OneDrive - DXC Production\Desktop\personal\DXCSampleEcommerceProject\MSAccessDAtabase\db1.accdb");



                String myquery1 = "select max(CategoryID) from Category";
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.CommandText = myquery1;
                cmd1.Connection = con1;
                OleDbDataAdapter da1 = new OleDbDataAdapter();
                da1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                Label2.Text = ds1.Tables[0].Rows[0][0].ToString();
                int a;
                a = Convert.ToInt16(Label2.Text);
                a = a + 1;
                Label2.Text = a.ToString();
                con1.Close();
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //String query = "insert into Category(CategoryID,CategoryName) values(" + Label2.Text + ",'" + TextBox5.Text + "')";

            String query = "insert into Category(CategoryID,CategoryName) values(@CategoryID,@CategoryName)";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Parameters.AddWithValue("@CategoryID", Label2.Text);
            cmd.Parameters.AddWithValue("@CategoryName", TextBox5.Text);

            if (TextBox5.Text == "")
            {
                Label3.Text = "Please Enter Category Name !";
            }
            else
            {


                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mb74\OneDrive - DXC Production\Desktop\personal\DXCSampleEcommerceProject\MSAccessDAtabase\db1.accdb");
                con.Open();

                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                getcategoryid();
                Label1.Text = "Category Has Been Successfully Added";
                Label2.Text = "";
                Label3.Text = "";
                TextBox5.Text = "";


            }
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}