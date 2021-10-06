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
            <asp:Table ID="PersTable" runat="server" />
            <br />
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
            <asp:Table ID="PostTable" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="lblVornamePost" runat="server" Text="Vorname"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbVornamePost" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="lblNachnamePost" runat="server" Text="Nachname"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbNachnamePost" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="lblGeburtsdatumPost" runat="server" Text="Geburtsdatum"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <input type="date" id="tbGeburtstagPost" name="tbGeburtstagPost" runat="server">
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server" />
                    <asp:TableCell runat="server" HorizontalAlign="Right">
                        <asp:Button ID="btnPostPers" runat="server" OnClick="btnPostPers_Click" Text="POST Person" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table> 
            <br />
            <br />
            <asp:Table ID="PutTable" runat="server">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="lblVornamePut" runat="server" Text="Vorname"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbVornamePut" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="lblNachnamePut" runat="server" Text="Nachname"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="tbNachnamePut" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="lblGeburtsdatumPut" runat="server" Text="Geburtsdatum"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <input type="date" id="tbGeburtstagPut" name="tbGeburtstagPut" runat="server">
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server"/>
                    <asp:TableCell runat="server" HorizontalAlign="Right">
                        <asp:Button ID="btnPutPers" runat="server" OnClick="btnPutPers_Click" Text="PUT Person" />
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table> 
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="JsonText" runat="server" Text=""/>
        </div>
    </form>
</body>
</html>
