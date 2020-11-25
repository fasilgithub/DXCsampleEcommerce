<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="DXCsampleEcommerce.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="addproduct.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
            <table align="center" id="0" border="0"  class="auto-style6">
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
                        <asp:DropDownList ID="DropDownList1" runat="server"   AutoPostBack="True" CssClass="auto-style14">
                            <asp:ListItem>Select Category</asp:ListItem>
                           
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style1"><b>Product Name</b></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox5" runat="server"  CssClass="auto-style14"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"><b>Brand Name</b></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox4" runat="server"   CssClass="auto-style14"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"><b>Stock</b></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox3" runat="server"  CssClass="auto-style14"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10"><b>Price(₹)</b></td>
                    
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox2" runat="server"   CssClass="auto-style14"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"><b>Discount(₹)</b></td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox1" runat="server"   CssClass="auto-style14"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td class="auto-style9"><b>Description</b></td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox7" runat="server"  CssClass="auto-style15"></asp:TextBox>
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
                        <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="AddButton_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Label ID="Label1" runat="server" BorderStyle="None" ForeColor="#339933" ></asp:Label>
                        <asp:Label ID="Label3" runat="server" BorderStyle="None" ForeColor="Red"></asp:Label>
                        </td>
                    <td></td>
                </tr>
                <tr>
                    <td >
                        <asp:HyperLink ID="HyperLink1" href="/AddProduct.aspx" runat="server">Add Another Product</asp:HyperLink> </td>
                    <td style="text-align:center">
                        <asp:HyperLink ID="HyperLink2" runat="server"  NavigateUrl="~/default.aspx" >Back To Home Page</asp:HyperLink> </td>
                </tr>
            </table>
        </div>

</asp:Content>
