<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Username_Label" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Password_Label" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Submit" runat="server" Text="Log in" OnClick="Submit_Click"/>
        <asp:CheckBox ID="RememberMe" runat="server" />
    
    </div>
    </form>
</body>
</html>
