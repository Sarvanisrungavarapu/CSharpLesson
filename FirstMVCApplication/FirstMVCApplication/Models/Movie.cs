using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVCApplication.Models
{
    public class Movie
    {
        [Key]
        public int SNo { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 char")]
        public String Title { get; set; }
        [Required]
        [Range(10000, 5000000)]
        public String Language { get; set; }
        [Required]
        [Range(10000, 5000000)]
        public String HeroName { get; set; }
        [Required]
        [Range(10000, 5000000)]
        public String DirectorName { get; set; }
        [Required]
        [Range(10000, 5000000)]
        public String MDirector { get; set; }
        [Required]
        [Range(10000, 5000000)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Range(10000, 5000000)]
        public decimal Cost { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "City must be between 3 and 20 char")]
        public decimal Collection { get; set; }
        [Required]
        [StringLength(20)]
        [MinLength(3, ErrorMessage = "City must be between 3 and 20 char")]
        public String Review { get; set; }
    }
}