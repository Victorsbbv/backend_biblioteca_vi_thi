using backend_biblioteca_vi_thi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_biblioteca_vi_thi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerLivros : ControllerBase
    {
        private static List<livro> livros =
        new List<livro>
        {
            new livro
                {
                    Id = 1,
                    Titulo = "Dom Casmurro",
                    Autor = "Machado de Assis",
                    Ano = 1899,
                    Quantidade = 2
                },
            new livro
                {
                    Id = 2,
                    Titulo = "Memórias Póstumas de Brás Cubas",
                    Autor = "Machado de Assis",
                    Ano = 1881,
                    Quantidade = 3
                },
            new livro
                {
                    Id = 3,
                    Titulo = "Grande Sertão: Veredas",
                    Autor = "João Guimarães Rosa",
                    Ano = 1956,
                    Quantidade = 4
                },
            new livro
                {
                    Id = 4,
                    Titulo = "O Cortiço",
                    Autor = "Aluísio Azevedo",
                    Ano = 1890,
                    Quantidade = 4
                },
            new livro
                {
                    Id = 5,
                    Titulo = "Iracema",
                    Autor = "José de Alencar",
                    Ano = 1865,
                    Quantidade = 1
                },
            new livro
                {
                    Id = 6,
                    Titulo = "Macunaíma",
                    Autor = "Mário de Andrade",
                    Ano = 1928,
                    Quantidade = 11
                },
            new livro
                {
                    Id = 7,
                    Titulo = "Capitães da Areia",
                    Autor = "Jorge Amado",
                    Ano = 1937,
                    Quantidade = 2
                },
            new livro
                {
                    Id = 8,
                    Titulo = "Vidas Secas",
                    Autor = "Graciliano Ramos",
                    Ano = 1938,
                    Quantidade = 9
                },
            new livro
                {
                    Id = 9,
                    Titulo = "A Moreninha",
                    Autor = "Joaquim Manuel de Macedo",
                    Ano = 1844,
                    Quantidade = 2
                },
            new livro
                {
                    Id = 10,
                    Titulo = "O Tempo e o Vento",
                    Autor = "Erico Verissimo",
                    Ano = 1949,
                    Quantidade = 1
                },
            new livro
                {
                    Id = 11,
                    Titulo = "A Hora da Estrela",
                    Autor = "Clarice Lispector",
                    Ano = 1977,
                    Quantidade = 1
                },
            new livro
                {
                    Id = 12,
                    Titulo = "O Quinze",
                    Autor = "Rachel de Queiroz",
                    Ano = 1930,
                    Quantidade = 1
                },
            new livro
                {
                    Id = 13,
                    Titulo = "Menino do Engenho",
                    Autor = "José Lins do Rego",
                    Ano = 1932,
                    Quantidade = 5
                },
            new livro
                {
                    Id = 14,
                    Titulo = "Sagarana",
                    Autor = "João Guimarães Rosa",
                    Ano = 1946,
                    Quantidade = 3
                },
            new livro
                {
                    Id = 15,
                    Titulo = "Fogo Morto",
                    Autor = "José Lins do Rego",
                    Ano = 1943,
                    Quantidade = 1
                },
        };


        // ------------------------------------------------------------------------
        // LISTA DE LIVROS
        [HttpGet]
        public ActionResult<List<livro>>
           LerTodosLivros()
        {
            return Ok(livros);
        }

        // ------------------------------------------------------------------------
        // LISTA DE LIVROS POR ID

        [HttpGet("{id}")]
        public ActionResult<List<livro>>
        LerUnicoLivro(int id)
        {
            var unico = livros.Find(x => x.Id == id);

            if (unico is null)
                return NotFound("Este livro não foi encontrado");

            return Ok(unico);
        }





        // ------------------------------------------------------------------------
        // ADICIONA CARROS
        //[HttpPost]
        //public ActionResult<List<livro>>
        //    AddCarro(livro novo)

        //{
        //    if (novo.Id == 0 && carros.Count > 0)
        //        novo.Id = carros[carros.Count - 1].Id + 1;
        //    carros.Add(novo);
        //    return Ok(carros);
        //}
        // ------------------------------------------------------------------------
        // SOLICITA LOCAÇÃO
        [HttpPut("{id}")]
        public ActionResult<List<livro>>

    SolicitarLocacao(int id)
        {
            var pesquisaid = livros.Find(x => x.Id == id);
            if (pesquisaid is null)
                return NotFound("Livro não existe");


            if (pesquisaid.Quantidade <= 0)
                return Ok("Livro está esgotado");
            else
                return Ok("Mistério");

        }
        // ------------------------------------------------------------------------



















    }
}
