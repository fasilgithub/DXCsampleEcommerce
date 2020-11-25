<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="DXCsampleEcommerce.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
        <table style="align-content:center">
        
        <tr>
             <br />
             <td style="padding-right:50px"> <asp:Image Height="380px" Width="400px" ID="Image1" runat="server" ImageUrl=<%#Eval("ImagePath") %> /></td>
        <td style="padding-right:40px;text-align:left;align-content:flex-start;">
            <table >
            <tr>
            <td style="width:100px" >Product</td>
            <br />
            <td><b><%#Eval("ProductName") %></b></td>
        </tr>
        <tr>
            <td>Brand</td>
            <br />
            <td><%#Eval("BrandName") %></td>
      
        </tr>
        <tr>
            <td>Stock</td> 
            <br />
            <td><%#Eval("Stock") %></td>
        
        </tr>
        <tr>
            <td>Price(₹)</td>
            <br />
            <td><%#Eval("Price") %></td>
        </tr>
        <tr>
            <td>Discount(₹)</td>
            <br />
            <td><%#Eval("Discount") %></td>
        </tr>
                  <tr>
            <td>Description</td>
            <br />
            <td><%#Eval("Description") %></td>
        </tr>
                </table>
            </td>
            </tr>
    </table>
            </ItemTemplate>


    </asp:DataList>
</asp:Content>
