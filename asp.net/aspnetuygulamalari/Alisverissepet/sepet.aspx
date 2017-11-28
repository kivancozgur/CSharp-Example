<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sepet.aspx.cs" Inherits="sepet" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Sepetimizdeki ürünler=<asp:Label ID="Sepeticerik" runat="server" Text="Label"></asp:Label>
        <br />
        Sepetin toplam tutarı=<asp:Label ID="fiylabel" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Sepeti Boşalt</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
