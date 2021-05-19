using System.Collections.Generic;
using RecommendAPI.Interfaces;

namespace RecommendAPI.Entities
{
    public class Livro : Midia, IMidia
    {
        public Editora Editora { get; set; }
        public ICollection<Autor> Autores { get; set; }  = new List<Autor>();
    }
}