<%@ Page Language="C#" AutoEventWireup="true" CodeFile="urundetay.aspx.cs" Inherits="urundetay" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            height: 222px;
            width: 245px;
        }
        .style3
        {
            width: 245px;
        }
        .style4
        {
            height: 222px;
            width: 259px;
        }
        .style5
        {
            width: 259px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table align="center" style="width: 58%;">
        <tr>
            <td class="style2">
                <asp:Image ID="Image1" runat="server" Height="218px" Width="235px" />
            </td>
            <td class="style4">
                <asp:Image ID="Image2" runat="server" Height="213px" Width="235px" />
            </td>
        </tr>
        <tr>
            <td align="center" class="style3">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="fiyat1" runat="server" Text="Label"></asp:Label>
            </td>
            <td align="center" class="style5">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="fiyat2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center" class="style3">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Sepete Ekle" />
            </td>
            <td align="center" class="style5">
                <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
                    Text="Sepete ekle" />
            </td>
        </tr>
    </table>
    <br />
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/urunler.aspx">Kategorilere dön</asp:HyperLink>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
