<%@ Page Language="C#" MasterPageFile="~/Ziyaretci.master"    AutoEventWireup="true" CodeFile="Uyedegistir.aspx.cs" Inherits="uyekayit" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    
        <table align="center" style="height: 418px; width: 86%">
            <tr>
                <td class="style5">
                    Kullanıcı Adı:</td>
                <td colspan="2">
                    <asp:TextBox ID="kuladitext" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="kuladitext" ErrorMessage="Kullanıcı adı girmelisiniiz" 
                        ForeColor="Red" ValidationGroup="z">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Şifre:</td>
                <td colspan="2">
                    <asp:TextBox ID="sifre1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="sifre1" ErrorMessage="Şifre boş olmaz" ForeColor="Red" 
                        ValidationGroup="z">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="sifre2" ControlToValidate="sifre1" 
                        ErrorMessage="Şifreler birbirini tutmuyor" ForeColor="Red" 
                        ValidationGroup="z">*</asp:CompareValidator>
                    <asp:CustomValidator ID="CustomValidator2" runat="server" 
                        ErrorMessage="Şifreniz en az 6 karakter olmalı" ForeColor="Red" 
                        onservervalidate="CustomValidator2_ServerValidate" ValidationGroup="z">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Şifre Doğrula:</td>
                <td colspan="2">
                    <asp:TextBox ID="sifre2" runat="server"></asp:TextBox>
                </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td class="style5">
                    Ad Soyad:</td>
                <td colspan="2">
                    <asp:TextBox ID="adsoyad" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="adsoyad" ErrorMessage="Ad soyad girilmelidir" 
                        ForeColor="Red" ValidationGroup="z">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Doğum tarihi.</td>
                <td class="style1" colspan="2">
                    <asp:TextBox ID="dogtar" runat="server" ReadOnly="True"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" 
                        ImageUrl="~/img/takmin.png" onclick="ImageButton1_Click" 
                        ToolTip="Seçim için tıkla" Width="30px" />
                    <asp:Calendar ID="Calendar1" runat="server" Height="48px" 
                        onselectionchanged="Calendar1_SelectionChanged" Visible="False" Width="153px">
                    </asp:Calendar>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="dogtar" ErrorMessage="doğumtarihi boş olamaz"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Cinsiyet.</td>
                <td class="style4" colspan="2">
                    <asp:RadioButton ID="bayradio" runat="server" GroupName="x" Text="Bay" />
                    <asp:RadioButton ID="bayanradio" runat="server" GroupName="x" Text="bayan" />
                </td>
                <td>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" 
                        ErrorMessage="Lütfen cinsiyet seçiniz" ForeColor="Red" 
                        onservervalidate="CustomValidator1_ServerValidate" ValidationGroup="z">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Adres:</td>
                <td>
                    <asp:TextBox ID="adres" runat="server" Height="114px" TextMode="MultiLine" 
                        Width="267px"></asp:TextBox>
                </td>
                <td class="style8" colspan="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="adres" ErrorMessage="Adresi giriniz." ForeColor="Red" 
                        ValidationGroup="z">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Sehir:</td>
                <td>
                    <asp:DropDownList ID="sehirler" runat="server">
                        <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style8" colspan="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="sehirler" ErrorMessage="Sehir seçiniz" ForeColor="Red" 
                        InitialValue="0" ValidationGroup="z">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Email:</td>
                <td>
                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                </td>
                <td class="style8" colspan="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="email" ErrorMessage="email boş olamaz" ForeColor="Red" 
                        ValidationGroup="z">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="email" ErrorMessage="Adam gibi email gir" ForeColor="Red" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                        ValidationGroup="z">*</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Meslek:</td>
                <td>
                    <asp:DropDownList ID="meslekler" runat="server">
                        <asp:ListItem Value="0">Seçiniz</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style8" colspan="2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="meslekler" ErrorMessage="meslek seçilmeli" ForeColor="Red" 
                        InitialValue="0" ValidationGroup="z">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="4">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Değiştir" 
                        ValidationGroup="z" />
                </td>
            </tr>
        </table>
    
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        DisplayMode="SingleParagraph" ShowMessageBox="True" 
        style="margin-top: 0px" />

</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style4
        {}
        .style5
        {
            width: 224px;
        }
        .style8
        {
            width: 704px;
        }
    </style>
</asp:Content>
