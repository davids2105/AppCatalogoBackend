
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace backend.models
{

    [Index(nameof(sku), IsUnique = true)]
    public class Products
    {
        [Key] 
        public int id { get; set; }

        [Required]
        public string nombre { get; set; } = string.Empty;

        [Required]

        
        public string sku {  get; set; } = string.Empty;

        [Range(0, int.MaxValue)]
        public decimal precio { get; set; }

        [Range(0, int.MaxValue)]
        public int stock { get; set; }

        [Required]
        public string categoria {get; set; } = string.Empty;


    }
}