using System.ComponentModel.DataAnnotations;

namespace library.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Namn")]
        public string? Name { get; set; }
        public List<BookModel>? Books { get; set; }
    }
}