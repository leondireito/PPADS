using System.Collections.Generic;

namespace RecommendAPI.Entities
{
    public class Elenco
    {
        public int Id { get; set; }
        public string Nome { get; set; }

       
         public ICollection<Serie> Series { get; set; } 
         public ICollection<Filme> Filmes { get; set; } 


    }
}