using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.DTO.Basket
{
    public class ProductResponse
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Image { get; set; }

        public string Barcode { get; set; }

        public int ProductCategoryId { get; set; }

    }
}
