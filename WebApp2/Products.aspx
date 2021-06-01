<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebApp2.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <h1 class="col-md-4"></h1>
            <h1 class="col-md-4 mt-5 title">Products</h1>
            <h1 class="col-md-4"></h1>
        </div>
        <div class="row mt-5">
            <% foreach (Dominio.Articulos item in lista)
               {
                %>
                <div class="col-md-4 mb-5">
                    <div class="card" style="width: 18rem;" onclick="">
                        <img src="<%=imageError(item.imagenURL) ? noImage : item.imagenURL %>" 
                            class="card-img-top" alt="...">
                        <div class="card-body">
                            <h5 class="card-title"><%=item.Nombre %></h5>
                            <p class="card-text"><%=item.Descripcion %></p> 
                        </div>
                        <ul class="list-group list-group-flush">
                            <li class="list-group-item fw-bold" style="font-size : 30px; text-align:center"> $<%= Math.Round(item.Precio)%></li>
                        </ul>
                        <a href="Detalle.aspx?id=<%=item.Id %>" type="button" class="btn btn-dark">Detalle</a>     
                    </div>
                </div>
                <%
               }
            %>
        </div>
    </div>
</asp:Content>
