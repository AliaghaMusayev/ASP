<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="JavaScriptConfirms.Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="Button1" runat="server" Text="ClickMe" OnClientClick="return confirm('Are you sure?')" OnClick="Button1_Click" OnCommand="Command_Handler"
                CommandName="ClickSimpleButton"/>
            <br />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="45px" ImageUrl="~/Images/freepik.jpg" Width="81px" OnClientClick="alert('Upssssss stop action')" 
                Oncommand="Command_Handler" CommandName="ClickImageButton"/>
            <br />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" OnCommand="Command_Handler" CommandName="ClickLinkButton">ClickMe</asp:LinkButton>

        </div>
    </form>
</body>
</html>
