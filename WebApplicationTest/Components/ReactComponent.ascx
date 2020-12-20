<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ReactComponent.ascx.cs" Inherits="WebApplicationTest.Components.ReactComponent" %>

<div>
    Test React Component
    <br />
    <asp:TextBox runat="server" ID="textbox" />
    <asp:Button runat="server" ID="button" Text="Click Me" OnClick="button_Click" />
    <asp:Label runat="server" ID="label" Text="Click the button to change me" />
</div>