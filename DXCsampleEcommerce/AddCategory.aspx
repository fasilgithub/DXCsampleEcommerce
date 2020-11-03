<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="DXCsampleEcommerce.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        <div class="auto-style1">
            <table align="center" id="0" border="0" style="background-color: #FFFFFF; background-image: url('pics/111534-light-color-blurred-background-vector.jpg'); " class="auto-style6">
                <tr>
                    <td colspan="3" align="center" class="auto-style13"><h3 class="auto-style5"><b>Add Category</b></h3></td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td class="auto-style1"><b>Category ID</b></td>
                    <td class="auto-style3">
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                       
                    </td>
                </tr>

                  <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style1"><b>Category Name</b></td>
                    <td class="auto-style3">
                        <asp:TextBox ID="TextBox5" runat="server" Height="40px" Width="350px" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
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
                        <asp:Label ID="Label3" runat="server" BorderStyle="None" ForeColor="Red" ></asp:Label>
                        </td>
                    <td></td>
                </tr>
                <tr>
                    <td >
                        <asp:HyperLink ID="HyperLink1" href="/AddCategory.aspx" runat="server">Add Another Category</asp:HyperLink> </td>
                   
                    <td style="text-align:center">
                       
                        <asp:HyperLink ID="HyperLink2" runat="server"  NavigateUrl="~/WebForm1.aspx" >Back To Home Page</asp:HyperLink> </td>
                </tr>
            </table>
        </div>

</asp:Content>
