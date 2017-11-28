<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="x" 
            oncheckedchanged="RadioButton1_CheckedChanged" Text="Bay" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="x" Text="Bayan" />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Gs</asp:ListItem>
            <asp:ListItem>fb</asp:ListItem>
            <asp:ListItem>bjk</asp:ListItem>
            <asp:ListItem>Bursa</asp:ListItem>
            <asp:ListItem>Antalya</asp:ListItem>
            <asp:ListItem>trabzon</asp:ListItem>
        </asp:RadioButtonList>
    
    </div>
    </form>
</body>
</html>
