<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" 
                    BorderWidth="1px">kamil</asp:TableCell>
                <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" 
                    BorderWidth="1px">fırat</asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
        <br />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
    
    </div>
    </form>
</body>
</html>
