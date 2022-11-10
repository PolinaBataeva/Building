<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Building.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
   <h3>Наши контакты.</h3>
    <address>
        Батаева Полина Евгеньевна<br />
        Г.Ялта, ул.Халтурина, д.35<br />
        <abbr title="Phone">P:</abbr>
        +79786543432
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:bataeva2@mail.ru">bataeva2@mail.ru</a><br />
        <strong>Marketing:</strong> <a href="mailto:firma@mail/ru">firma@mail/ru</a>
    </address>
</asp:Content>
