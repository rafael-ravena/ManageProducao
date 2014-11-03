using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageProducao.Api.Model
{
	public class TipoBebida
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public List<Bebida> Bebidas { get; set; }
	}
}
