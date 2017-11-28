<%@ Page Language="C#" AutoEventWireup="true" CodeFile="while2.aspx.cs" Inherits="while2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="bilgikutusu" runat="server"></asp:TextBox>
        <asp:DropDownList ID="kackerelistesi" runat="server" AutoPostBack="True" 
            Height="18px" onselectedindexchanged="kackerelistesi_SelectedIndexChanged" 
            Width="104px">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
