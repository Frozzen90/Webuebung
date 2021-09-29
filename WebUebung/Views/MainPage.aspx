<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebUebung.Views.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" />
            <asp:Button ID="btnID" runat="server" OnClick="btnID_Click" Text="Person mit ID bearbeiten" />
            <br />
            <br />
            <asp:Button ID="btnAll" runat="server" OnClick="btnAll_Click" Text="Alle Personen bearbeiten" />
        </div>
    </form>
</body>
</html>
