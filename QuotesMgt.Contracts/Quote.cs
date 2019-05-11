using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuotesMgt.Contracts
{
    public class Quote
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [ForeignKey("Author")]
        [Required]
        public int AuthorId { get; set; }

        public Author Author { get; set; }

        [Required]
       public int Rating { get; set; }
    }
}