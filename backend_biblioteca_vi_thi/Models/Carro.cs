﻿namespace Concessionaria.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public int Ano { get; set; }
        public string Cor { get; set; } = string.Empty;
        public bool Alugado { get; set; } = false;
    }
}
