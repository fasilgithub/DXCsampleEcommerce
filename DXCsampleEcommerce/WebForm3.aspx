<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="DXCsampleEcommerce.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style11 {
            width: 242px;
            height: 148px;
            margin-left: 121px;
            margin-top: 0px;
        }
        .auto-style12 {
            width: 226px;
        }
        .auto-style13 {
            width: 493px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="Center">
  
  <tr>
    <td class="auto-style13"> <img src="@imagePath" class="auto-style11" /></td>
    <td>
    <table class="center" >
        <tr>
        <td class="auto-style12">Product Name</td><td>
            <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" ></asp:TextBox></td>
        </tr>  
        <tr>
        <td class="auto-style12">Brand</td><td>
            <asp:TextBox ID="TextBox2" runat="server" BorderStyle="None"   ></asp:TextBox></td>
        </tr> 
        <tr>
        <td class="auto-style12" >Stock</td><td >
            <asp:TextBox ID="TextBox3" runat="server" BorderStyle="None"></asp:TextBox></td>
        </tr> 
        <tr>
        <td class="auto-style12" >Price(₹)</td><td>
            <asp:TextBox ID="TextBox4" runat="server" BorderStyle="None" ></asp:TextBox></td>
        </tr> 
        <tr>
        <td class="auto-style12" >Discount(₹)</td><td>
            <asp:TextBox ID="TextBox5" runat="server" BorderStyle="None"></asp:TextBox></td>
        </tr> 
         <tr>
        <td class="auto-style12" >Description</td><td>
            <asp:TextBox ID="TextBox6" runat="server" BorderStyle="None"></asp:TextBox></td>
        </tr> 
           </table> 
    </td>
  </tr>
  
</table>


    </asp:Content>
