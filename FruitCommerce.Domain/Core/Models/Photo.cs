using System.ComponentModel.DataAnnotations;

namespace FruitCommerce.Domain.Core.Models
{
    public class Photo : ModelBase
    {
        public int Id { get; set; }

  

        [Required]
        [StringLength(255)]
        public string PhotoFileName { get; set; }

     
        public int ProductId { get; set; }
    }
}