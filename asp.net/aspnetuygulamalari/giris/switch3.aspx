<%@ Page Language="C#" AutoEventWireup="true" CodeFile="switch3.aspx.cs" Inherits="switch3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        İşlem Seçiniz:<asp:DropDownList ID="islemlistesi" runat="server" 
            AutoPostBack="True" Height="18px" 
            onselectedindexchanged="islemlistesi_SelectedIndexChanged" Width="112px">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            <asp:ListItem Value="1">Kare</asp:ListItem>
            <asp:ListItem Value="2">Üçgen</asp:ListItem>
            <asp:ListItem Value="3">Daire</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Hesapla" 
            Visible="False" />
        <br />
        <br />
        <asp:Panel ID="Panelkare" runat="server" GroupingText="Kare Bilgisi" 
            Height="111px" Visible="False" Width="319px">
            Kare Kenarı giriniz.<asp:TextBox ID="karekutu" runat="server"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="Panelucgen" runat="server" GroupingText="Üçgen bilgileri" 
            Height="129px" Visible="False" Width="316px">
            Üçgen Taban uzunluk:<asp:TextBox ID="ucgentabankutu" runat="server"></asp:TextBox>
            <br />
            Üçgen Yükseklik:<asp:TextBox ID="ucgenyukseklikkutu" runat="server"></asp:TextBox>
        </asp:Panel>
        <asp:Panel ID="paneldaire" runat="server" GroupingText="Daire Bilgileri" 
            Height="86px" Visible="False" Width="319px">
            Daire Yarıçapı:<asp:TextBox ID="yaricapkutu" runat="server"></asp:TextBox>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
