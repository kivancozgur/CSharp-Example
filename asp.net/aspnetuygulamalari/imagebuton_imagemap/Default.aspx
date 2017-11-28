<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageMap ID="ImageMap1" runat="server" Height="300px" 
            ImageUrl="~/img/kirmizi.JPG" Width="300px">
            <asp:CircleHotSpot AlternateText="mebe git" NavigateUrl="http:\\www.meb.gov.tr" 
                Radius="15" X="100" Y="100" />
        </asp:ImageMap>
        <br />
        <br />
        <asp:BulletedList ID="BulletedList1" runat="server" 
            BulletImageUrl="~/img/kirmizi.JPG" BulletStyle="Numbered" 
            DataSourceID="SqlDataSource1" DataTextField="adsoyad" DataValueField="ogno" 
            Height="16px" Width="187px">
            <asp:ListItem>Elektronik</asp:ListItem>
            <asp:ListItem>Giyim</asp:ListItem>
            <asp:ListItem>Yiyecek</asp:ListItem>
        </asp:BulletedList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="Data Source=TC\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True;Pooling=False" 
            ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [ogrenciler]">
        </asp:SqlDataSource>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="SqlDataSource1" DataTextField="adsoyad" DataValueField="ogno">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
