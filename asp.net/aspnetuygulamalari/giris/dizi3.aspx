<%@ Page Language="C#" AutoEventWireup="true" CodeFile="dizi3.aspx.cs" Inherits="dizi3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="135px" Width="96px">
        </asp:ListBox>
        <asp:ListBox ID="ListBox2" runat="server" Height="134px" Width="114px">
        </asp:ListBox>
        <asp:ListBox ID="ListBox3" runat="server" Height="129px" Width="120px">
        </asp:ListBox>
    
    </div>
    </form>
</body>
</html>
