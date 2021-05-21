using System.Collections;
using System.Collections.Generic;
using RecommendAPI.Entities;
using RecommendAPI.Entities.Enums;
using RecommendAPI.Interfaces;

namespace RecommendAPI.DTOs
{
    public class MidiaDto : ItemDto, IMidiaDto
    {
        public string Diretor { get; set; }
        public int Temporadas { get; set; }
         public string Editora { get; set; }
        public ICollection<Integrante> Integrantes { get; set; } = new List<Integrante>();
    }
}