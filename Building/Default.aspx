<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Building._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div class="jumbotron">
        <h1>Строительная фирма "Ваш Дом"</h1>
        <p class="lead">Каждый мужчина должен вырастить сына, посадить дерево, остальное сделает наша строительная компания!</p>
        <p><a href="#" class="btn btn-primary btn-lg">Читать далее &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>О нас</h2>
            <p>
            </p>
            <p>
                <a class="btn btn-default" href="https://localhost:44307/About">Подробнее &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Услуги</h2>
            <p>
               Список услуг предостовляемых компанией.
            </p>
            <p>
                <a class="btn btn-default" href="https://localhost:44307/Pages/AllWorkPerfomels/ListWorkPerfomels">Подробнее &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Рабочие</h2>
            <p>
               Список работников , которых вы можете нанять для строительства и благоустройства вашего дома.
            </p>
            <p>
                <a class="btn btn-default" href="https://localhost:44307/Pages/AllStaff/ListStaff">Подробнее &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
