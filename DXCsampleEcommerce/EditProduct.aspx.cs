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

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public OleDbConnection con;
        public OleDbDataAdapter dad;
        public DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection con = new OleDbConnection(connectionString);
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                string query = "select * from Product";
                cmd.CommandText = query;
                cmd.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);  
                // Fill dataset
                DropDownList1.DataTextField = ds.Tables[0].Columns["ProductName"].ToString(); 
                // Text field name of table dispalyed in dropdown
                DropDownList1.DataValueField = ds.Tables[0].Columns["ProductName"].ToString();          
                // To retrive specific  textfield name 
                DropDownList1.DataSource = ds.Tables[0];     
                // Assigning datasource to the dropdownlist
                DropDownList1.DataBind(); 
                // Binding dropdownlist

            }
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";

            OleDbConnection con = new OleDbConnection(connectionString);
            con.Open();
            string data1;

            //    data1 = "select BrandName,Stock,Price,Discount,CategoryID,Description from Product where ProductName='" + TextBox1.Text+"'";
            data1 = "select BrandName,Stock,Price,Discount,CategoryID,Description from Product where ProductName='" + DropDownList1.SelectedItem.Value + "'";

            dad = new OleDbDataAdapter(data1, con);
            ds = new DataSet();
            dad.Fill(ds);
            if (ds.Tables[0].Rows.Count >= 1)
            {
                TextBox4.Text = ds.Tables[0].Rows[0]["BrandName"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["Stock"].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0]["Discount"].ToString();
                TextBox7.Text = ds.Tables[0].Rows[0]["CategoryID"].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0]["Description"].ToString();
            }
            else
            {
                Label3.Text = "";
            }
            con.Close();
        }

        protected void EditButton_Click(object sender, EventArgs e)
        {

            if (DropDownList1.SelectedItem.Value == "")
            {
                Label3.Text = "Please Select Product Name !";
            }
            else
            {
                if ( TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox6.Text == "" || TextBox7.Text == "" || TextBox8.Text == "")
                {
                    Label3.Text = "Please enter data in all fields !";
                }
                else
                {
                    OleDbConnection con = new OleDbConnection(connectionString);
                    con.Open();
                    string data1;
                    OleDbCommand cmd = new OleDbCommand();
                    data1 = "Update Product set  BrandName=@BrandName, Stock=@Stock, Price=@Price, Discount=@Discount, CategoryID=@CategoryID, Description=@Description where ProductName=@ProductName";
                    cmd = new OleDbCommand(data1, con);
            
                    cmd.Parameters.AddWithValue("@BrandName", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Stock", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Price", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Discount", TextBox6.Text);
                    cmd.Parameters.AddWithValue("@CategoryID", TextBox7.Text);
                    cmd.Parameters.AddWithValue("@Description", TextBox8.Text);
                    cmd.Parameters.AddWithValue("@ProductName", DropDownList1.SelectedItem.Value);

                    cmd.ExecuteNonQuery();
                    Label2.Text = "Data has been Updated Successfully" ;
                    DropDownList1.SelectedIndex = -1;
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    Label3.Text = "";
                    con.Close();

                }
            }
        }
    }
}