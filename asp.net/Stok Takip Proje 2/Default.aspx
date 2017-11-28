<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link rel="stylesheet" type="text/css" href="StyleSheettt.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server"></head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>

    &nbsp;<asp:Label ID="Label2" runat="server" Text="Urun adi :" 
            BorderStyle="None" Font-Names="Courier New" ForeColor="#CCCCCC" 
            Width="129px" Font-Size="15pt"></asp:Label>
        <asp:TextBox ID="Uruntext" runat="server" 
            style="margin-top: 0px; margin-left: 0px;" Width="146px" 
            Font-Names="Courier New"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="       Adet  :" 
            Font-Names="Courier New" ForeColor="#CCCCCC" 
            style="margin-left: 21px; margin-top: 8px" Width="96px" Font-Size="15pt"></asp:Label>
        <asp:TextBox ID="Adettext" runat="server" style="margin-left: 3px" 
            Font-Names="Courier New"></asp:TextBox>
        <asp:Button ID="Kaydetbtn" runat="server" onclick="Kaydetbtn_Click" 
            Text="Kaydet" Width="93px" Height="33px" 
            style="margin-left: 31px; margin-top: 0px" BorderStyle="None" 
            Font-Names="Courier New" Font-Overline="False" Font-Size="13pt" />
        <asp:Button ID="Silbtn" runat="server" Text="Sil" Width="84px" Height="35px" 
            onclick="Silbtn_Click" style="margin-left: 31px" BorderStyle="None" 
            Font-Names="Courier New" Font-Overline="False" Font-Size="13pt" />

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>

               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <br />
               &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <br />
           </ContentTemplate>
       </asp:UpdatePanel>
        <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" 
            GroupItemCount="5">
            <AlternatingItemTemplate>
                <td runat="server" style="background-color: #FFF8DC;">
                    Urunadi:
                    <asp:Label ID="UrunadiLabel" runat="server" Text='<%# Eval("Urunadi") %>' />
                    <br />
                    Adet:
                    <asp:Label ID="AdetLabel" runat="server" Text='<%# Eval("Adet") %>' />
                    <br />
                </td>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <td runat="server" style="background-color: #008A8C; color: #FFFFFF;">
                    Urunadi:
                    <asp:TextBox ID="UrunadiTextBox" runat="server" Text='<%# Bind("Urunadi") %>' />
                    <br />
                    Adet:
                    <asp:TextBox ID="AdetTextBox" runat="server" Text='<%# Bind("Adet") %>' />
                    <br />
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" 
                        Text="Update" />
                    <br />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Cancel" />
                    <br />
                </td>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" 
                    style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>
                            No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <td runat="server" />
            </EmptyItemTemplate>
            <GroupTemplate>
                <tr ID="itemPlaceholderContainer" runat="server">
                    <td ID="itemPlaceholder" runat="server">
                    </td>
                </tr>
            </GroupTemplate>
            <InsertItemTemplate>
                <td runat="server" style="">
                    Urunadi:
                    <asp:TextBox ID="UrunadiTextBox" runat="server" Text='<%# Bind("Urunadi") %>' />
                    <br />
                    Adet:
                    <asp:TextBox ID="AdetTextBox" runat="server" Text='<%# Bind("Adet") %>' />
                    <br />
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" 
                        Text="Insert" />
                    <br />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" 
                        Text="Clear" />
                    <br />
                </td>
            </InsertItemTemplate>
            <ItemTemplate>
                <td runat="server" style="background-color: #DCDCDC; color: #000000;">
                    Urunadi:
                    <asp:Label ID="UrunadiLabel" runat="server" Text='<%# Eval("Urunadi") %>' />
                    <br />
                    Adet:
                    <asp:Label ID="AdetLabel" runat="server" Text='<%# Eval("Adet") %>' />
                    <br />
                </td>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table ID="groupPlaceholderContainer" runat="server" border="1" 
                                style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr ID="groupPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" 
                            
                            style="text-align: center;background-color: #CCCCCC; font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000">
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <td runat="server" 
                    style="background-color: #008A8C; font-weight: bold;color: #FFFFFF;">
                    Urunadi:
                    <asp:Label ID="UrunadiLabel" runat="server" Text='<%# Eval("Urunadi") %>' />
                    <br />
                    Adet:
                    <asp:Label ID="AdetLabel" runat="server" Text='<%# Eval("Adet") %>' />
                    <br />
                </td>
            </SelectedItemTemplate>
        </asp:ListView>

             <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:TakipConnectionString %>" 
            SelectCommand="SELECT * FROM [Takip]"></asp:SqlDataSource>
             </div>
    </form>
</body>
</html>