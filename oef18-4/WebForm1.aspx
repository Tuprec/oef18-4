<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="oef18_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Geef je wachtwoord in (<asp:TextBox ID="TextBox2" runat="server" BackColor="Black" BorderColor="Black" BorderStyle="None" Font-Bold="True" Font-Size="Large" ForeColor="White" Width="55px">1234</asp:TextBox>
                )</h1>

            <br />
            Wachtwoord:
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Niet hetzelfde " Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="3 Keer fout!!!!!  time out (5 seconden)" Visible="False"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="check" />

        </div>
    </form>
</body>
</html>
