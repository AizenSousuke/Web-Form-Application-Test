<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FluentValidator.aspx.cs" Inherits="WebApplicationTest.FluentValidator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="RequestNumber" OnTextChanged="RequestNumber_TextChanged"></asp:TextBox>
            <asp:CustomValidator runat="server" ID="CustomValidator" ControlToValidate="RequestNumber" />
            <asp:Button runat="server" ID="Submit" OnClick="submit_Click" Text="Validate" />
            <asp:Label runat="server" ID="ValidationMessage"></asp:Label>
        </div>
    </form>
</body>
</html>
