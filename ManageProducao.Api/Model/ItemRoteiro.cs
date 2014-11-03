using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageProducao.Api.Model
{
	public class ItemRoteiro
	{
		public long Id { get; set; }
		public int? TipoEventoId { get; set; }
		public TipoEvento TipoEvento { get; set; }
		public int? EventoId { get; set; }
		public Evento Evento { get; set; }
		public byte Hora { get; set; }
		public byte Minuto { get; set; }
		public string Acontecimento { get; set; }
		public string Observacoes { get; set; }
		public bool Importante { get; set; }
	}
}
