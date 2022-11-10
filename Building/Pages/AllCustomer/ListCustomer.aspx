<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListCustomer.aspx.cs" Inherits="Building.Pages.AllCustomer.ListCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Button ID="Button1" runat="server" Text="Button"  PostBackUrl="~/Pages/AllCustomer/ListCustomer.aspx" />
    <asp:GridView ID="GridViewCustomer" runat="server"  BackColor="White" OnRowDeleting="GridViewCustomer_RowDeleting" OnRowDataBound="GridViewCustomer_RowDataBound" BorderColor ="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
          <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="IdCustomers" HeaderText="Id" SortExpression="IdCustomers" />
            <asp:CommandField HeaderText="Удалить" ShowDeleteButton="True" ShowHeader="True" />
            <asp:CommandField HeaderText="Редактировать" ShowEditButton="True" ShowHeader="True" />
            <asp:BoundField DataField="IdFirm" HeaderText="Id" SortExpression="IdFirm" />
            <asp:BoundField DataField="FIO" HeaderText="ФИО" SortExpression="FIO" />
            <asp:BoundField DataField="IdExpense" HeaderText="Id" SortExpression="IdExpense" />
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
