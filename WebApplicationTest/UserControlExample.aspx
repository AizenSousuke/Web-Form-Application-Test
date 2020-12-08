<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserControlExample.aspx.cs" Inherits="WebApplicationTest.UserControlExample" %>

<%@ Register Assembly="WebApplicationTest" Namespace="WebApplicationTest.WebControls" TagPrefix="cc" %>

<%@ Register Src="~/Components/CustomControl.ascx" TagPrefix="components" TagName="CustomControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <components:CustomControl runat="server" ID="cc1"></components:CustomControl>
        <asp:Button runat="server" Text="Click me" OnClick="btn_Click" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label runat="server" ID="label1" Text="<%# Date %>"></asp:Label>
        <asp:Label runat="server" ID="lbl"></asp:Label>
        <asp:Button runat="server" ID="btnCallWebservice" Text="Call webservice" OnClick="btnCallWebservice_Click" />
        <cc:ServerControls ID="ServerControls1" runat="server"  />
        <cc:ServerControls ID="ServerControls2" runat="server" Age="25" />
    </form>
</body>
</html>
