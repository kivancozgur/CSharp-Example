<%@ Page Language="C#" AutoEventWireup="true" CodeFile="urun_oku.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table ID="Table1" runat="server" Height="21px" Width="232px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Urunadi</asp:TableCell>
                <asp:TableCell runat="server">Fiyat</asp:TableCell>
                <asp:TableCell runat="server">Adet</asp:TableCell>
                <asp:TableCell runat="server">detay</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
    </div>
    <asp:Button ID="Button1" runat="server" Height="19px" onclick="Button1_Click" 
        Text="oku" Width="81px" />
    </form>
</body>
</html>
