using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace ManageProducao.Api.Model
{
	public class Corredor
	{
		public int Id { get; set; }
		public int CorTapeteId { get; set; }
		public CorTapete CorTapete { get; set; }
		public List<TipoArranjo> TiposArranjo { get; set; }
		public string Observacoes { get; set; }
		public List<TipoVela> TiposVela { get; set; }
		[Display(Name = "Folhas secas na lateral:")]
		public bool FolhasSecas { get; set; }
		public string ObservacaoCorredor { get; set; }

	}
}
