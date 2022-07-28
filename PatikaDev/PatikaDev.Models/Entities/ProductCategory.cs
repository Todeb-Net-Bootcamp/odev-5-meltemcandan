using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.Models.Entities
{
    public class ProductCategory : BaseModel
    {
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

    }
}
