using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageProducao.Api.Model
{
	public class Cardapio
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public List<Prato> OpcoesAlimentacao { get; set; }
	}
}
