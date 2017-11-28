<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" Height="19px" 
            MaxLength="5" ontextchanged="TextBox1_TextChanged" TabIndex="1" 
            TextMode="Email" ToolTip="buraya email girin" Width="131px"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" TabIndex="3"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" TabIndex="5" Text="Button" />
        <asp:RadioButton ID="RadioButton1" runat="server" TabIndex="2" />
        <asp:CheckBox ID="CheckBox1" runat="server" TabIndex="4" />
        <br />
        <asp:Panel ID="Panel1" runat="server" BorderColor="Red" BorderStyle="Solid" 
            BorderWidth="2px" GroupingText="seçim yapın" Height="87px" Width="507px">
            <asp:ImageButton ID="ImageButton1" runat="server" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </asp:Panel>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
        <br />
    
    </div>
    </form>
</body>
</html>
