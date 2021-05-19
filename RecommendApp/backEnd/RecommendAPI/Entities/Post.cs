using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecommendAPI.Entities
{
    public class Post
    {
         public int PostId { get; set; }

    [Required]
    [StringLength(50)]
    public string Title { get; set; }

    public ICollection<Tag> Tags { get; set; }
    }
}