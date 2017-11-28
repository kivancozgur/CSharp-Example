<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Servertransfer1.aspx.cs" Inherits="Servertransfer1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        <asp:Image ID="Image1" runat="server" Height="180px" ImageUrl="~/img/lale.jpg" 
            Width="282px" />
    
    </div>
    </form>
</body>
</html>
