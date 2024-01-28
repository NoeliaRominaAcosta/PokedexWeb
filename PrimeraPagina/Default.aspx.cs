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
			repRepetidor.DataSource = ListaPokemon;
			repRepetidor.DataBind();
			
			
		}
	}
}