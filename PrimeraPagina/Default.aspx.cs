using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using negocio;
using dominio;
namespace PrimeraPagina
{
	public partial class WebForm1 : System.Web.UI.Page
		
	{
		public List<Pokemon> ListaPokemon { get; set; }
		protected void Page_Load(object sender, EventArgs e)
		{
			PokemonNegocio negocio = new PokemonNegocio();
			ListaPokemon = negocio.listarConSP();
			if (!IsPostBack)
			{
				repRepetidor.DataSource = ListaPokemon;
				repRepetidor.DataBind();
			}
			
			
		}

		protected void btnEjemplo_Click(object sender, EventArgs e)
		{
			string valor = ((Button)sender).CommandArgument; 

			//lo castea para poder convertirlo en boton. El commandArgument es el valor que le pasa en el argumento = ID
		}
	}
}