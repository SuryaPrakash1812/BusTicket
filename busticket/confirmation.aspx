<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirmation.aspx.cs" Inherits="busticket.confirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="confirmation.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form align="center" id="form1" runat="server">
        <div>
            <h1>Passenger Details</h1>
            <asp:Label runat="server">Name:</asp:Label>
            <asp:TextBox runat="server" ID="passname" ></asp:TextBox>
            <br />
            <asp:Label runat="server">Mobilenumber:</asp:Label>
            <asp:TextBox runat="server" TextMode="Number" ID="passnumber"></asp:TextBox>
            <br />
            <asp:Button ID="btnbook" Text="book" runat="server" OnClick="btnbook_Click" style="height: 29px" />
        </div>
    </form>
</body>
</html>
