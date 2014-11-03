using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageProducao.Api.Model
{
	public class TipoEvento
	{
		public int Id { get; set; }
		public string Tipo { get; set; }
		public List<ItemRoteiro> RoteiroPadrao { get; set; }
	}
}
