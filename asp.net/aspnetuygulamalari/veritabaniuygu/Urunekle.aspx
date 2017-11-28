<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Urunekle.aspx.cs" Inherits="Urunekle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    Ürün Adı Giriniz:</td>
                <td>
                    <asp:TextBox ID="urunaditext" runat="server" Width="209px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Fiyatı:</td>
                <td>
                    <asp:TextBox ID="fiyattext" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Açıklama:</td>
                <td>
                    <asp:TextBox ID="aciklamatext" runat="server" Height="151px" 
                        TextMode="MultiLine" Width="274px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Resim Seç:</td>
                <td>
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="282px" />
                    <asp:Image ID="Image1" runat="server" Height="100px" Width="104px" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Kategori Seç:</td>
                <td>
                    <asp:DropDownList ID="kategoriliste" runat="server" Height="16px" Width="87px">
                        <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="center" class="style1" colspan="2">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Kaydet" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
