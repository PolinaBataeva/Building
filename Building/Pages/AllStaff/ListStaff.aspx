<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListStaff.aspx.cs" Inherits="Building.Pages.AllStaff.ListStaff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <asp:Button ID="ButtonAdd" runat="server" Text="Добавить свединья " PostBackUrl="~/Pages/AllStaff/ListStaff.aspx" />
    <asp:GridView ID="GridViewStaffs" runat="server" BackColor="White" OnRowDeleting="GridViewStaffs_RowDeleting" OnRowDataBound="GridViewStaffs_RowDataBound" BorderColor ="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
        <AlternatingRowStyle BackColor="#F7F7F7" />
        <Columns>
            <asp:BoundField DataField="IdStaff" HeaderText="Id" SortExpression="IdFirms" />
            <asp:CommandField HeaderText="Удалить" ShowDeleteButton="True" ShowHeader="True" />
            <asp:CommandField HeaderText="Редактировать" ShowEditButton="True" ShowHeader="True" />
            <asp:BoundField DataField="FIO" HeaderText="ФИО" SortExpression="FIO" />
            <asp:BoundField DataField="Post" HeaderText="Профессия" SortExpression="Post" />
            <asp:BoundField DataField="DateOfBirth" HeaderText="Дата рождения" SortExpression="DateOfBirth" />
            <asp:BoundField DataField="DateOfHiring" HeaderText="Дата принятия на работу" SortExpression="DateOfHiring" />
            <asp:BoundField DataField="PhoneNumb" HeaderText="Номер телефона" SortExpression="PhoneNumb" />
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
