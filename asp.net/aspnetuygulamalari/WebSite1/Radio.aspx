<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Radio.aspx.cs" Inherits="Radio" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" TabIndex="7">
            <asp:ListItem>Gs</asp:ListItem>
            <asp:ListItem>fb</asp:ListItem>
            <asp:ListItem>bursa</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:RadioButton ID="RadioButton1" runat="server" TabIndex="6" />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" TabIndex="5" 
            Text="Button" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" MaxLength="2" TabIndex="1"></asp:TextBox>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" TabIndex="3" />
        <asp:TextBox ID="TextBox2" runat="server" TabIndex="2"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" TabIndex="4" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
