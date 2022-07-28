using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.Models.Entities
{
    public class Product : BaseModel
    {
        [MaxLength(100)]
        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [MaxLength(300)]
        public string Image { get; set; }

        [MaxLength(20)]
        [Required]
        public string Barcode { get; set; }

        [Required]
        public int ProductCategoryId { get; set; }

        public ProductCategory ProductCategory { get; set; }
    }
}
