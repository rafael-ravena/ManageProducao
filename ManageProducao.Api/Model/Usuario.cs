using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace ManageProducao.Api.Model
{
	public abstract class Usuario
	{
		public int Id { get; set; }
		[Required]
		[Display(Name = "Tipo de usuário")]
		public int TipoUsuarioId { get; set; }
		public TipoUsuario TipoUsuario
		{
			get
			{
				return (TipoUsuario)TipoUsuarioId;
			}
			set
			{
				TipoUsuarioId = (int)value;
			}
		}
		[Required]
		[DataType(DataType.EmailAddress)]
		[Display(Name = "Email address")]
		public string EmailUsuario { get; set; }
		[Required]
		[StringLength(100, ErrorMessage = "Sua {0} deve possuir ao menos {2} caracteres.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Senha")]
		public string SenhaUsuario { get; set; }

	}
	public class AnalistaProducao : Usuario
	{
		public List<Evento> EventosProduzidos { get; set; }
		public string Telefone { get; set; }
	}
	public class AnalistaComercial : Usuario
	{
		public List<Evento> EventosVendidos { get; set; }
	}
	public class Maitre : Usuario
	{
		public List<Evento> EventosGeridos { get; set; }
		public string Telefone { get; set; }
	}
	public enum TipoUsuario
	{
		AnalistaProducao = 1,
		AssistenteProducao = 2,
		GerenteProducao = 3,
		AnalistaComercial = 4,
		AssistenteComercial = 5,
		GerenteComercial = 6,
		Maitre = 7,
		AnalistaFinanceiro = 8,
		AnalistaCompras = 9,
		Diretor = 10
	}
}