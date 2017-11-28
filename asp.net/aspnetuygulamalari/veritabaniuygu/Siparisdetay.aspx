<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Siparisdetay.aspx.cs" Inherits="Siparisdetay" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table ID="Table1" runat="server" Width="294px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Urun adi</asp:TableCell>
                <asp:TableCell runat="server">Adet</asp:TableCell>
                <asp:TableCell runat="server">Fiyatı</asp:TableCell>
                <asp:TableCell runat="server">Resim</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
