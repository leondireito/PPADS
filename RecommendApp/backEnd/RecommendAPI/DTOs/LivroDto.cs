using System.Collections.Generic;
using RecommendAPI.Entities;

namespace RecommendAPI.DTOs
{
    public class LivroDto:ItemDto
    {
         public string Editora { get; set; }
        public ICollection<AutorDto> AutoresDto { get; set; }  = new List<AutorDto>();
    }
}