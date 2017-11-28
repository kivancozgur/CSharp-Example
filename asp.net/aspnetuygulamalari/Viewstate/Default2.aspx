<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="uyeid" DataSourceID="SqlDataSource1" EnableViewState="False">
            <Columns>
                <asp:BoundField DataField="uyeid" HeaderText="uyeid" InsertVisible="False" 
                    ReadOnly="True" SortExpression="uyeid" />
                <asp:BoundField DataField="kuladi" HeaderText="kuladi" 
                    SortExpression="kuladi" />
                <asp:BoundField DataField="sifre" HeaderText="sifre" SortExpression="sifre" />
                <asp:BoundField DataField="adsoyad" HeaderText="adsoyad" 
                    SortExpression="adsoyad" />
                <asp:BoundField DataField="dogtar" HeaderText="dogtar" 
                    SortExpression="dogtar" />
                <asp:CheckBoxField DataField="cinsiyet" HeaderText="cinsiyet" 
                    SortExpression="cinsiyet" />
                <asp:BoundField DataField="adres" HeaderText="adres" SortExpression="adres" />
                <asp:BoundField DataField="sehir" HeaderText="sehir" SortExpression="sehir" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="meslek" HeaderText="meslek" 
                    SortExpression="meslek" />
                <asp:CheckBoxField DataField="onay" HeaderText="onay" SortExpression="onay" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\deneme.mdf;Integrated Security=True;User Instance=True" 
            ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [uyeler]">
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
