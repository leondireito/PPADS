using System.Collections.Generic;
using RecommendAPI.Interfaces;

namespace RecommendAPI.Entities
{
    public class Filme:Midia, IMidia
    {
        public string Diretor { get; set; }
    }
}