<%@ Page Title="" Language="C#" MasterPageFile="~/Ziyaretci.master" AutoEventWireup="true" CodeFile="Siparisleriniz.aspx.cs" Inherits="Siparisleriniz" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Table ID="Table1" runat="server" Height="20px" Width="485px">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server">Sipariş No</asp:TableCell>
            <asp:TableCell runat="server">Tarihi</asp:TableCell>
            <asp:TableCell runat="server">Detay</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>

