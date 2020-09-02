<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModelViewPresenterExample.aspx.cs" Inherits="WebApplicationTest.ModelViewPresenterExample" %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>
        <div>
            <div>Cashier Example - View</div>
            <div>
                <div>
                    <telerik:RadLabel ID="lbl" runat="server" Text="Nothing shown"></telerik:RadLabel>
                </div>
                <div>
                    <telerik:RadTextBox ID="txtField" runat="server" InputType="Number"></telerik:RadTextBox>
                </div>
                <telerik:RadButton ID="btn" runat="server" Text="RadButton" OnClick="btn_Click">
                </telerik:RadButton>
                
            </div>
        </div>
    </form>
</body>
</html>
