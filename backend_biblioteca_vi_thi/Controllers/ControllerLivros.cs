using backend_biblioteca_vi_thi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_biblioteca_vi_thi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerLivros : ControllerBase
    {
        // LISTA DE USUÁRIOS (VAZIA POIS É ADICIONADA DEPOIS)
        private static List<Locacao> users =
        new List<Locacao>
        {
            
        };

        // LISTA DE LIVROS
        private static List<Livro> livros =
        new List<Livro>
        {
            new Livro
                {
                    Id = 1,
                    Titulo = "Dom Casmurro",
                    Autor = "Machado de Assis",
                    Ano = 1899,
                    Quantidade = 2,
                    ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/dom_casmurro_edicao_de_luxo_almofadada_89_1_038fb70c564eb50f71ea49f6027e827a.jpg"
                },
            new Livro
                {
                    Id = 2,
                    Titulo = "Memórias Póstumas de Brás Cubas",
                    Autor = "Machado de Assis",
                    Ano = 1881,
                    Quantidade = 3,
                    ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/memorias_postumas_de_bras_cubas_187_1_c5d670beb52b5ef67fbede0220256c2d.jpg"
                },
            new Livro
                {
                    Id = 3,
                    Titulo = "Grande Sertão: Veredas",
                    Autor = "João Guimarães Rosa",
                    Ano = 1956,
                    Quantidade = 4,
                    ImagemUrl = "https://books.google.com.br/books/publisher/content?id=s9kiEAAAQBAJ&hl=pt-BR&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U1IlISKVium_w1Szw6kSCNbu9vK4w&w=1280"
                },
            new Livro
                {
                    Id = 4,
                    Titulo = "O Cortiço",
                    Autor = "Aluísio Azevedo",
                    Ano = 1890,
                    Quantidade = 4,
                    ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/o_cortico_235_1_fa14cd7501c357c31895dfe698838be3.jpg"
                },
            new Livro
                {
                    Id = 5,
                    Titulo = "Iracema",
                    Autor = "José de Alencar",
                    Ano = 1865,
                    Quantidade = 1,
                    ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/iracema_2837_1_40d78d241322fc49bbc0bbb97e522a9a.jpg"
                },
            new Livro
                {
                    Id = 6,
                    Titulo = "Macunaíma",
                    Autor = "Mário de Andrade",
                    Ano = 1928,
                    Quantidade = 11,
                    ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/macunaima_2845_1_745f6996a75c01bd4c1ba780ea44ab6a.jpg"
                },
            new Livro
                {
                    Id = 7,
                    Titulo = "Capitães da Areia",
                    Autor = "Jorge Amado",
                    Ano = 1937,
                    Quantidade = 2,
                    ImagemUrl = "https://books.google.com.br/books/content?id=FDJ1_r4MCIEC&hl=pt-BR&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U3zJno2Uga1FTYiRQ7ScgopvGEHjQ&w=1280"
                },
            new Livro
                {
                    Id = 8,
                    Titulo = "Vidas Secas",
                    Autor = "Graciliano Ramos",
                    Ano = 1938,
                    Quantidade = 9,
                    ImagemUrl = "https://images.tcdn.com.br/img/img_prod/1271663/vidas_secas_45_1_b309cd9d843c7c948ed1a456f6e8eada.jpg"
                },
            new Livro
                {
                    Id = 9,
                    Titulo = "A Moreninha",
                    Autor = "Joaquim Manuel de Macedo",
                    Ano = 1844,
                    Quantidade = 2,
                    ImagemUrl = "https://books.google.com.br/books/publisher/content?id=RL2kEAAAQBAJ&hl=pt-BR&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U2yGtRhpTPgCc5ytlGNkRU7ETTlTQ&w=1280"
                },
            new Livro
                {
                    Id = 10,
                    Titulo = "O Tempo e o Vento",
                    Autor = "Erico Verissimo",
                    Ano = 1949,
                    Quantidade = 1,
                    ImagemUrl = "https://m.media-amazon.com/images/I/51lV89906rL._SY445_SX342_.jpg"
                },
            new Livro
                {
                    Id = 11,
                    Titulo = "A Hora da Estrela",
                    Autor = "Clarice Lispector",
                    Ano = 1977,
                    Quantidade = 1,
                    ImagemUrl = "https://books.google.com.br/books/publisher/content?id=EcgOEAAAQBAJ&hl=pt-BR&pg=PP1&img=1&zoom=3&bul=1&sig=ACfU3U350lvnhB_33MY-9gN_xl6p2lM0Ng&w=1280"
                },
            new Livro
                {
                    Id = 12,
                    Titulo = "O Quinze",
                    Autor = "Rachel de Queiroz",
                    Ano = 1930,
                    Quantidade = 1,
                    ImagemUrl = "https://m.media-amazon.com/images/I/512O2V7xRjL._SY445_SX342_.jpg"
                },
            new Livro
                {
                    Id = 13,
                    Titulo = "Menino do Engenho",
                    Autor = "José Lins do Rego",
                    Ano = 1932,
                    Quantidade = 5,
                    ImagemUrl = "https://m.media-amazon.com/images/I/71SkheXF9VL._SY466_.jpg"
                },
            new Livro
                {
                    Id = 14,
                    Titulo = "Sagarana",
                    Autor = "João Guimarães Rosa",
                    Ano = 1946,
                    Quantidade = 3,
                    ImagemUrl = "https://m.media-amazon.com/images/I/81VvCG8xXWL._SY522_.jpg"
                },
            new Livro
                {
                    Id = 15,
                    Titulo = "Fogo Morto",
                    Autor = "José Lins do Rego",
                    Ano = 1943,
                    Quantidade = 1,
                    ImagemUrl = "https://m.media-amazon.com/images/I/51SM+a8FuyL._SY445_SX342_.jpg"
                },
        };


        // ------------------------------------------------------------------------
        // LISTA DE LIVROS
        [HttpGet]
        public ActionResult<List<Livro>>
           LerTodosLivros()
        {
            return Ok(livros);
        }


        // ------------------------------------------------------------------------
        // LISTA DE USUÁRIOS
        [HttpGet("usuario")]
        public ActionResult<List<Locacao>>
           LerTodosUsuarios()
        {
            return Ok(users);
        }

        // ------------------------------------------------------------------------
        // LISTA DE LIVROS POR ID

        [HttpGet("{id}")]
        public ActionResult<List<Livro>>
        LerUnicoLivro(int id)
        {
            var unico = livros.Find(x => x.Id == id);

            if (unico is null)
                return NotFound("Este livro não foi encontrado");

            return Ok(unico);
        }

        // FAZ A LOCAÇÃO, ENCONTRANDO O LIVRO E DIMINUINDO A QUANTIDADE, SOLICITA O CADASTRO DO USUÁRIO
        [HttpPost]
        public ActionResult<List<Livro>>
            
    SolicitarLocacao(Locacao locacao)
        {


            var pesquisaid = livros.Find(x => x.Id == locacao.IdLivro);
            if (pesquisaid is null)
                return NotFound("Livro não existe");


            if (pesquisaid.Quantidade < 1)
                return BadRequest("Livro está esgotado");


            pesquisaid.Quantidade--;
            users.Add(locacao);
            return Ok(pesquisaid);






        }

        // ------------------------------------------------------------------------



















    }
}
