<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListProfits.aspx.cs" Inherits="Building.Pages.AllProfits.ListProfits" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Button ID="ButtonAdd" runat="server" Text="Добавить свединья " PostBackUrl="~/Pages/AllProfits/ListProfits.aspx" />
    <asp:GridView ID="GridViewProfits" runat="server" BackColor="White" OnRowDeleting="GridViewProfits_RowDeleting" OnRowDataBound="GridViewProfits_RowDataBound" BorderColor ="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="IdProfit" HeaderText="Id" SortExpression="IdProfit" />
            <asp:CommandField HeaderText="Удалить" ShowDeleteButton="True" ShowHeader="True" />
            <asp:CommandField HeaderText="Редактировать" ShowEditButton="True" ShowHeader="True" />
            <asp:BoundField DataField="Date" HeaderText="Дата" SortExpression="Date" />
            <asp:BoundField DataField="Profit" HeaderText="Прибыль" SortExpression="Profit" />
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
