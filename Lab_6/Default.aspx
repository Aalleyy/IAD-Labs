<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" ViewStateEncryptionMode="Always"%>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Counter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" id="increment" runat="server" onserverclick="Increment_Click" value="Increment" />
            <asp:Label id="lblCount" runat="server" Text="Counter: 0" />
        </div>
    </form>
</body>
</html>