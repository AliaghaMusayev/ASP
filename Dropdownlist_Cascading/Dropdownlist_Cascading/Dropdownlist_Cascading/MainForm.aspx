<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="Dropdownlist_Cascading.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DropDownList ID="drpName" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpName_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="drpAge" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
