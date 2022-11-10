<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListExrensess.aspx.cs" Inherits="Building.Pages.AllExrensess.ListExrensess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <asp:Button ID="ButtonAdd" runat="server" Text="Добавить свединья " PostBackUrl="~/Pages/AllExrensess/ListExrensess.aspx" />
    <asp:GridView ID="GridViewExrensess" runat="server" BackColor="White" OnRowDeleting="GridViewExrensess_RowDeleting" OnRowDataBound="GridViewExrensess_RowDataBound" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="IdExrenses" HeaderText="Id" SortExpression="IdExrenses" />
            <asp:CommandField HeaderText="Удалить" ShowDeleteButton="True" ShowHeader="True" />
            <asp:CommandField HeaderText="Редактировать" ShowEditButton="True" ShowHeader="True" />
            <asp:BoundField DataField="WorkPerformel" HeaderText="Выполненяемые работы" SortExpression="WorkPerformel" />
            <asp:BoundField DataField="CostAmount" HeaderText="Сумма затрат" SortExpression="CostAmount" />
        </Columns>
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <SortedAscendingCellStyle BackColor="#F4F4FD" />
        <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
        <SortedDescendingCellStyle BackColor="#D8D8F0" />
        <SortedDescendingHeaderStyle BackColor="#3E3277" />
    </asp:GridView>
</asp:Content>
