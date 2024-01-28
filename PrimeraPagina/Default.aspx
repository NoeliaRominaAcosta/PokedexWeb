<%@ Page Title="" Language="C#" MasterPageFile="~/Miimaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PrimeraPagina.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1>Hola</h1>
	<p>Ingresaste a la app</p>
	<div class="row row-cols-1 row-cols-md-3 g-4 container m-2">
		
		<asp:Repeater runat="server" id="repRepetidor">
			<ItemTemplate>
				<div class="card m-2" style="width: 18rem;">
					<img src="<%#Eval("UrlImagen")%>" class="card-img-top" alt="...">
					<div class="card-body p-2 m-2">
						<h5 class="card-title"><%#Eval("Nombre") %></h5>
						<p class="card-text"><%#Eval("Tipo") %></p>
						<p class="card-text"><%#Eval("Descripcion") %></p>
						<p class="card-text"><%#Eval("Debilidad")%></p>
						<a href="DetallePokemon.aspx?id=<%#Eval("Id")%>" class="btn btn-primary">Ver</a>
					</div>
				</div>
			</ItemTemplate>
		</asp:Repeater>
	</div>

</asp:Content>
