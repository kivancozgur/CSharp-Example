<%@ Page Language="C#" AutoEventWireup="true" CodeFile="islem.aspx.cs" Inherits="islem" %>

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
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Topla" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Çıkar" />
        <asp:Button ID="Carpmabutonu" runat="server" onclick="Carpmabutonu_Click" 
            Text="Çarp" />
    
    </div>
    </form>
</body>
</html>
