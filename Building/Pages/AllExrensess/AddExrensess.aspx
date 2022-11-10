<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddExrensess.aspx.cs" Inherits="Building.Pages.AllExrensess.AddExrensess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h1 style="color: #F1F1F2"><%: Title %></h1>
<br />
<table>
   <tr>
<td style="color: #F1F1F2">Выполняемые работы</td>
<td>
<asp:TextBox ID="TextBoxWorkPerformel" runat="server"></asp:TextBox>
</td>
</tr>
      <tr>
<td style="color: #F1F1F2">Затраты</td>
<td>
<asp:TextBox ID="TextBoxCostAmount" runat="server"></asp:TextBox>
</td>
</tr>
</table>
<table>
<tr>
<td>
<asp:HyperLink ID="HyperLinkCancel" runat="server" NavigateUrl="~/Pages/AllExrensess/ListExrensess.aspx" style="color: #F1F1F2">Отмена</asp:HyperLink>
</td>
<td>
<asp:Button ID="ButtonSave" runat="server" Text="Сохранить" OnClick="ButtonSave_Click" /></td>
</tr>
</table>
</asp:Content>
