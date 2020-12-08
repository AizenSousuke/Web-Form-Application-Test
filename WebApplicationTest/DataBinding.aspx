<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBinding.aspx.cs" Inherits="WebApplicationTest.DataBinding" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
        <div>
            <h1>Data Binding Example</h1>
            <telerik:RadAjaxPanel ID="RadAjaxPanel1" runat="server" Height="200px" Width="300px">
                ID: <%--<telerik:RadLabel ID="Id" runat="server"></telerik:RadLabel>--%>
                <br />
                ID:
                <telerik:RadTextBox ID="Id" runat="server" Enabled="false"></telerik:RadTextBox>
                <br />
                <!-- Note that the ID must be the same as in the model to bind it -->
                Request Number:
                <telerik:RadTextBox ID="RequestNumber" runat="server" InputType="Number"></telerik:RadTextBox>
                <asp:RequiredFieldValidator runat="server" ID="validator1" ControlToValidate="RequestNumber" ValidationGroup="part1" ErrorMessage="Require Request Number" ForeColor="Red"></asp:RequiredFieldValidator>
                <%--<asp:CustomValidator ForeColor="Red" runat="server" ControlToValidate="RequestNumber" ID="Validator" OnServerValidate="Validator_ServerValidate"></asp:CustomValidator>--%>
                <br />
                Request Title:
                <telerik:RadTextBox ID="RequestTitle" runat="server"></telerik:RadTextBox>
                <%--<asp:DynamicValidator runat="server" ID="Validator2" ControlToValidate="RequestTitle"></asp:DynamicValidator>--%>
                <br />
                <br />
                <telerik:RadTextBox ID="Name" runat="server"></telerik:RadTextBox>
                <asp:RequiredFieldValidator runat="server" ID="validator2" ControlToValidate="Name" ValidationGroup="part1" ErrorMessage="Require Name" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <br />
                Name
                <telerik:RadTextBox runat="server" ID="Nameless"></telerik:RadTextBox>
                <div id="AnotherNestedModel">
                    AnotherNestedModel Name
                    <telerik:RadTextBox runat="server" ID="AnotherNestedModel_Name"></telerik:RadTextBox>
                    <br />
                </div>
                <telerik:RadButton ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"></telerik:RadButton>
                <telerik:RadButton ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"></telerik:RadButton>
                <br />
                <telerik:RadLabel runat="server" ID="DataText"></telerik:RadLabel>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                Sample from object:
                <telerik:RadTextBox ID="lbl2" runat="server" Text="<%# request.RequestTitle %>"></telerik:RadTextBox>
            </telerik:RadAjaxPanel>
        </div>
    </form>
</body>
</html>
