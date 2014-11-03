using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace ManageProducao.Api.Model
{
	public class Prato
	{
		public int Id { get; set; }
		[Display(Name = "Grupo de Prato")]
		public int TipoAlimentacaoId { get; set; }
		public TipoAlimentacao TipoAlimentacao { get; set; }
		public string Nome { get; set; }
		public List<Cardapio> Cardapios { get; set; }
		public int meuPau { get; set; }
	}
}
