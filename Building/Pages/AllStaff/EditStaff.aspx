<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditStaff.aspx.cs" Inherits="Building.Pages.AllStaff.EditStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 style="color: #F1F1F2"><%: Title %></h1>
<br />
<asp:Label ID="LabelMessage" runat="server" Text="Label"></asp:Label>
<table>
   <tr>
<td style="color: #F1F1F2">ФИО</td>
<td>
<asp:TextBox ID="TextBoxFIO" runat="server"></asp:TextBox>
</td>
</tr>
     <tr>
<td style="color: #F1F1F2">Профессия</td>
<td>
<asp:TextBox ID="TextBoxPost" runat="server"></asp:TextBox>
</td>
</tr>
     <tr>
<td style="color: #F1F1F2">Дата рождения</td>
<td>
<asp:TextBox ID="TextBoxDateOfBirth" runat="server"></asp:TextBox>
</td>
</tr>
     <tr>
<td style="color: #F1F1F2">Дата приема на работу</td>
<td>
<asp:TextBox ID="TextBoxDateOfHiring" runat="server"></asp:TextBox>
</td>
</tr>
     <tr>
<td style="color: #F1F1F2">омер телефона</td>
<td>
<asp:TextBox ID="TextBoxPhoneNumb" runat="server"></asp:TextBox>
</td>
</tr>
</table>
<table>
<tr>
<td>
<asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Pages/AllStaff/ListStaff.aspx" style="color: #F1F1F2">Отмена</asp:HyperLink>
</td>
<td>
<asp:Button ID="ButtonSave" runat="server" Text="Сохранить" OnClick="ButtonSave_Click" /></td>
</tr>
</table>
</asp:Content>
