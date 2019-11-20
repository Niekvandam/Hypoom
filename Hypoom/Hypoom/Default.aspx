<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hypoom._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1> LEGE DEFAULT PAGINA </h1>
    <asp:TextBox runat="server" ID="testtextbox"></asp:TextBox>
    <asp:Button runat="server" ID="test" OnClick="test_Click" />
</asp:Content>
