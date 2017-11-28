<%@ Page Language="C#" AutoEventWireup="true" CodeFile="validatorler.aspx.cs" Inherits="validatorler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" 
            ErrorMessage="ad kutusu boş geçilemez">xxx</asp:RequiredFieldValidator>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    
    </div>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br />
    <asp:RangeValidator ID="RangeValidator1" runat="server" 
        ControlToValidate="TextBox2" ErrorMessage="RangeValidator" 
        MaximumValue="01.01.2010" MinimumValue="01.01.2000" Type="Date"></asp:RangeValidator>
    <br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:CustomValidator ID="CustomValidator1" runat="server" 
        ErrorMessage="şifre 6 karakter" 
        onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        ShowMessageBox="True" />
    <br />
    </form>
</body>
</html>
