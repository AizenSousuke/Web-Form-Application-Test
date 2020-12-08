<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomControl.ascx.cs" Inherits="WebApplicationTest.Components.CustomControl" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<div class="grid">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <div>Custom Control</div>
    <span>Variable: <asp:Label runat="server" ID="var"></asp:Label></span>
    <telerik:RadDropDownList runat="server" ID="ddl"></telerik:RadDropDownList>
</div>