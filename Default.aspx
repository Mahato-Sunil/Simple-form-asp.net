<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormDisplay.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            UserName :-<asp:TextBox ID="TextBox1" runat="server" Height="41px" style="margin-left: 90px" Width="270px"></asp:TextBox>
        </p>
        <p>
            Email :-
            <asp:TextBox ID="TextBox2" runat="server" Height="39px" style="margin-left: 121px" Width="264px"></asp:TextBox>
        </p>
        <p>
            Address :-<asp:TextBox ID="TextBox3" runat="server" Height="41px" style="margin-left: 106px" Width="269px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="48px" style="margin-left: 191px" Text="Submit" Width="209px" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
