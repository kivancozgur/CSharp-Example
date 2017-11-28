<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function Text1_onclick() {

        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Klasör" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="dosya" 
            style="height: 26px" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <input id="Text1" type="text" onclick="return Text1_onclick()" /><br />
        <asp:ListBox ID="ListBox1" runat="server" Height="357px" Width="364px">
        </asp:ListBox>
    
    </div>
    </form>
</body>
</html>
