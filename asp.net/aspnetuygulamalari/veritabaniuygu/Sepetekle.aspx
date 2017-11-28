<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sepetekle.aspx.cs" Inherits="Sepetekle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" style="width: 40%; height: 68px;">
            <tr>
                <td align="center" colspan="3">
                    <asp:Table ID="Table1" runat="server" Width="318px">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server">Ürün Adı</asp:TableCell>
                            <asp:TableCell runat="server">Fiyatı</asp:TableCell>
                            <asp:TableCell runat="server">Adet</asp:TableCell>
                            <asp:TableCell runat="server">Sil</asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" 
                        ImageUrl="~/img/satin_al.jpg" Width="126px" onclick="ImageButton1_Click" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="25px" 
                        ImageUrl="~/img/sepeti_yenile.jpg" onclick="ImageButton2_Click" Width="155px" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    <asp:Label ID="mesaj" runat="server" ForeColor="Red" Text="Label"></asp:Label>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
