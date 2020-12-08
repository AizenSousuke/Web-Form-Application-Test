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
        <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server">
            <div>
                <!-- Change to radlabel only affects the ones in the same ajax panel (from btnCallJS) -->
                <telerik:RadLabel ID="radLabel" runat="server" Text="No text"></telerik:RadLabel>
                <telerik:RadButton ID="btnCallJS" runat="server" Text="Call Javascript Function" OnClick="btnCallJS_Click"></telerik:RadButton>
            </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
            <h5>Press the button to ajax</h5>
            <telerik:RadTextBox ID="RadTextBox1" runat="server" EmptyMessage="please fill this up"></telerik:RadTextBox>
            <telerik:RadTextBox ID="RadTextBox2" runat="server" EmptyMessage="please fill this up"></telerik:RadTextBox>
            <asp:CompareValidator runat="server" ControlToCompare="RadTextBox1" ControlToValidate="RadTextBox2" ErrorMessage="Something is wrong"></asp:CompareValidator>
            <telerik:RadButton runat="server" ID="btnSubmit" Text="Submit" OnClick="btnSubmit_Click"></telerik:RadButton>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
        </telerik:RadAjaxPanel>
    </form>
</body>
</html>

