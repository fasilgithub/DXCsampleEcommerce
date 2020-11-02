<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="DXCsampleEcommerce.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <style type="text/css">
       

       .auto-style5 {
           width: 168px;
       }
       .auto-style7 {
           width: 690px;
           height: 464px;
       }
       .auto-style8 {
           width: 149px;
       }
       </style>

     <div>
            <table align="center" id="0" border="0" class="auto-style7">
                <tr>
                    <td colspan="2" align="Center"><h1><b>Edit Product Details</b></h1></td>
                    
                </tr>
                <tr>
                    <td class="auto-style8" ><b>Product ID</b></td>
                    <td >
                       
                        <asp:TextBox ID="TextBox1" runat="server" Height="38px" Width="350px"></asp:TextBox>
                   
                        <asp:Button ID="Button1" runat="server" Height="25px" Text="SEARCH" Width="80px" OnClick="Button1_Click" />
                        <br />

                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8"><b>Product Name</b></td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Height="38px" Width="350px"></asp:TextBox>
                    </td>
                </tr>


                <tr>
                    <td class="auto-style8"><b>Brand Name</b></td>
                    <td >
                        <asp:TextBox ID="TextBox4" runat="server" Height="38px" Width="350px"></asp:TextBox>
                    </td>
                </tr>

                
                  <tr>
                    <td class="auto-style8"><b>Category ID</b></td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server" Height="38px" Width="350px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style8"><b>Stock</b></td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Height="38px" Width="350px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8"><b>Price(₹)</b></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Height="38px" Width="350px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8"><b>Discount(₹)</b></td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" Height="38px" Width="350px"></asp:TextBox>
                    </td>
                </tr>

                  <tr>
                    <td class="auto-style8"><b>Description</b></td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server" Height="48px" Width="350px"></asp:TextBox>
                    </td>
                </tr>             

              

                

                <tr>
                    <td class="auto-style2" colspan="2" align="center" >
                        <asp:Button ID="Button2" runat="server" Text="Save&Update" OnClick="Button2_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2"  align="center">
                        &nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label></td>
                    <td>&nbsp;</td>
                </tr>

                  <tr>
                    <td class="auto-style8" >
                        <asp:HyperLink ID="HyperLink1" href="/WebForm6.aspx" runat="server">Edit Another</asp:HyperLink> </td>
                      <td style="text-align:Center">
                       
                        <asp:HyperLink ID="HyperLink2" runat="server"  NavigateUrl="~/WebForm1.aspx"  >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Back To Home Page</asp:HyperLink></td>
                </tr>

            </table>
        </div>

</asp:Content>
