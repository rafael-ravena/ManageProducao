using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageProducao.Api.Model
{
	public class DoceEscolhido
	{
		public int Id { get; set; }

		public int DoceId { get; set; }
		public Doce Doce { get; set; }

		public int TipoDoceId { get; set; }
		public TipoDoce TipoDoce { get; set; }

		public int TipoFormaId { get; set; }
		public TipoForma TipoForma { get; set; }

		public int Quantidade { get; set; }

		public string Observacoes { get; set; }

	}
}
