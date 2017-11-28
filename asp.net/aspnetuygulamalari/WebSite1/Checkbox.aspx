<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Checkbox.aspx.cs" Inherits="Checkbox" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBox ID="CheckBox1" runat="server" 
            oncheckedchanged="CheckBox1_CheckedChanged" />
    
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" CellPadding="5" 
            CellSpacing="6" 
            onselectedindexchanged="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem>Kitap</asp:ListItem>
            <asp:ListItem>yüzme</asp:ListItem>
            <asp:ListItem>golf</asp:ListItem>
            <asp:ListItem>at binme</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
