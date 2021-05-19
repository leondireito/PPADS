using System;
using RecommendAPI.Entities.Enums;

namespace RecommendAPI.DTOs
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Pais { get; set; }
        public int Ano { get; set; }
        public string PhotoUrl { get; set; }
        public string Username { get; set; }
        public DateTime Lancamento { get; set; }
        public MidiaTypeEnum Tipo { get; set; }
        public int Likes { get; set; }
    }
}