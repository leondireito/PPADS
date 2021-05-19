using System;
using RecommendAPI.Entities.Enums;

namespace RecommendAPI.Entities
{
    public class Midia
    {
         public int Id { get; set; }
         public string Titulo { get; set; }
         public string  Pais { get; set; }
         public int Ano { get; set; }
         public string FotoUrl { get; set; }
         public DateTime Lancamento { get; set; }
         public DateTime Criado { get; set; }
         public AppUser User { get; set; }
         public MidiaTypeEnum Tipo { get; set; }
    }
}