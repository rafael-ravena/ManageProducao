using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;


namespace ManageProducao.Api.Model
{
	public class DecoracaoCerimonia
	{
		[Key, ForeignKey("Decoracao")]
		public int DecoracaoId { get; set; }
		public Decoracao Decoracao { get; set; }
		public string Cores { get; set; }
		public List<Foto> Referencias { get; set; }
		public string Especificacoes { get; set; }
		public Corredor Corredor { get; set; }
		public Altar Altar { get; set; }
		public string FundoAltar { get; set; }

		public string Observacoes { get; set; }
	}
}
