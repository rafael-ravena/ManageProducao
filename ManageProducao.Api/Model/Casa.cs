using ManageProducao.Api.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ManageProducao.Api.Model
{
	public class Casa
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Sigla { get; set; }
		public string Endereco { get; set; }

        internal static IEnumerable<Casa> GetAll()
        {
            return new Context().Casas;
        }
        internal static IEnumerable<Casa> GetAll(string nome)
        {
            return new Context().Casas.Where(c => c.Nome.ToLower().IndexOf(nome.ToLower()) > -1);
        }
        internal static Casa Get(int id)
        {
            return new Context().Casas.FirstOrDefault(c => c.Id == id);
        }
        internal static void Create(Casa entity)
        {
            Context context = new Context();
            context.Casas.Add(entity);
            context.SaveChanges();
        }
        internal static void Update(Casa entity)
        {
            Context context = new Context();
            Casa original = context.Casas.FirstOrDefault(c => c.Id == entity.Id);
            context.Entry(original).CurrentValues.SetValues(entity);
            context.Entry(original).State = EntityState.Modified;
            context.SaveChanges();
        }
        internal static void Delete(int id)
        {
            Context context = new Context();
            Casa original = context.Casas.FirstOrDefault(c => c.Id == id);
            context.Entry(original).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
