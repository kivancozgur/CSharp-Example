<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Kategori Seçin:<asp:DropDownList ID="kategorilistesi" runat="server" 
            AutoPostBack="True" 
            onselectedindexchanged="kategorilistesi_SelectedIndexChanged">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            <asp:ListItem Value="1">Elektronik</asp:ListItem>
            <asp:ListItem Value="2">Çiçek</asp:ListItem>
        </asp:DropDownList>
        <br />
        Alt kategori seçin:<asp:DropDownList ID="Altkategoriler" runat="server" 
            AutoPostBack="True" 
            onselectedindexchanged="Altkategoriler_SelectedIndexChanged">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
