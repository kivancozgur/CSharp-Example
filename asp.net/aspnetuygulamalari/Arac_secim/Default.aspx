<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RadioButton ID="Radioyerli" runat="server" AutoPostBack="True" 
            GroupName="x" oncheckedchanged="Radioyerli_CheckedChanged" Text="Yerli" />
        <asp:RadioButton ID="Radioyabanci" runat="server" AutoPostBack="True" 
            GroupName="x" oncheckedchanged="Radioyabanci_CheckedChanged" Text="Yabanci" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="214px" 
            SelectionMode="Multiple" Width="150px"></asp:ListBox>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="&lt;--" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="--&gt;" />
        <asp:ListBox ID="ListBox2" runat="server" Height="212px" 
            SelectionMode="Multiple" Width="143px"></asp:ListBox>
    
    </div>
    </form>
</body>
</html>
