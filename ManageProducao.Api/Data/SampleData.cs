using ManageProducao.Api.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManageProducao.Api.Data
{
    public class SampleData : DropCreateDatabaseIfModelChanges<Context>
    {
		protected override void Seed(Context context)
		{
			context.Casas.Add(new Casa { Nome = "Berrini WTC", Endereco = "Rua James Joule, 65", Sigla = "VBBE" });
			context.Casas.Add(new Casa { Nome = "Casa do Ator", Endereco = "Rua Casa do Ator, 642", Sigla = "VBCA" });
			context.Casas.Add(new Casa { Nome = "Gomes de Carvalho", Endereco = "Rua Gomes de Carvalho, 412", Sigla = "VBGC" });
			context.Casas.Add(new Casa { Nome = "Quatá", Endereco = "Rua Quatá, 579", Sigla = "VBQT" });
			context.Casas.Add(new Casa { Nome = "Tenerife", Endereco = "Rua Tenerife, 170", Sigla = "VBTE" });
			context.Casas.Add(new Casa { Nome = "011 Eventos", Endereco = "Rua Alvorada, 1035", Sigla = "011" });
			context.SaveChanges();

			context.TiposEvento.Add(new TipoEvento { Tipo = "Bar-mitzva" });
			context.TiposEvento.Add(new TipoEvento { Tipo = "Bat-mitzva" });
			context.TiposEvento.Add(new TipoEvento { Tipo = "Casamento" });
			context.TiposEvento.Add(new TipoEvento { Tipo = "Corporativo" });
			context.TiposEvento.Add(new TipoEvento { Tipo = "Debutante" });
			context.TiposEvento.Add(new TipoEvento { Tipo = "Outro" });
			context.SaveChanges();

			context.TiposServico.Add(new TipoServico { Nome = "Franco-Americano" });
			context.TiposServico.Add(new TipoServico { Nome = "Inglesa" });
			context.TiposServico.Add(new TipoServico { Nome = "Boteco" });
			context.SaveChanges();

			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Coquetel Frio" });
			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Coquetel Quente" });
			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Finger Food" });
			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Salada" });
			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Massa" });
			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Carne Vermelha" });
			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Carne Branca" });
			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Acompanhamento" });
			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Acompanhamento Carbo" });
			context.TiposAlimentacao.Add(new TipoAlimentacao { Nome = "Sobremesa" });
			context.SaveChanges();

			List<TipoAlimentacao> ta = context.TiposAlimentacao.ToList();

			context.Pratos.Add(new Prato { Nome = "Coquetel de Camarão com molho Tarê", TipoAlimentacaoId = ta[0].Id });
			context.Pratos.Add(new Prato { Nome = "Mini robata de berinjela com queijo de mussarela de bufala e tomate seco", TipoAlimentacaoId = ta[0].Id });
			context.Pratos.Add(new Prato { Nome = "Mini batata cozida com molho de gorgonzola", TipoAlimentacaoId = ta[0].Id });
			context.Pratos.Add(new Prato { Nome = "Canapé de ervas finas e kanikama em cestinha crocante", TipoAlimentacaoId = ta[0].Id });
			context.Pratos.Add(new Prato { Nome = "Mini burguer de filet mignon com sour cream de iogurte", TipoAlimentacaoId = ta[1].Id });
			context.Pratos.Add(new Prato { Nome = "Mini quiche alho poró com shimeji;", TipoAlimentacaoId = ta[1].Id });
			context.Pratos.Add(new Prato { Nome = "Blini de banana da terra, carne seca e crispy de couve;", TipoAlimentacaoId = ta[1].Id });
			context.Pratos.Add(new Prato { Nome = "Mini bruschetta à moda caprese (mussarela de búfala, tomate casse e manjericão)", TipoAlimentacaoId = ta[1].Id });
			context.Pratos.Add(new Prato { Nome = "Croquete de bobó de camarão;", TipoAlimentacaoId = ta[1].Id });
			context.Pratos.Add(new Prato { Nome = "Voul al Vent de queijo brie com pistache e mel", TipoAlimentacaoId = ta[1].Id });
			context.Pratos.Add(new Prato { Nome = "Mini Escondidinho de siri com purê de mandioca e queijo coalho", TipoAlimentacaoId = ta[2].Id });
			context.Pratos.Add(new Prato { Nome = "Mini polenta com cordero e redução de aceto", TipoAlimentacaoId = ta[2].Id });
			context.Pratos.Add(new Prato { Nome = "Salada nobre de folhas verdes com lascas de parmesão, croutons e nozes ao molho de mostarda e mel", TipoAlimentacaoId = ta[3].Id });
			context.Pratos.Add(new Prato { Nome = "Ravioli de Ementhal com limão siciliano", TipoAlimentacaoId = ta[4].Id });
			context.Pratos.Add(new Prato { Nome = "Medalhão de fillet ao molho de vinho madeira e azeite aromatizado", TipoAlimentacaoId = ta[5].Id });
			context.Pratos.Add(new Prato { Nome = "Salmão ao molho de alcaparras", TipoAlimentacaoId = ta[6].Id });
			context.Pratos.Add(new Prato { Nome = "Legumes ao gratin", TipoAlimentacaoId = ta[7].Id });
			context.Pratos.Add(new Prato { Nome = "Risoto de aspargos frescos", TipoAlimentacaoId = ta[8].Id });
			context.Pratos.Add(new Prato { Nome = "Frutas in natura", TipoAlimentacaoId = ta[9].Id });
			context.Pratos.Add(new Prato { Nome = "Lasanha de chocolate com sorvete de creme", TipoAlimentacaoId = ta[9].Id });
			context.Pratos.Add(new Prato { Nome = "Cheese Cake com calda de Frutas Vermelhas", TipoAlimentacaoId = ta[9].Id });
			context.SaveChanges();

			List<Prato> pratos = context.Pratos.ToList();
			pratos.RemoveRange(3, 5);
			List<Prato> pratos2 = context.Pratos.ToList();
			pratos2.RemoveRange(5, 2);
			List<Prato> pratos3 = context.Pratos.ToList();
			pratos.RemoveRange(1, 3);
			List<Prato> pratos4 = context.Pratos.ToList();
			pratos.RemoveRange(7, 4);

			context.Cardapios.Add(new Cardapio { Nome = "Amalfi", OpcoesAlimentacao = pratos });
			context.Cardapios.Add(new Cardapio { Nome = "Jabuti", OpcoesAlimentacao = pratos2 });
			context.Cardapios.Add(new Cardapio { Nome = "Veronese", OpcoesAlimentacao = pratos3 });
			context.Cardapios.Add(new Cardapio { Nome = "Milanese", OpcoesAlimentacao = pratos4 });
			context.SaveChanges();

        }
    }
}