using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace library.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Titel")]
        public string? Title { get; set; }
        [Required]
        [Display(Name = "Utgivningsår")]
        public int ReleaseYear { get; set; }
        public string? ImageName { get; set; }
        [NotMapped]
        [Display(Name = "Bild")]
        public IFormFile? ImageFile { get; set; }
        [Display(Name = "Författare")]
        public int AuthorId { get; set; }
        [Display(Name = "Författare")]
        public AuthorModel? Author { get; set; }
    }
}