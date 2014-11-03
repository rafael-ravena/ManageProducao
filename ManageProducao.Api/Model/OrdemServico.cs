using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ManageProducao.Api.Model
{
	public class OrdemServico
	{
		public int Id { get; set; }
		public int EventoId { get; set; }
		public Evento Evento { get; set; }
		public byte Versao { get; set; }
		public DateTime UltimaModificacao { get; set; }
		public Dictionary<string, bool> AtributosAlterados { get; set; }
	}
}