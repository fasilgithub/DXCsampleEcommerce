<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="DXCsampleEcommerce.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 221px;
        }
        .auto-style2 {
            height: 34px;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style5 {
            height: 30px;
            width: 680px;
            margin-top: 0px;
            margin-bottom: 0px;
        }
        .auto-style6 {
            width: 697px;
            height: 450px;
        }
        .auto-style7 {
            height: 40px;
        }
        .auto-style9 {
            width: 221px;
            height: 40px;
        }
        .auto-style10 {
            width: 221px;
            height: 33px;
        }
        .auto-style13 {
            height: 24px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 
        <div>
            <table align="center" id="0" border="0" style="background-color: #FFFFFF; background-image: url('pics/111534-light-color-blurred-background-vector.jpg'); " class="auto-style6">
                <tr>
                    <td colspan="3" align="center" class="auto-style13"><h3 class="auto-style5"><b>Add Product</b></h3></td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style1"><b>Product ID</b></td>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                       
                    </td>
                </tr>

                  <tr>
                    <td class="auto-style1"><b>Product Category</b></td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="40px" Width="350px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem>Select Category</asp:ListItem>
                           
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style1"><b>Product Name</b></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox5" runat="server" Height="40px" Width="350px" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"><b>Brand Name</b></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server" Height="40px" Width="350px" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"><b>Stock</b></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server" Height="40px" Width="350px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10"><b>Price(₹)</b></td>
                    
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server" Height="40px" Width="350px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"><b>Discount(₹)</b></td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox1" runat="server" Height="40px" Width="350px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td class="auto-style9"><b>Description</b></td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox7" runat="server" Height="48px" Width="350px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>

                   <tr>
                    <td class="auto-style9"><b>Product Image</b></td>
                    <td class="auto-style7">
                        <asp:FileUpload ID="FileUpload1" runat="server" Width="348px" />
                    </td>
                </tr>

              

              
                <tr>
                    <td class="auto-style2" align="center" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click1" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


                        
                        </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Label ID="Label1" runat="server" BorderStyle="None" ForeColor="#339933" ></asp:Label>
                        </td>
                    <td></td>
                </tr>
                <tr>
                    <td >
                        <asp:HyperLink ID="HyperLink1" href="/AddProduct.aspx" runat="server">Add Another Product</asp:HyperLink> </td>
                   
                    <td style="text-align:center">
                       
                        <asp:HyperLink ID="HyperLink2" runat="server"  NavigateUrl="~/WebForm1.aspx" >Back To Home Page</asp:HyperLink> </td>
                </tr>
            </table>
        </div>
   

</asp:Content>
