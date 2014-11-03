using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageProducao.Api.Model
{
	public class BemCasadoEscolhido
	{
		public int Id { get; set; }
		public int CorEmbalagemId { get; set; }
		public CorEmbalagem CorEmbalagem { get; set; }
		public int CorFitaId { get; set; }
		public CorFita CorFita { get; set; }
		public int Quantidade { get; set; }
		public string Observacoes { get; set; }
	}
}
