<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductList.aspx.cs" Inherits="DXCsampleEcommerce.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   <asp:GridView ID="GridView3" runat="server"  AutoGenerateColumns="False"  CellPadding="3" Width="1073.99px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" Height="16px" >

      <Columns>
             
        <asp:HyperLinkField DataTextField="ProductName" DataNavigateUrlFields="ProductID" DataNavigateUrlFormatString="ProductDetails.aspx?ProductID={0}"  HeaderText="Product Name" SortExpression="Product_Name" HeaderStyle-HorizontalAlign="Right" />
        <asp:BoundField DataField="BrandName" HeaderText="Brand Name" SortExpression="Brand_Name" />
        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        <asp:BoundField DataField="Discount" HeaderText="Discount" SortExpression="Discount" />
        <asp:BoundField DataField="Stock" HeaderText="Stock" SortExpression="Stock" />

      </Columns>

    <FooterStyle BackColor="White" ForeColor="#000066" />
    <HeaderStyle BackColor="#323232" Font-Bold="True" ForeColor="WhiteSmoke" HorizontalAlign="Center" />
    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />    
    <RowStyle ForeColor="Black"/>
    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#007DBB" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#00547E" />

   </asp:GridView>
       
</asp:Content>
