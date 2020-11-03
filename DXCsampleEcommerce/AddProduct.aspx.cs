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

        static String imagelink;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getproductid();

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mb74\OneDrive - DXC Production\Desktop\personal\DXCSampleEcommerceProject\MSAccessDAtabase\db1.accdb");
                con.Open();

                OleDbCommand cmd = new OleDbCommand();
                String myquery = "select * from Category";

                cmd.CommandText = myquery;
                cmd.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);  // fill dataset
                DropDownList1.DataTextField = ds.Tables[0].Columns["CategoryName"].ToString(); // text field name of table dispalyed in dropdown
                DropDownList1.DataValueField = ds.Tables[0].Columns["CategoryID"].ToString();             // to retrive specific  textfield name 
                DropDownList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist
                DropDownList1.DataBind();  //binding dropdownlist

            }

           // string constr = ConfigurationManager.ConnectionStrings["binddropdown"].ToString(); // connection string
           

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

       
            


                if (uploadimage() == true)
                {
                    //String query = "insert into Product(ProductID,ProductName,BrandName,Stock,Price,Discount,Description,ImagePath,CategoryID) values(" + Label2.Text + ",'" + TextBox5.Text + "','" + TextBox4.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "','" + TextBox1.Text + "','" + TextBox7.Text + "','" + imagelink + "','" + DropDownList1.SelectedItem.Value + "')";
                    OleDbCommand cmd = new OleDbCommand();
                    String query = "insert into Product(ProductID,ProductName,BrandName,Stock,Price,Discount,Description,ImagePath,CategoryID) values(@ProductID,@ProductName,@BrandName,@Stock,@Price,@Discount,@Description,@ImagePath,@CategoryID)";
                    cmd.Parameters.AddWithValue("@ProductID", Label2.Text);
                    cmd.Parameters.AddWithValue("@ProductName", TextBox5.Text);
                    cmd.Parameters.AddWithValue("@BrandName", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@Stock", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Price", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Discount", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Description", TextBox7.Text);
                    cmd.Parameters.AddWithValue("@ImagePath", imagelink);
                    cmd.Parameters.AddWithValue("@CategoryID", DropDownList1.SelectedItem.Value);



                    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mb74\OneDrive - DXC Production\Desktop\personal\DXCSampleEcommerceProject\MSAccessDAtabase\db1.accdb");
                    con.Open();
                    // OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = query;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    getproductid();
                    Label1.Text = "Product Has Been Successfully Added";
                    Label2.Text = "";
                    TextBox5.Text = "";
                    TextBox4.Text = "";
                    TextBox3.Text = "";
                    TextBox2.Text = "";
                    TextBox1.Text = "";
                    TextBox7.Text = "";
                    //DropDownList1.SelectedIndex = -1;
                    DropDownList1.SelectedIndex = -1;


                    //Response.AppendHeader("Refresh", "2;url=WebForm1.aspx");


                

            }


        }

        private Boolean uploadimage()
        {
            Boolean imagesaved = false;
            if (FileUpload1.HasFile == true)
            {

                String contenttype = FileUpload1.PostedFile.ContentType;

                if (contenttype == "image/jpeg")
                {

                    FileUpload1.SaveAs(Server.MapPath("~/Images/") + Label2.Text + ".jpg");
                    imagelink = "~/Images/" + Label2.Text + ".jpg";
                    imagesaved = true;
                }
                else
                {
                    Label1.Text = "Kindly Upload JPEG Format Image Only";
                }

            }

            else
            {
                Label1.Text = "You have not selected any file - Browse and Select File First";
            }

            return imagesaved;

        }

        public void getproductid()
        {

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\mb74\OneDrive - DXC Production\Desktop\personal\DXCSampleEcommerceProject\MSAccessDAtabase\db1.accdb");
            OleDbCommand cmd = new OleDbCommand();
            String myquery = "select ProductID from Product";

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



                String myquery1 = "select max(ProductID) from Product";
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
    }
}