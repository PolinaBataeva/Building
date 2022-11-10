<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditProfits.aspx.cs" Inherits="Building.Pages.AllProfits.EditProfits" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <h1 style="color: #F1F1F2"><%: Title %></h1>
<br />
<asp:Label ID="LabelMessage" runat="server" Text="Label"></asp:Label>
<table>
   <tr>
<td style="color: #F1F1F2">Дата</td>
<td>
<asp:TextBox ID="TextBoxDate" runat="server"></asp:TextBox>
</td>
</tr>
     <tr>
<td style="color: #F1F1F2">Прибыль</td>
<td>
<asp:TextBox ID="TextBoxProfits" runat="server"></asp:TextBox>
</td>
</tr>
</table>
<table>
<tr>
<td>
<asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Pages/AllProfits/ListProfits.aspx" style="color: #F1F1F2">Отмена</asp:HyperLink>
</td>
<td>
<asp:Button ID="ButtonSave" runat="server" Text="Сохранить" OnClick="ButtonSave_Click" /></td>
</tr>
</table>
</asp:Content>
