<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Success</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Success!</p>
        <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_OnClick"/>
    </div>
    </form>
</body>
</html>
