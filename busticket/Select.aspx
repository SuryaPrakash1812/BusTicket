<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Select.aspx.cs" Inherits="busticket.Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" align="center">
        <div id="bookings">
          
        </div>
        <div>
            <h1>Bus Ticket Booking</h1>
            <label for="to">from:</label>
             <asp:DropDownList id="ufrom" name="from" runat="server" >
            <asp:ListItem Value="">Select Source City</asp:ListItem>
            <asp:ListItem Value="banglore">banglore</asp:ListItem>
            <asp:ListItem Value="hyderabad">hyderabad</asp:ListItem>
            <asp:ListItem Value="tirupati">tirupati</asp:ListItem>
        </asp:DropDownList><br /><br />
        <label for="to">To:</label>
        <asp:DropDownList id="uto" name="to" runat="server" >
            <asp:ListItem Value="">Select Destination City</asp:ListItem>
            <asp:ListItem Value="tirupati">tirupati</asp:ListItem>
            <asp:ListItem Value="hyderabad"> hyderabad</asp:ListItem>
            <asp:ListItem Value="banglore">banglore</asp:ListItem>
        </asp:DropDownList><br /><br />
            <asp:Label runat="server">Date:</asp:Label>
            
            <input type="date" id="dt" runat="server" />
        <asp:Button ID="bookBtn" runat="server" Text="Book Now" OnClick="bookBtn_Click"/> 
        </div>
    </form>
</body>
</html>
