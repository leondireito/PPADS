using System;

namespace RecommendAPI.DTOs
{
    public class MemberUpdateDto
    {
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string Name { get; set; }
        public string KnownAs { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}