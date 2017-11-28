<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dortislem.aspx.cs" Inherits="Dortislem" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="sayi1kutu" runat="server"></asp:TextBox>
        <asp:TextBox ID="sayi2kutu" runat="server"></asp:TextBox>
        <br />
        <asp:RadioButton ID="toplaradio" runat="server" AutoPostBack="True" 
            GroupName="islem" oncheckedchanged="toplaradio_CheckedChanged" Text="Topla" />
        <asp:RadioButton ID="cikarradio" runat="server" AutoPostBack="True" 
            GroupName="islem" oncheckedchanged="cikarradio_CheckedChanged" Text="Çıkar" />
        <asp:RadioButton ID="carpradio" runat="server" AutoPostBack="True" 
            GroupName="islem" oncheckedchanged="carpradio_CheckedChanged" Text="Çarp" />
        <asp:RadioButton ID="bolradio" runat="server" AutoPostBack="True" 
            GroupName="islem" oncheckedchanged="bolradio_CheckedChanged" Text="Böl" />
    
    </div>
    </form>
</body>
</html>
