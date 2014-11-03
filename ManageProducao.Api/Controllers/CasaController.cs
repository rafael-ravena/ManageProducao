using ManageProducao.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ManageProducao.Api.Controllers
{
    public class CasaController : ApiController
    {
        [HttpGet]
        [Route("casa/")]
        public IEnumerable<Casa> Get()
        {
            return Casa.GetAll();
        }

        [HttpGet]
        [Route("casa/{id}")]
        public Casa Get(int id)
        {
            return Casa.Get(id);
        }

        [HttpGet]
        [Route("casa/buscar/{nome}")]
        public IEnumerable<Casa> Get(string nome)
        {
            return Casa.GetAll(nome);
        }

        [HttpPost]
        [Route("casa/criar")]
        public void Create(Casa entity)
        {
            Casa.Create(entity);
        }

        [HttpDelete]
        [Route("casa/excluir/{id}")]
        public void Delete(int id)
        {
            Casa.Delete(id);
        }

        [HttpPut]
        [Route("casa/alterar")]
        public void Update(Casa entity)
        {
            Casa.Update(entity);
        }
    }
}