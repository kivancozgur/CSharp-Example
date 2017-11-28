<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sehirkaydet.aspx.cs" Inherits="Sehirkaydet" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Sehir plakası:<asp:TextBox ID="plakatext" runat="server"></asp:TextBox>
        <br />
        Sehirin adı:<asp:TextBox ID="sehiradtext" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Kaydet" />
    
    </div>
    </form>
</body>
</html>
