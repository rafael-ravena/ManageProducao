using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageProducao.Api.Model
{
	public class Bebida
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int TipoBebidaId { get; set; }
		public TipoBebida TipoBebida { get; set; }
	}
}
