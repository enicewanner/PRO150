using System.ComponentModel.DataAnnotations;

namespace PRO150.Models
{
    public class Word
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
