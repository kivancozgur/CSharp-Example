<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ekle.aspx.cs" Inherits="ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style3
        {
            width: 100%;
            height: 181px;
        }
        .style4
        {
        }
        .style5
        {
            width: 128px;
            height: 23px;
        }
        .style6
        {
            height: 23px;
        }
        .style7
        {
            width: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString7 %>" 
            DeleteCommand="DELETE FROM [kitap] WHERE [id] = ?" 
            InsertCommand="INSERT INTO [kitap] ([kadi], [yazari], [sayfa]) VALUES (?, ?, ?)" 
            ProviderName="<%$ ConnectionStrings:ConnectionString7.ProviderName %>" 
            SelectCommand="SELECT * FROM [kitap]" 
            
            UpdateCommand="UPDATE [kitap] SET [kadi] = ?, [yazari] = ?, [sayfa] = ? WHERE [id] = ?">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="TextBox1" Name="kadi" PropertyName="Text" 
                    Type="String" />
                <asp:ControlParameter ControlID="TextBox2" Name="yazari" PropertyName="Text" 
                    Type="String" />
                <asp:ControlParameter ControlID="TextBox3" Name="sayfa" PropertyName="Text" 
                    Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="kadi" Type="String" />
                <asp:Parameter Name="yazari" Type="String" />
                <asp:Parameter Name="sayfa" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <table class="style3">
            <tr>
                <td class="style7">
                    Kitap Adı</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Yazarı</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    Sayfa Sayısı</td>
                <td class="style6">
                    <asp:TextBox ID="TextBox3" runat="server" Width="78px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style7">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4" colspan="2">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#663300" 
                        Text="Yeni Kayıt" />
&nbsp;<asp:Button ID="Button2" runat="server" Font-Bold="True" ForeColor="#CC6600" 
                        onclick="Button2_Click" Text="Kitap Ekle" />
&nbsp;<asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#006600"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
    </p>
</asp:Content>

