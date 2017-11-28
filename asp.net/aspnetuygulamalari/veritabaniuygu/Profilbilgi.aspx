<%@ Page Title="" Language="C#" MasterPageFile="~/Ziyaretci.master" AutoEventWireup="true" CodeFile="Profilbilgi.aspx.cs" Inherits="Profilbilgi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:HyperLink ID="HyperLink4" runat="server" 
    NavigateUrl="~/Uyedegistir.aspx">Üyelik Bilgileriniz</asp:HyperLink>
<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Siparisleriniz.aspx">Siparişleriniz</asp:HyperLink>
</asp:Content>

