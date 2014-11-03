using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageProducao.Api.Model
{
	public class BemCasado
	{
		[Key, ForeignKey("Evento")]
		public int EventoId { get; set; }
		public Evento Evento { get; set; }

		public bool FornecidoContratante { get; set; }
		public string Observacoes { get; set; }
		
		public List<BemCasadoEscolhido> BemCasadosEscolhidos { get; set; }
	}
}
