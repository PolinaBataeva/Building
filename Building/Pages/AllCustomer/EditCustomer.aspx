<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditCustomer.aspx.cs" Inherits="Building.Pages.AllCustomer.EditCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1 style="color: #F1F1F2"><%: Title %></h1>
<br />
<asp:Label ID="LabelMessage" runat="server" Text="Label"></asp:Label>
<table>
   <tr>
<td style="color: #F1F1F2">Фамилия Студента</td>
<td>
<asp:TextBox ID="TextBoxFIO" runat="server"></asp:TextBox>
</td>
</tr>
</table>
<table>
<tr>
<td>
<asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Pages/AllCustomer/ListCustomer.aspx" style="color: #F1F1F2">Отмена</asp:HyperLink>
</td>
<td>
<asp:Button ID="ButtonSave" runat="server" Text="Сохранить" OnClick="ButtonSave_Click" /></td>
</tr>
</table>
</asp:Content>
