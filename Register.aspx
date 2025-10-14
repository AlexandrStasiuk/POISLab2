<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="POISLab2.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Регистрация пользователя</h2>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    <br /><br />

    <table>
        <tr>
            <td>Имя пользователя:</td>
            <td><asp:TextBox ID="txtUsername" runat="server" /></td>
        </tr>
        <tr>
            <td>Пароль:</td>
            <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td>Подтверждение пароля:</td>
            <td><asp:TextBox ID="txtConfirm" runat="server" TextMode="Password" /></td>
        </tr>
        <tr>
            <td>Email:</td>
            <td><asp:TextBox ID="txtEmail" runat="server" TextMode="Email" /></td>
        </tr>
    </table>

    <br />
    <asp:Button ID="btnRegister" runat="server" Text="Зарегистрироваться" OnClick="btnRegister_Click" />
    <br /><br />

    <asp:Label ID="lblResult" runat="server" Font-Bold="true" ForeColor="Blue"></asp:Label>
</asp:Content>
