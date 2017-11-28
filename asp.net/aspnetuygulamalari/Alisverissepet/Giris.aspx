<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Giris.aspx.cs" Inherits="Giris" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
        }
        .style3
        {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" style="width: 44%;">
            <tr>
                <td class="style2" colspan="2">
                    <asp:Label ID="mesaj" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Kullanıcı Adı:</td>
                <td>
                    <asp:TextBox ID="kuladitext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    Şifre:</td>
                <td>
                    <asp:TextBox ID="sifretext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1" colspan="2">
                    <asp:Label ID="hata" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" class="style3" colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Giriş" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
