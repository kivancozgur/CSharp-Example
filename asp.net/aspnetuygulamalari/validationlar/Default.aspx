<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="Ad soyad girmelisiniz" 
            ForeColor="Red" SetFocusOnError="True">*</asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="0">Seçiniz</asp:ListItem>
            <asp:ListItem Value="16">Bursa</asp:ListItem>
            <asp:ListItem Value="6">ankara</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="DropDownList1" ErrorMessage="Sehir seçiniz" InitialValue="0">*</asp:RequiredFieldValidator>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            DisplayMode="List" ShowMessageBox="True" />
        Yaşınızı girin:<asp:TextBox ID="TextBox2" runat="server" Width="128px"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="TextBox2" 
            ErrorMessage="Yaş değeri 18 ila 35 arasında olmalı" MaximumValue="35" 
            MinimumValue="18" Type="Integer">*</asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="Yaş girmelisiz">*</asp:RequiredFieldValidator>
        <br />
        Doğum tarihi:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator2" runat="server" 
            ControlToValidate="TextBox3" 
            ErrorMessage="doğum tarihi 1970 ila 2001 arasında olmalı" 
            MaximumValue="31.12.2001" MinimumValue="01.01.1970" Type="Date">*</asp:RangeValidator>
        <br />
        Şifre gir:<asp:TextBox ID="sifre1kutu" runat="server"></asp:TextBox>
        <br />
        şifre tekrar:<asp:TextBox ID="sifre2kutu" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="sifre2kutu" ControlToValidate="sifre1kutu" 
            ErrorMessage="Şifreler aynı değil" Type="Integer">*</asp:CompareValidator>
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
            EnableClientScript="False" ErrorMessage="şifre en az 6 karakter olmalı" 
            onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
        <br />
        Email:<asp:TextBox ID="emailkutu" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="emailkutu" ErrorMessage="geçersiz email" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="kaydet" />
    
    </div>
    </form>
</body>
</html>
