using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageProducao.Api.Model
{
	public class Doce
	{
		[Key, ForeignKey("Decoracao")]
		public int DecoracaoId { get; set; }
		public Decoracao Decoracao { get; set; }

		public bool FornecidoContratante { get; set; }
		public string Observacoes { get; set; }

		public List<DoceEscolhido> Doces { get; set; }
	}
}
