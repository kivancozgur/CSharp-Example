<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
        <asp:TextBox ID="TextBox1" runat="server" Height="185px" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Button" />
    
        <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="Button" />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="Button" />
        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="Button" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
