<%@ Page Language="C#" AutoEventWireup="true" CodeFile="image_button_imagemap.aspx.cs" Inherits="image_button_imagemap" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 260px">
    
    </div>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="39px" 
        ImageUrl="~/img/3.gif" Width="145px" />
    <br />
    <br />
    <asp:ImageMap ID="ImageMap1" runat="server" Height="100px" 
        ImageUrl="~/img/kirmizi.JPG" Width="100px">
        <asp:CircleHotSpot AlternateText="Raioyaya git" NavigateUrl="~/Radio.aspx" 
            Radius="10" X="50" Y="50" />
    </asp:ImageMap>
    <br />
    <asp:BulletedList ID="BulletedList1" runat="server" BulletStyle="UpperAlpha">
        <asp:ListItem>a</asp:ListItem>
        <asp:ListItem>b</asp:ListItem>
    </asp:BulletedList>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
    </form>
</body>
</html>
