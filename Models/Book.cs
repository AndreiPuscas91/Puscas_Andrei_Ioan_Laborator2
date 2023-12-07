using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Puscas_Andrei_Ioan_Laborator2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name = "Book Title")] // asa schimbam numele cartilor
        public string Title { get; set; }
        // public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")] // asa punem valori cu 2 zecimale
        public decimal Price { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property  
        public int? AuthorsID { get; set; }
        public Authors? Authors { get; set; }
        public ICollection<Authors>? Author { get; set; } // navigation property ?
    }
}
