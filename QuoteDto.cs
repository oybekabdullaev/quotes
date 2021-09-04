using System.ComponentModel.DataAnnotations;

namespace Quotes
{
    public class QuoteDto
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(63)]
        public string Author { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Body { get; set; }
        
        [EnumDataType(typeof(QuoteCategory))]
        public QuoteCategory QuoteCategory { get; set; }
    }
}