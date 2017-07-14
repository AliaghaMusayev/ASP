<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="IsPostback_Lesson.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 88px;
        }
        .auto-style3 {
            width: 10px;
        }
    </style>
</head>
<body style="width: 375px">
    <form id="form1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style3">Name:</td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox1" runat="server" Width="229px"></asp:TextBox>
        </tr>
        <tr>
            <td class="auto-style3">Surname:</td>
            <td class="auto-style2">
                <asp:TextBox ID="TextBox2" runat="server" Width="229px"></asp:TextBox>
        </tr>
        <tr>
            <td class="auto-style3">City:</td>
            <td class="auto-style2">
                <asp:DropDownList ID="drpDown" runat="server" Width="161px">
                </asp:DropDownList>
        </tr>
        <tr>
            <td>
                
            </td>
            <td class="auto-style2">
                <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click"/>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
