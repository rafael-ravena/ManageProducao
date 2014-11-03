using ManageProducao.Api.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManageProducao.Api.Data
{
    public class Context : DbContext
    {
        public Context()
            : base("Bisutti")
        {
        }
        public DbSet<Altar> Altares { get; set; }
        public DbSet<Arranjo> Arranjos { get; set; }
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<BemCasado> BemCasados { get; set; }
        public DbSet<BemCasadoEscolhido> BemCasadosEscolhidos { get; set; }
        public DbSet<Cardapio> Cardapios { get; set; }
        public DbSet<Casa> Casas { get; set; }
        public DbSet<CorEmbalagem> CoresEmbalagem { get; set; }
        public DbSet<CorFita> CoresFita { get; set; }
        public DbSet<Corredor> Corredores { get; set; }
        public DbSet<CorTapete> CoresTapete { get; set; }
        public DbSet<Decoracao> Decoracoes { get; set; }
        public DbSet<DecoracaoCerimonia> DecoracoesCerimonia { get; set; }
        public DbSet<DecoracaoRecepcao> DecoracoesRecepcao { get; set; }
        public DbSet<Doce> Doces { get; set; }
        public DbSet<DoceEscolhido> DocesEscolhidos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<ItemRoteiro> ItensRoteiro { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<OpcaoBebida> OpcoesBebida { get; set; }
        public DbSet<OrdemServico> OrdensServico { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<TipoAlimentacao> TiposAlimentacao { get; set; }
        public DbSet<TipoArranjo> TiposArranjo { get; set; }
        public DbSet<TipoBebida> TiposBebida { get; set; }
        public DbSet<TipoDoce> TiposDoce { get; set; }
        public DbSet<TipoEvento> TiposEvento { get; set; }
        public DbSet<TipoForma> TiposForma { get; set; }
        public DbSet<TipoServico> TiposServico { get; set; }
        public DbSet<TipoVela> TiposVela { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

    }
}