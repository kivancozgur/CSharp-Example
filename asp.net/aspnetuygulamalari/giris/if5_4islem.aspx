<%@ Page Language="C#" AutoEventWireup="true" CodeFile="if5_4islem.aspx.cs" Inherits="if5_4islem" %>

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
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Hesapla" />
        <br />
        <asp:RadioButton ID="toplaradio" runat="server" GroupName="x" Text="Topla" />
        <asp:RadioButton ID="cikarradio" runat="server" GroupName="x" Text="Çıkar" />
        <asp:RadioButton ID="carpradio" runat="server" GroupName="x" Text="Çarpma" />
        <asp:RadioButton ID="ustradio" runat="server" GroupName="x" Text="Üs alma" />
    
    </div>
    </form>
</body>
</html>
