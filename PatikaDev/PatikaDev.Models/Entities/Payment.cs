using PatikaDev.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.Models.Entities
{
    public class Payment: BaseModel
    {
        [Required]
        public PaymentTypeEnum PaymentType { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }
        
        [Required]
        public int BasketId { get; set; }

    }
}
