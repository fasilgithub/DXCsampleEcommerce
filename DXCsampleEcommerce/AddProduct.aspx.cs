using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace DXCsampleEcommerce
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        static string imageLink;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetProductId();

                OleDbConnection con = new OleDbConnection(connectionString);
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                string query = "select * from Category";
                cmd.CommandText = query;
                cmd.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds); 
                // Fill dataset
                DropDownList1.DataTextField = ds.Tables[0].Columns["CategoryName"].ToString(); 
                // Text field name of table dispalyed in dropdown
                DropDownList1.DataValueField = ds.Tables[0].Columns["CategoryID"].ToString();             
                // To retrive specific  textfield name 
                DropDownList1.DataSource = ds.Tables[0];      
                // Assigning datasource to the dropdownlist
                DropDownList1.DataBind();  
                // Binding dropdownlist
            }
        }

        protected void AddButton_Click(object sender, EventArgs e)
        {

         if((TextBox5.Text=="") || (TextBox4.Text == "") || (TextBox3.Text == "") || (TextBox2.Text == "") || (TextBox1.Text == "") || (TextBox7.Text == ""))
            {
                Label3.Text = "Please enter data in all fields";
            }
            else
            {
                if (UploadImage() == true)
                {
                    OleDbCommand cmd = new OleDbCommand();
                    string query = "insert into Product(ProductID,ProductName,BrandName,Stock,Price,Discount,Description,ImagePath,CategoryID) values(@ProductID,@ProductName,@BrandName,@Stock,@Price,@Discount,@Description,@ImagePath,@CategoryID)";
                    cmd.Parameters.AddWithValue("@ProductID", Label2.Text);
                    cmd.Parameters.AddWithValue("@ProductName", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@BrandName", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Stock", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Price", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Discount", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Description", TextBox7.Text);
                    cmd.Parameters.AddWithValue("@ImagePath", imageLink);
                    cmd.Parameters.AddWithValue("@CategoryID", DropDownList1.SelectedItem.Value);

                    OleDbConnection con = new OleDbConnection(connectionString);
                    con.Open();
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    GetProductId();
                    Label1.Text = "Product Has Been Successfully Added";
                    Label2.Text = "";
                    Label3.Text = "";
                    TextBox5.Text = "";
                    TextBox4.Text = "";
                    TextBox3.Text = "";
                    TextBox2.Text = "";
                    TextBox1.Text = "";
                    TextBox7.Text = "";
                    DropDownList1.SelectedIndex = -1;
                    //Response.AppendHeader("Refresh", "2;url=WebForm1.aspx");
                }
            }
        }

        private bool UploadImage()
        {
            bool imageSaved = false;
            if (FileUpload1.HasFile == true)
            {
                string contentType = FileUpload1.PostedFile.ContentType;

                if (contentType == "image/jpeg")
                {
                    FileUpload1.SaveAs(Server.MapPath("~/Images/") + Label2.Text + ".jpg");
                    imageLink = "~/Images/" + Label2.Text + ".jpg";
                    imageSaved = true;
                }
                else
                {
                    Label3.Text = "Kindly Upload JPEG Format Image Only";
                }

            }
            else
            {
                Label3.Text = "You have not selected any file - Browse and Select File First";
            }
            return imageSaved;
        }

        public void GetProductId()
        {
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand();
            string query = "select ProductID from Product";
            cmd.CommandText = query;
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
                OleDbConnection con1 = new OleDbConnection(connectionString);
                string query1 = "select max(ProductID) from Product";
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
    }
}