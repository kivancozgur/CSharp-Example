<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Anasayfa.aspx.cs" Inherits="Anasayfa" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        İstediğiniz ürünü Seçiniz.<br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/urunler.aspx?id=1">Anakart</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/urunler.aspx?id=2">Harddisk</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/urunler.aspx?id=3">Ram</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
