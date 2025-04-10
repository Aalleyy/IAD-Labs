<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registration Form</h1>
            <label for="cnic">CNIC:</label>
            <input id="cnic" type="text" runat="server" /><br />
            <label for="fname">First Name:</label>
            <input id="fname" type="text" runat="server" /><br />
            <label for="lname">Last Name:</label>
            <input id="lname" type="text" runat="server" /><br />
            <label for="email">Email:</label>
            <input id="email" type="text" runat="server" /><br />
            <label for="phone">Phone No:</label>
            <input id="phone" type="text" runat="server" /><br />
            <label for="gender">Gender (M/F):</label>
            <input id="gender" type="text" runat="server" /><br />
            <label for="city">City:</label>
            <input id="city" type="text" runat="server" /><br />
            <label for="state">State:</label>
            <input id="state" type="text" runat="server" /><br />
            <label for="postal">Postal Code:</label>
            <input id="postal" type="text" runat="server" /><br />
            <label for="country">Country:</label>
            <input id="country" type="text" runat="server" /><br />
            <label for="role">Role:</label>
            <input id="role" type="text" runat="server" /><br />
            <label for="password">Password:</label>
            <input id="password" type="text" runat="server" /><br />

            <input id="add" type="submit" value="Submit" runat="server" onserverclick="add_ServerClick" /><br />
        </div>
    </form>
</body>
</html>
