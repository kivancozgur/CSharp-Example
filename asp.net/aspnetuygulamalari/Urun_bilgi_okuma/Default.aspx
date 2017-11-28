<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table ID="Table1" runat="server" Width="265px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" 
                    BorderWidth="1px">Ürün Adı</asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" 
                    BorderWidth="1px">Fiyat</asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" 
                    BorderWidth="1px">Adet</asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" 
                    BorderWidth="1px">Detay</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="oku" />
    </form>
</body>
</html>
