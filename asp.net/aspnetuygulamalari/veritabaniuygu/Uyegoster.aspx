<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Uyegoster.aspx.cs" Inherits="Uyegoster" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Arama türünü Seçin:<asp:RadioButtonList ID="RadioButtonList1" runat="server" 
            AutoPostBack="True" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
            RepeatDirection="Horizontal">
            <asp:ListItem Value="1">Email</asp:ListItem>
            <asp:ListItem Value="2">Şehir</asp:ListItem>
            <asp:ListItem Value="0">Tümü</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:TextBox ID="emailtext" runat="server" AutoPostBack="True" 
            ontextchanged="emailtext_TextChanged" Visible="False"></asp:TextBox>
        <asp:DropDownList ID="Sehirlistesi" runat="server" AutoPostBack="True" 
            onselectedindexchanged="Sehirlistesi_SelectedIndexChanged" Visible="False">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
        </asp:DropDownList>
        <br />
    
        <asp:Table ID="Table1" runat="server" Width="771px" EnableViewState="False" 
            ViewStateMode="Enabled">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">üye no</asp:TableCell>
                <asp:TableCell runat="server">Adsoyad</asp:TableCell>
                <asp:TableCell runat="server">Kullanıcı adi</asp:TableCell>
                <asp:TableCell runat="server">Doğum tarihi</asp:TableCell>
                <asp:TableCell runat="server">Cinsiyet</asp:TableCell>
                <asp:TableCell runat="server">Sehir</asp:TableCell>
                <asp:TableCell runat="server">Email</asp:TableCell>
                <asp:TableCell runat="server">Değiştir</asp:TableCell>
                <asp:TableCell runat="server">Sil</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    
    </div>
    </form>
</body>
</html>
