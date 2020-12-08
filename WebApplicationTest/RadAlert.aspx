<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadAlert.aspx.cs" Inherits="WebApplicationTest.RadAlert" %>


<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<body>
    <form id="form1" runat="server">
        <h1>RadAlert Test</h1>
        <asp:ScriptManager runat="server" ID="scriptmanager"></asp:ScriptManager>

        <telerik:RadWindowManager runat="server" ID="rwmRadWindowManager"></telerik:RadWindowManager>
    </form>
    <script type="text/javascript">
        function callbackfn(req) {
            console.log("Test" + req.toString());
            //window.location.href = "http://google.com";
        }
    </script>
</body>

