using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecommendAPI.Entities
{
    public class Tag
    {
         public int TagId { get; set; }

    [Required]
    [StringLength(25)]
    public string Name { get; set; }

    public ICollection<Post> Posts { get; set; }
    }
}