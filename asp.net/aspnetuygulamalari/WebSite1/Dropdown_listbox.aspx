<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dropdown_listbox.aspx.cs" Inherits="Dropdown_listbox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            <asp:ListItem Value="16">Bursa</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
        <asp:ListBox ID="ListBox1" runat="server" Height="316px" 
            SelectionMode="Multiple" Width="258px">
            <asp:ListItem>Nilüfer</asp:ListItem>
            <asp:ListItem>kestel</asp:ListItem>
            <asp:ListItem>gursu</asp:ListItem>
        </asp:ListBox>
    
    </div>
    </form>
</body>
</html>
