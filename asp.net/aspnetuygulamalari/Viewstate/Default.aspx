<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            <asp:ListItem Value="16">Bursa</asp:ListItem>
            <asp:ListItem Value="6">Ankara</asp:ListItem>
        </asp:DropDownList>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
            EnableViewState="False" Height="272px" Width="245px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
