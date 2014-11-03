using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ManageProducao.Api.Model
{
	public class OpcaoBebida
	{
		public int Id { get; set; }

		public bool Externo { get; set; }

		public int BebidaId { get; set; }
		public Bebida Bebida { get; set; }

		public int EventoId { get; set; }
		public Evento Evento { get; set; }
	
		public string Marca { get; set; }
		public int Quantidade { get; set; }

		public string Observacoes { get; set; }
	}
}
