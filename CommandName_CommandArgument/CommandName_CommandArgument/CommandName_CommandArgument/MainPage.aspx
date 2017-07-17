<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="CommandName_CommandArgument.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <!-- 
    OnCommand - bu onu bildirir ki OnCommand eventinde ne yerine yetirilecek.. burada her hansi metod da yerine yetrile biler ve ya click event cagirila biler ve s.
    CommandName -  burada icra edilecek emre ad verirsen.. yeni OnCommand ile hansi emr icra olunacaqsa ona ad verirsen.. sora rahatliqla icra olunan emri log kimi tutmaq olur.. Koda bax
    CommandArgument - bu da command name kimi eynidir.. sadece burda arqument ad verirsen... bu o halda istifadeye rahatdir ki eyni tipli iki emr olanda onlari basqa ferqli sub
        value ile teyin etmek ucun.. meselen CommandAdlarin eyni veririk yeni eyni klasdadirlar.. Ancaq arqumentleri ferqlidir
         -->
        <asp:Button ID="Button1" runat="server" Text="ClickMe1" OnCommand="Command_Handler" CommandName="ClickMe1"/>
        <asp:Button ID="Button2" runat="server" Text="ClickMe2" OnCommand="Command_Handler" CommandName="ClickMe2"/>
        <asp:Button ID="Button3" runat="server" Text="RepeatClick1" OnCommand="Command_Handler" CommandName="Repeat" CommandArgument="Click1"/>
        <asp:Button ID="Button4" runat="server" Text="RepeatClick2" OnCommand="Command_Handler" CommandName="Repeat" CommandArgument="Click2"/>
    
        <br />
        <br />
        <asp:Label ID="lblClicked" runat="server" Text="No button clicked"></asp:Label>
    
    </div>
    </form>
</body>
</html>
