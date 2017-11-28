<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server"></head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>

           <asp:Repeater ID="rptMain" runat="server" OnItemCommand="rptMain_ItemCommand" OnItemDataBound="rptMain_ItemDataBound">

                   <ItemTemplate>

                       <table cellpadding="0" cellspacing="3" width="360">

                           <tr>

                               <td width="150">

                                   <asp:DropDownList ID="DrpUrunList" Width="150" runat="server">

                                   </asp:DropDownList>

                               </td>

                               <td width="150">

                                   <asp:TextBox ID="txtMiktar" runat="server" Width="150" Text='<%#Eval("Miktar") %>'></asp:TextBox>

                               </td>

                               <td width="30">

                                   <asp:Button ID="btnAdd" runat="server" Width="30" Text="+" CommandName="Add" />

                               </td>

                               <td width="30">

                                   <asp:Button ID="Button1" runat="server" Width="30" Text="-" CommandName="Delete" />

                               </td>

                           </tr>

                       </table>
                   </ItemTemplate>
               </asp:Repeater>
               <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
           </ContentTemplate>
       </asp:UpdatePanel>
             </div>
    </form>
</body>
</html>