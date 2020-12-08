<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PartialClassTest.aspx.cs" Inherits="WebApplicationTest.PartialClassTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" ID="Button0" Text="btn0" OnClick="Button0_Click" />
            <asp:Button runat="server" ID="Button1" Text="btn1" />
            <asp:Button runat="server" ID="Button2" Text="btn2" />
            <asp:Button runat="server" ID="Button3" Text="btn3" />
            This is a partial class Test.
            <asp:Button runat="server" ID="btnTest" Text="Click Me" OnClick="btnTest_Click" />
        </div>
    </form>
</body>
</html>
