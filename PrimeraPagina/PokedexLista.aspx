<%@ Page Title="" Language="C#" MasterPageFile="~/Miimaster.Master" AutoEventWireup="true" CodeBehind="PokedexLista.aspx.cs" Inherits="PrimeraPagina.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h1>Lista de pokemons</h1>
	
	 <asp:GridView ID="dgvPokemons" runat="server" DataKeyNames="Id"
        CssClass="table" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Número" DataField="Numero" />
            <asp:BoundField HeaderText="Tipo" DataField="Tipo.Descripcion" />
           
        </Columns>
    </asp:GridView>
</asp:Content>
