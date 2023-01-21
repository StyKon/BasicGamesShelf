using System.ComponentModel.DataAnnotations;

namespace Basic_Games_Shelf.Models
{
    public class Games
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public string Game { get; set; }
        [Required]
        public int PlayTime { get; set; }
        [Required]
        public string Genre { get; set; }

        [Required]
        public string[] Platforms { get; set; }
    }
}
