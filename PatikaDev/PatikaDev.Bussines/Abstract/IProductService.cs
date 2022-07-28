using PatikaDev.Bussines.Configuration;
using PatikaDev.DTO.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.Bussines.Abstract
{
    public interface IProductService
    {
        public IEnumerable<ProductResponse> GetAll();
        public CommandResponse Insert(ProductRequest request);
        public CommandResponse Update(ProductRequest request);
        public CommandResponse Delete(int id);
    }
}
