<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calenderajax.aspx.cs" Inherits="Calenderajax" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" 
            EnableScriptGlobalization="True">
        </asp:ToolkitScriptManager>
        <br />
        Tarih Seçin:<asp:TextBox 
            ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="23px" 
            ImageUrl="~/img/takmin.png" Width="20px" />
        <asp:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="TextBox1" PopupButtonID="ImageButton1">
            
            

        </asp:CalendarExtender>
    </div>
    </form>
</body>
</html>
