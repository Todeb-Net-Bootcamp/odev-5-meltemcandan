using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.Models.Entities
{
    public class Basket : BaseModel
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Product Product { get; set; }

        public Customer Customer { get; set; }


    }
}
