<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Essens_Anwendung.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList_Name" runat="server">
                <asp:ListItem>R</asp:ListItem>
                <asp:ListItem>S</asp:ListItem>
                <asp:ListItem>H</asp:ListItem>
                <asp:ListItem>N</asp:ListItem>
                <asp:ListItem>M</asp:ListItem>
                <asp:ListItem>N</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList_Essen" runat="server">
                <asp:ListItem>Apfel</asp:ListItem>
                <asp:ListItem>Birne</asp:ListItem>
                <asp:ListItem>Orange</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList_Zusatz" runat="server">
                <asp:ListItem>Gut</asp:ListItem>
                <asp:ListItem>Schlecht</asp:ListItem>
                <asp:ListItem>Super</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button_Auswerten" runat="server" OnClick="Button_Auswerten_Click" Text="Auswerten" />
            <asp:Button ID="Button_Löschen" runat="server" OnClick="Button_Löschen_Click" Text="Löschen" Width="76px" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
