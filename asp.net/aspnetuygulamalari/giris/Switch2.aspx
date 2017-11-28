<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Switch2.aspx.cs" Inherits="Switch2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="sehirler" runat="server" AutoPostBack="True" 
            Height="17px" onselectedindexchanged="sehirler_SelectedIndexChanged" 
            Width="103px">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            <asp:ListItem Value="16">Bursa</asp:ListItem>
            <asp:ListItem Value="6">Ankara</asp:ListItem>
            <asp:ListItem Value="34">İstanbul</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:ListBox ID="ilceler" runat="server" Height="242px" Width="135px">
        </asp:ListBox>
    
    </div>
    </form>
</body>
</html>
