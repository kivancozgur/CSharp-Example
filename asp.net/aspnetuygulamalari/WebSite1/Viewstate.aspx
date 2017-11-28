<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Viewstate.aspx.cs" Inherits="Viewstate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            <asp:ListItem Value="16">Bursa</asp:ListItem>
        </asp:DropDownList>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="163px" 
            onselectedindexchanged="ListBox1_SelectedIndexChanged" Width="126px">
        </asp:ListBox>
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1" EnableViewState="False" Height="130px" 
        Width="412px">
        <Columns>
            <asp:BoundField DataField="ogno" HeaderText="ogno" InsertVisible="False" 
                ReadOnly="True" SortExpression="ogno" />
            <asp:BoundField DataField="adsoyad" HeaderText="adsoyad" 
                SortExpression="adsoyad" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
        SelectCommand="SELECT * FROM [Table1]"></asp:SqlDataSource>
    </form>
</body>
</html>
