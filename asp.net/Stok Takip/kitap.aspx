<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="kitap.aspx.cs" Inherits="kitap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>" 
        DeleteCommand="DELETE FROM [kitap] WHERE [id] = ?" 
        InsertCommand="INSERT INTO [kitap] ([id], [kadi], [yazari], [sayfa]) VALUES (?, ?, ?, ?)" 
        ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" 
        SelectCommand="SELECT * FROM [kitap]" 
        UpdateCommand="UPDATE [kitap] SET [kadi] = ?, [yazari] = ?, [sayfa] = ? WHERE [id] = ?">
        <DeleteParameters>
            <asp:Parameter Name="id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="id" Type="Int32" />
            <asp:Parameter Name="kadi" Type="String" />
            <asp:Parameter Name="yazari" Type="String" />
            <asp:Parameter Name="sayfa" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="kadi" Type="String" />
            <asp:Parameter Name="yazari" Type="String" />
            <asp:Parameter Name="sayfa" Type="String" />
            <asp:Parameter Name="id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" 
        Width="997px" BackColor="LightGoldenrodYellow" BorderColor="Tan" 
        BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" 
        style="text-align: center" Height="329px">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" 
                ShowSelectButton="True" />
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" 
                ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="kadi" HeaderText="kadi" SortExpression="kadi" />
            <asp:BoundField DataField="yazari" HeaderText="yazari" 
                SortExpression="yazari" />
            <asp:BoundField DataField="sayfa" HeaderText="sayfa" SortExpression="sayfa" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
            HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
</p>
    <p>
        <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#993333" 
            Text="Kitap Ekle" onclick="Button1_Click" />
    <br />
</p>
</asp:Content>

