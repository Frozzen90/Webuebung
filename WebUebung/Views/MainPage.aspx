<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="WebUebung.Views.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #TextArea1 {
            width: 656px;
            height: 196px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnID" runat="server" OnClick="btnID_Click" Text="GET Person mit ID" Width="164px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAll" runat="server" OnClick="btnAll_Click" Text="GET alle Personen" />
            <br />
            <br />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="DELETE Person mit ID" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblVorname" runat="server" Text="Vorname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbVorname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblNachname" runat="server" Text="Nachname"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbNachname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblGeburtsdatum" runat="server" Text="Geburtsdatum"></asp:Label>
&nbsp;
            <asp:TextBox ID="tbGeburtstag" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnPutPers" runat="server" OnClick="btnPutPers_Click" Text="PUT Person" />
            &nbsp;&nbsp;
            <asp:Button ID="btnPostPers" runat="server" OnClick="btnPostPers_Click" Text="POST Person" />
            <br />
            <br />
            <asp:Label ID="JsonText" runat="server" Text=""/>
        </div>
    </form>
</body>
</html>
