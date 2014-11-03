using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageProducao.Api.Model
{
	public class Evento
	{
		public int Id { get; set; }

		public AnalistaProducao ProdutorResponsavel { get; set; }
		public AnalistaComercial NegociadoPor { get; set; }
		public Maitre ExecutorResponsavel { get; set; }

		public int CasaId { get; set; }
		public Casa Casa { get; set; }

		public int TipoEventoId { get; set; }
		public TipoEvento TipoEvento { get; set; }
		public string Contrato { get; set; }
		public string Contratante { get; set; }
		public string CPFContratante { get; set; }
		public string RGContratante { get; set; }
		public string TelefoneContratante { get; set; }
		public string EmailContratante { get; set; }
		public string Cliente { get; set; }

		public DateTime DataEvento { get; set; }
		public byte HoraInicio { get; set; }
		public byte MinutoInicio { get; set; }
		public byte HoraTermino { get; set; }
		public byte MinutoTermino { get; set; }
		public short PAX { get; set; }

		public bool UtilizaAnexo { get; set; }
		public byte AnexoHoraInicio { get; set; }
		public byte AnexoMinutoInicio { get; set; }
		public byte AnexoHoraTermino { get; set; }
		public byte AnexoMinutoTermino { get; set; }

		public bool PossuiCerimonia { get; set; }
		
		public int CardapioId { get; set; }
		public Cardapio Cardapio { get; set; }

		public List<OpcaoBebida> OpcoesBebida { get; set; }

		public BemCasado BemCasado { get; set; }

		public Doce Doce { get; set; }

		public int VJId { get; set; }
		public TipoAcessorioExtra VJ
		{
			get
			{
				return (TipoAcessorioExtra)VJId;
			}
			set
			{
				VJId = (int)value;
			}
		}
		public string DescricaoVJ { get; set; }

		public bool DJ { get; set; }
		public string DescricaoDJ { get; set; }

		public bool MobiliaLocada { get; set; }
		public string DescricaoMobiliaLocada { get; set; }

		public int TipoServicoId { get; set; }
		public TipoServico TipoServico { get; set; }

		public List<Prato> PratosSelecionados { get; set; }

		public List<ItemRoteiro> Roteiro { get; set; }

		public Decoracao Decoracao { get; set; }

	}
}