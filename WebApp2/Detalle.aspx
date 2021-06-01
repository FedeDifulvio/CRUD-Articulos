<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebApp2.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class ="contenedor">
            <div class="tarjeta">
                <div class="contenedor-imagen">
                    <img class="detalle-img" src="<% =detalle.imagenURL%>" alt="Alternate Text" />
                </div>
                <div class="contenedor-info">
                    <h1 class="titles titulo"><%=detalle.Nombre %></h1>
                    <h3 class="titles descripcion" ><% =detalle.Descripcion%></h3>
                    <hr />
                    <h4 class="titles"> <strong class="titles-2">Categoría: </strong><% =detalle.Categoria%></h4>
                    <hr />
                    <h4 class="titles"> <strong class="titles-2">Marca: </strong><% =detalle.Marca%></h4>
                    <hr />
                    <h1 class="titles precio"> $<%= Math.Round(detalle.Precio)%></h1>
                    <br />
                    <br />
                    <button type="button" class="btn btn-primary btn-lg">Agregar al Carrito</button>

                </div>
            </div>
        </div>  
</asp:Content>
