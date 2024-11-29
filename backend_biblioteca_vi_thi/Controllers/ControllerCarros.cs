using Concessionaria.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Concessionaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerCarros : ControllerBase
    {
        private static List<Carro> carros =
        new List<Carro>
        {

        };


        // ------------------------------------------------------------------------
        // LISTA DE CARROS
        [HttpGet]
        public ActionResult<List<Carro>>
           LerTodosCarros()
        {
            return Ok(carros);
        }





        // ------------------------------------------------------------------------
        // ADICIONA CARROS
        [HttpPost]
        public ActionResult<List<Carro>>
            AddCarro(Carro novo)

        {
            if (novo.Id == 0 && carros.Count > 0)
                novo.Id = carros[carros.Count - 1].Id + 1;
            carros.Add(novo);
            return Ok(carros);
        }
        // ------------------------------------------------------------------------
        // SOLICITA LOCAÇÃO
        [HttpPut("{id}")]
        public ActionResult<List<Carro>>

    SolicitarLocacao(int id)
        {
            var pesquisaid = carros.Find(x => x.Id == id);
            if (pesquisaid is null)
                return NotFound("Carro nao existe");

            pesquisaid.Alugado = !pesquisaid.Alugado;


            if (pesquisaid.Alugado)
                return Ok("Carro Alugado com sucesso");
            else
                return Ok("Carro Devolvido com sucesso");

        }
// ------------------------------------------------------------------------



















    }
}
