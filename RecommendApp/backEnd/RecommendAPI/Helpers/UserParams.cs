using RecommendAPI.Entities.Enums;

namespace RecommendAPI.Helpers
{
    public class UserParams : PaginationParams
    {
        public string CurrentUsername { get; set; }
        public string Gender { get; set; }
        public int MinAge { get; set; } = 18;
        public int MaxAge { get; set; } = 150;
        public string Username { get; set; }
        public string Name { get; set; }
        public string MidiaTitulo { get; set; }
        public MidiaTypeEnum MidiaTipo { get; set; }
        public bool Avaliado { get; set; } = true;

        public string OrderBy { get; set; } = "lastActive";
    }
}