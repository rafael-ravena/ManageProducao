using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageProducao.Api.Model
{
	public class Decoracao
	{
		public int Id { get; set; }

		[Key, ForeignKey("Evento")]
		public int EventoId { get; set; }
		public Evento Evento { get; set; }

		public int breakitup { get; set; }
		public DecoracaoCerimonia DecoracaoCerimonia { get; set; }
		public DecoracaoRecepcao DecoracaoRecepcao { get; set; }

		public string BouquetNoiva { get; set; }

		public int FotoBouquetNoivaId { get; set; }
		public Foto FotoBouquetNoiva { get; set; }
		
		public bool BouquetJogar { get; set; }
		
		public int LapelaId { get; set; }
		public TipoAcessorioExtra Lapela
		{
			get
			{
				return (TipoAcessorioExtra)LapelaId;
			}
			set
			{
				LapelaId = (int)value;
			}
		}
		public string DescricaoLapela { get; set; }
		
		public int TiaraDaminhaId { get; set; }
		public TipoAcessorioExtra TiaraDaminha
		{
			get
			{
				return (TipoAcessorioExtra)TiaraDaminhaId;
			}
			set
			{
				TiaraDaminhaId = (int)value;
			}
		}
		public string DescricaoTiaraDaminha { get; set; }
		
		public int BouquetDaminhaId { get; set; }
		public TipoAcessorioExtra BouquetDaminha
		{
			get
			{
				return (TipoAcessorioExtra)BouquetDaminhaId;
			}
			set
			{
				BouquetDaminhaId = (int)value;
			}
		}
		public string DescricaoBouquetDaminha { get; set; }
		
		public string Retirada { get; set; }

	}
}
