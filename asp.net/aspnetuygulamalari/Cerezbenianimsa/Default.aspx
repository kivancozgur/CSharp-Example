<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Kullanıcı Adı:<asp:TextBox ID="kuladi" runat="server"></asp:TextBox>
        <br />
        Şifre:<asp:TextBox ID="sifre" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Beni Anımsa" />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Giriş" />
    
    </div>
    </form>
</body>
</html>
