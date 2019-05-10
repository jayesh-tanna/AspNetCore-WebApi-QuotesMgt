using System.ComponentModel.DataAnnotations;

namespace QuotesMgt.Contracts
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}