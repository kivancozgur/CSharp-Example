<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <asp:CheckBox ID="CheckBox2" runat="server" />
                <asp:CheckBox ID="CheckBox3" runat="server" />
                <asp:CheckBox ID="CheckBox4" runat="server" />
            </asp:View>
        </asp:MultiView>
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="kişisel bilgiler" />
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Eğitim bilgileri" />
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
        Text="Hobiler" />
    </form>
</body>
</html>
