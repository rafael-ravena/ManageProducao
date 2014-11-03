using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManageProducao.Api.Model
{
	public class DecoracaoRecepcao
	{
		[Key, ForeignKey("Decoracao")]
		public int DecoracaoId { get; set; }
		public Decoracao Decoracao { get; set; }
		public string Cores { get; set; }
		public List<Foto> Referencias { get; set; }
		public Arranjo MesasPrincipais { get; set; }
		public Arranjo MesasAltos { get; set; }
		public Arranjo MesasBaixos { get; set; }

		public int MesaBanqueteId { get; set; }
		public TipoAcessorioExtra MesaBanquete
		{
			get
			{
				return (TipoAcessorioExtra)MesaBanqueteId;
			}
			set
			{
				MesaBanqueteId = (int)value;
			}
		}
		public string DescricaoMesaBanquete { get; set; }
		public int FlorDeGuardanapoId { get; set; }
		public TipoAcessorioExtra FlorDeGuardanapo
		{
			get
			{
				return (TipoAcessorioExtra)FlorDeGuardanapoId;
			}
			set
			{
				FlorDeGuardanapoId = (int)value;
			}
		}
		public string DescricaoFlorDeGuardanapo { get; set; }

		public string Observacoes { get; set; }
		public string NaoUsar { get; set; }

		public bool MobiliaLocada { get; set; }
		public string ObservacaoMobilia { get; set; }
		public int FotoMobiliaId { get; set; }
		public Foto FotoMobilia { get; set; }
	}
}
