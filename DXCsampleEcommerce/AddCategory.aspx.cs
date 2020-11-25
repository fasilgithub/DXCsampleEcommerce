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
    public partial class WebForm7 : System.Web.UI.Page
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetCategoryId();

            }
        }

        public void GetCategoryId()
        {
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand();
            string query = "select CategoryID from Category";
            cmd.CommandText = query;
            cmd.Connection = con;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            con.Close();
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count < 1)
            {
                Label2.Text = "1";
            }
            else
            {
                OleDbConnection con1 = new OleDbConnection(connectionString);
                string query1 = "select max(CategoryID) from Category";
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.CommandText = query1;
                cmd1.Connection = con1;
                OleDbDataAdapter da1 = new OleDbDataAdapter();
                da1.SelectCommand = cmd1;
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                Label2.Text = ds1.Tables[0].Rows[0][0].ToString();
                int a;
                a = Convert.ToInt16(Label2.Text);
                a += 1;
                Label2.Text = a.ToString();
                con1.Close();
            }

        }

        protected void AddButton_Click(object sender, EventArgs e)
        {
            string query = "insert into Category(CategoryID,CategoryName) values(@CategoryID,@CategoryName)";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Parameters.AddWithValue("@CategoryID", Label2.Text);
            cmd.Parameters.AddWithValue("@CategoryName", TextBox5.Text);

            if (TextBox5.Text == "")
            {
                Label3.Text = "Please Enter Category Name !";
                Label1.Text = "";
            }
            else
            {
                OleDbConnection con = new OleDbConnection(connectionString);
                con.Open();
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                GetCategoryId();
                Label1.Text = "Category Has Been Successfully Added";
                Label2.Text = "";
                Label3.Text = "";
                TextBox5.Text = "";
            }
        }

    }
}