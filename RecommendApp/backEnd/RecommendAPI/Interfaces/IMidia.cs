using System.Collections.Generic;
using RecommendAPI.Entities;
using RecommendAPI.Entities.Enums;

namespace RecommendAPI.Interfaces
{
    public interface IMidia
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Pais { get; set; }
        public int Ano { get; set; }
        public AppUser User { get; set; }

        public MidiaTypeEnum Tipo { get; set; }
        public ICollection<Integrante> Integrantes { get; set; }
    }
}