<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UyeRaporla.aspx.cs" Inherits="UyeRaporla" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 180px;
        }
        .style2
        {
            width: 199px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    Email:<asp:TextBox ID="emailtext" runat="server" AutoPostBack="True" 
                        ontextchanged="emailtext_TextChanged"></asp:TextBox>
                </td>
                <td class="style2">
                    Şehir Seçiniz.<asp:DropDownList ID="sehirlist" runat="server" 
                        AutoPostBack="True" onselectedindexchanged="sehirlist_SelectedIndexChanged">
                        <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RadioButton ID="tumuradio" runat="server" AutoPostBack="True" 
                        oncheckedchanged="tumuradio_CheckedChanged" Text="Tümü" />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3">
                    &nbsp;</td>
            </tr>
        </table>
    
        <CR:CrystalReportViewer ID="raporgosterici" runat="server" AutoDataBind="true" 
            HasRefreshButton="True" />
    
    </div>
    </form>
</body>
</html>
