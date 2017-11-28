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
                Kullanıcı Adı:<asp:TextBox ID="kuladitext" runat="server"></asp:TextBox>
                <br />
                Şifre:<asp:TextBox ID="sifretext" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Giriş" />
            </asp:View>
            <asp:View ID="View2" runat="server">
                Kaç Öğrenci Girilecek:<asp:TextBox ID="kackisitext" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button2" runat="server" Text="Devam" onclick="Button2_Click" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:Table ID="Table1" runat="server">
                    <asp:TableRow runat="server">
                        <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" 
                            BorderWidth="1px">AD Soyad</asp:TableCell>
                        <asp:TableCell runat="server" BorderColor="Black" BorderStyle="Solid" 
                            BorderWidth="1px">Not</asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
                <br />
                <asp:Button ID="Button3" runat="server" Text="Hesapla" 
                    onclick="Button3_Click" />
            </asp:View>
            <asp:View ID="View4" runat="server">
            </asp:View>
        </asp:MultiView>
    
    </div>
    <asp:Button ID="Button4" runat="server" Text="İşleme Başla" 
        onclick="Button4_Click1" />
    <br />
    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Birinci tarihi seç</asp:LinkButton>
    <asp:Calendar ID="Calendar1" runat="server" Height="16px" 
        onselectionchanged="Calendar1_SelectionChanged" Visible="False" Width="136px">
    </asp:Calendar>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>
