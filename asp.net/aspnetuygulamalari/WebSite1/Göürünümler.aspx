<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Göürünümler.aspx.cs" Inherits="Viwestate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:RadioButton ID="RadioButton1" runat="server" />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:CheckBox ID="CheckBox1" runat="server" />
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            </asp:View>
        </asp:MultiView>
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="adım 1" />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="adım 2" />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
        BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
        Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="57px" 
        onselectionchanged="Calendar1_SelectionChanged" ShowGridLines="True" 
        Width="110px">
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <SelectorStyle BackColor="#FFCC66" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
            ForeColor="#FFFFCC" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
    </asp:Calendar>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </form>
</body>
</html>
