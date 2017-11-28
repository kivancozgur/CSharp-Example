<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Ürün seçiniz.<asp:DropDownList ID="DropDownList1" runat="server" 
            AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            <asp:ListItem Value="1">Anakart</asp:ListItem>
            <asp:ListItem Value="2">Hdd</asp:ListItem>
            <asp:ListItem Value="3">Ram</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
