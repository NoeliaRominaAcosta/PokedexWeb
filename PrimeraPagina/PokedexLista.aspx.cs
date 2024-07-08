﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
namespace PrimeraPagina
{
	public partial class WebForm2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				PokemonNegocio negocio = new PokemonNegocio();
				Session.Add("listaPokemons", negocio.listarConSP());
				dgvPokemons.DataSource = Session["listaPokemons"];
				dgvPokemons.DataBind();
			}
		}

		protected void dgvPokemons_PageIndexChanging(object sender, GridViewPageEventArgs e)
		{
			dgvPokemons.PageIndex = e.NewPageIndex;
			dgvPokemons.DataBind();
		}

		protected void dgvPokemons_SelectedIndexChanged(object sender, EventArgs e)
		{
			string id = dgvPokemons.SelectedDataKey.Value.ToString();
			Response.Redirect("FormularioPokemon.aspx?id=" + id);
		}

	}
}