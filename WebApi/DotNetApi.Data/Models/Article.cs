using System.ComponentModel.DataAnnotations;

namespace DotNetApi.Data.Models
{
    public class Article
    {
        public long Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
    }
}
