<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionState2.aspx.cs" Inherits="ASP_Learning1.SessionState2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="TextBox1" runat="server" Width="192px"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Click Me1" Width="79px" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Click Me2" Width="79px" />
    </div>
    </form>
</body>
</html>
