<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Giris.aspx.cs" Inherits="Giris" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="kuladi" runat="server"></asp:TextBox>
        <asp:TextBox ID="sifre" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Urunler.aspx">Ürünler için tıklayın</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
