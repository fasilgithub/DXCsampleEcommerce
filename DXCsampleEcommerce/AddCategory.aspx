<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="DXCsampleEcommerce.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
            <table align="center" id="0" border="0" >
                <tr>
                    <td colspan="3" align="center" ><h3 ><b>Add Category</b></h3></td>
                    <td></td>
                </tr>
                <tr>
                    <td class="auto-style1"><b>Category ID</b></td>
                    <td >
                        <asp:Label ID="Label2" runat="server"></asp:Label>   
                    </td>
                </tr>

                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td><b>Category Name</b></td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Height="40px" Width="350px" ></asp:TextBox>
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
                        <asp:Label ID="Label3" runat="server" BorderStyle="None" ForeColor="Red" ></asp:Label>
                        </td>
                    <td></td>
                </tr>
                <tr>
                    <td >
                        <asp:HyperLink ID="HyperLink1" href="/AddCategory.aspx" runat="server">Add Another Category</asp:HyperLink> </td>   
                    <td style="text-align:center">        
                        <asp:HyperLink ID="HyperLink2" runat="server"  NavigateUrl="~/default.aspx" >Back To Home Page</asp:HyperLink> </td>
                </tr>
            </table>
        </div>

</asp:Content>
