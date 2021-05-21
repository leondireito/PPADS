using System.Collections.Generic;
using RecommendAPI.Interfaces;

namespace RecommendAPI.Entities
{
    public class Serie : Midia,  IMidia
    {
        public string Diretor { get; set; }
        public int Temporadas { get; set; }
      
    }
}