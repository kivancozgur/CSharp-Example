<%@ Page Language="C#" AutoEventWireup="true" CodeFile="urunler.aspx.cs" Inherits="urunler" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {}
        .style2
        {
            width: 31%;
        }
        .style3
        {
            width: 4px;
        }
        .style4
        {
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="mesaj" runat="server" Text="Label"></asp:Label>
        <br />
        <table style="width: 18%; height: 231px;">
            <tr>
                <td class="style4">
                    Kategori Seçiniz</td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" 
                        GroupName="k" oncheckedchanged="RadioButton1_CheckedChanged" 
                        Text="Anakartlar" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" 
                        GroupName="k" oncheckedchanged="RadioButton2_CheckedChanged" Text="Ram" />
                </td>
            </tr>
            <tr>
                <td class="style1">
                    <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" 
                        GroupName="k" oncheckedchanged="RadioButton3_CheckedChanged" Text="Hdd" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
