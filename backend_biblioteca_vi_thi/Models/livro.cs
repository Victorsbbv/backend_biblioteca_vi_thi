namespace backend_biblioteca_vi_thi.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public int Ano { get; set; }
        public int Quantidade { get; set; }
        //public bool Alugado { get; set; } = false;
        //public string UserNome { get; set; } = string.Empty;
        //public int UserAno { get; set; }
    }
}
