<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="busticket.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="signup.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" align="center">
        <div><asp:Label runat="server">Name:</asp:Label>
            <asp:TextBox ID="susername" runat="server" ></asp:TextBox>
            <br />

            <asp:Label runat="server">Email:</asp:Label>
            <asp:TextBox runat="server" ID="semail" TextMode="Email"></asp:TextBox>
            <br />
            
            <asp:Label runat="server">password</asp:Label>
            <asp:TextBox runat="server" ID="spassword" ></asp:TextBox>
            <br />
            
            <asp:Button runat="server" Text="save" OnClick="Unnamed4_Click" />
        </div>
    </form>
</body>
</html>
