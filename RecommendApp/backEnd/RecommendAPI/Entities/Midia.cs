using System;
using System.Collections.Generic;
using RecommendAPI.Entities.Enums;
using RecommendAPI.Interfaces;

namespace RecommendAPI.Entities
{
    public class Midia:IMidia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Pais { get; set; }
        public int Ano { get; set; }
        public string FotoUrl { get; set; }
        public DateTime Lancamento { get; set; }
        public DateTime Criado { get; set; }
        public AppUser User { get; set; }
        public MidiaTypeEnum Tipo { get; set; }
        public bool Avaliado { get; set; } = false;
        public ICollection<Integrante> Integrantes { get; set; } = new List<Integrante>();
    }
}