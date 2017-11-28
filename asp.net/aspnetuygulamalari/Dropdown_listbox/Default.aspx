<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ListBox ID="ListBox1" runat="server" Height="210px" Width="175px" 
            SelectionMode="Multiple">
            <asp:ListItem Value="16">Bursa</asp:ListItem>
            <asp:ListItem Value="6">Ankara</asp:ListItem>
            <asp:ListItem Value="34">istanbul</asp:ListItem>
            <asp:ListItem Value="45">mardin</asp:ListItem>
            <asp:ListItem Value="35">izmir</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="ekle" />
    
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="oku" />
    
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="sil" />
    
    </div>
    </form>
</body>
</html>
