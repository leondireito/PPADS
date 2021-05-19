using System;
using System.Collections.Generic;
using RecommendAPI.Entities;
using RecommendAPI.Interfaces;

namespace RecommendAPI.DTOs
{
    public class SerieDto: ItemDto
    {
        public string Diretor { get; set; }
        public int Temporadas { get; set; }
        public ICollection<ElencoDto> ElencosDto { get; set; } = new List<ElencoDto>();
    }
}