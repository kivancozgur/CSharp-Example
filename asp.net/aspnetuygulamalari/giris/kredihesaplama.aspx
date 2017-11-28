<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kredihesaplama.aspx.cs" Inherits="kredihesaplama" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 147px;
            height: 23px;
        }
        .style3
        {
            height: 23px;
            width: 412px;
        }
        .style4
        {
            width: 412px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table border="1" style="width: 69%;">
            <tr>
                <td class="style1">
                    Kredi Tipi:</td>
                <td class="style4">
                    <asp:DropDownList ID="kreditip" runat="server" AutoPostBack="True" 
                        Height="16px" onselectedindexchanged="kreditip_SelectedIndexChanged" 
                        Width="127px">
                        <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                        <asp:ListItem Value="1">Taşıt Kredisi</asp:ListItem>
                        <asp:ListItem Value="2">Konut Kredisi</asp:ListItem>
                        <asp:ListItem Value="3">İhtiytaç Kredisi</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Kredi Miktarı:</td>
                <td class="style3">
                    <asp:TextBox ID="kredimiktar" runat="server" Width="147px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Vade:</td>
                <td class="style4">
                    <asp:DropDownList ID="vade" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="center" class="style1" colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="Hesapla" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Aylik Taksit.</td>
                <td class="style4">
                    <asp:TextBox ID="ayliktext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Toplam Geri Ödeme:</td>
                <td class="style4">
                    <asp:TextBox ID="toplamtext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Faiz Oranı:</td>
                <td class="style4">
                    <asp:TextBox ID="faizorantext" runat="server" Width="37px"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
