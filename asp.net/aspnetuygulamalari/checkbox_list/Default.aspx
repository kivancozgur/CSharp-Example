<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:CheckBox ID="CheckBox1" runat="server" 
            oncheckedchanged="CheckBox1_CheckedChanged" Text="Kitap okumak" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="26px" 
            onselectedindexchanged="CheckBoxList1_SelectedIndexChanged" 
            RepeatDirection="Horizontal" Width="358px">
            <asp:ListItem>Kitap okumak</asp:ListItem>
            <asp:ListItem>Yüzme</asp:ListItem>
            <asp:ListItem>At binme</asp:ListItem>
            <asp:ListItem>Bisiklet</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Button4" runat="server" onclick="Button4_Click" Text="dikey" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            style="width: 38px" Text="ekle" />
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="oku" />
    
    </div>
    </form>
</body>
</html>
