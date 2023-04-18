
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div>
       <div style="font-size:large" align="center">Category</div>
       <table class="nav-justified" style="height: 194px">
           <tr>
               <td class="modal-sm" style="width: 251px">&nbsp;</td>
               <td style="width: 337px">CategoryId</td>
               <td>
                   <asp:TextBox ID="TextBox1" runat="server" Width="163px"></asp:TextBox>
                   <asp:Button ID="Button6" runat="server" Font-Bold="True" OnClick="Button6_Click" Text="Get" />
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 251px">&nbsp;</td>
               <td style="width: 337px">CategoryName</td>
               <td>
                   <asp:TextBox ID="TextBox2" runat="server" Width="163px"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 251px">&nbsp;</td>
               <td style="width: 337px">&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 251px">&nbsp;</td>
               <td style="width: 337px">&nbsp;</td>
               <td>
                   &nbsp;</td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 251px">&nbsp;</td>
               <td style="width: 337px">&nbsp;</td>
               <td>
                   <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Text="Insert" />
                   <asp:Button ID="Button2" runat="server" Font-Bold="True" OnClick="Button2_Click" Text="Update" />
                   <asp:Button ID="Button3" runat="server" Font-Bold="True" OnClick="Button3_Click" Text="Delete" />
               </td>
           </tr>
           <tr>
               <td class="modal-sm" style="width: 251px">&nbsp;</td>
               <td style="width: 337px">&nbsp;</td>
               <td>
                   <asp:GridView ID="GridView1" runat="server" Height="210px" Width="584px">
                   </asp:GridView>
               </td>
           </tr>
       </table>
       <br />

   </div>
</asp:Content>
