using System.ComponentModel.DataAnnotations;

namespace PRO150.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;
    }
}
