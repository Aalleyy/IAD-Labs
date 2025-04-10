<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registration Form</h1>
            <label for="name">Name:</label>
            <input id="name" type="text" name="name" value="" runat="server"/></br>
            <label for="email">email:</label>
            <input id="email" type="text" name="email" value="" runat="server" /></br>
            <label for="phone">phone:</label>
            <input id="phone" type="text" name="phone" value="" runat="server"/></br>
            <label for="cnic">cnic:</label>
            <input id="cnic" type="text" name="phone" value="" runat="server"/></br>

            <input id="add" type="submit" value="Submit" runat="server"/></br>
        </div>
    </form>
</body>
</html>