<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditProduct.aspx.cs" Inherits="DXCsampleEcommerce.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="editproduct.css" rel="stylesheet" />

     <div>
            <table align="center" id="0" border="0" class="auto-style7">
                <tr>
                    <td colspan="2" align="Center"><h3><b>Edit Product Details</b></h3></td>
                    
                </tr>
                <tr>
                    <td class="auto-style5" ><b>Product Name</b></td>
                    <td >
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="38px"></asp:DropDownList>
                        <asp:Button ID="Button1"  runat="server"  Text="Search"  OnClick="SearchButton_Click" />
                        <br />  
                    </td>
                </tr>
         
                <tr>
                    <td class="auto-style9"><b>Brand Name</b></td>
                    <td class="auto-style10" >
                        <asp:TextBox ID="TextBox4" runat="server"  CssClass="auto-style11"></asp:TextBox>
                    </td>
                </tr>

                  <tr>
                    <td class="auto-style5"><b>Category ID</b></td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"  CssClass="auto-style11"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style5"><b>Stock</b></td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"  CssClass="auto-style11"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><b>Price(₹)</b></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"  CssClass="auto-style11"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><b>Discount(₹)</b></td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"  CssClass="auto-style11"></asp:TextBox>
                    </td>
                </tr>

                  <tr>
                    <td class="auto-style5"><b>Description</b></td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server" CssClass="auto-style12"></asp:TextBox>
                    </td>
                </tr>             

                <tr>
                    <td class="auto-style2" colspan="2"  >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2"  runat="server" Text="Save&Update"  OnClick="EditButton_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2"  align="center">
                        &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" ForeColor="#339933" BorderStyle="None" runat="server"></asp:Label>
                        <asp:Label ID="Label3" runat="server" BorderStyle="None" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>

                  <tr>
                    <td class="auto-style5" >
                        <asp:HyperLink ID="HyperLink1" href="/EditProduct.aspx" runat="server">Edit Another</asp:HyperLink> </td>
                      <td style="text-align:initial">
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:HyperLink ID="HyperLink2" runat="server"  NavigateUrl="~/default.aspx"   >Back To Home Page</asp:HyperLink></td>
                </tr>
            </table>
        </div>

</asp:Content>
