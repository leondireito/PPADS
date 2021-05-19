using System.Collections.Generic;

namespace RecommendAPI.DTOs
{
    public class FilmeDto : ItemDto
    {
         public string Diretor { get; set; }
        public ICollection<ElencoDto> ElencosDto { get; set; } = new List<ElencoDto>(); 
    }
}