<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CallJavaScriptFromCodeBehind.aspx.cs" Inherits="WebApplicationTest.CallJavaScriptFromCodeBehind" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" async="async">
        function someFunction(text) {
            alert(text);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <h1>Test of Loading Javascript from the Code Behind</h1>
        <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" Height="200px" Width="300px">
            <div>
                <telerik:RadButton ID="btnCallJS" runat="server" Text="Call Javascript Function" OnClick="btnCallJS_Click"></telerik:RadButton>
            </div>
        </telerik:RadAjaxPanel>
    </form>
</body>
</html>

