<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="busticket.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" align="center">
        <div>
             <h1>Bus Ticket App</h1>
           <div class="form-group">
    <label for="username">Username:</label>
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
</div>
<div class="form-group">
    <label for="password">Password:</label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
</div>
<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" BackColor="Aqua" ForeColor="Black" />
          <asp:Button runat="server" Text="signup" ID="btn_signup" OnClick="btn_signup_Click" BackColor="Aqua" ForeColor="Black" />
        </div>
    </form>
</body>
</html>
