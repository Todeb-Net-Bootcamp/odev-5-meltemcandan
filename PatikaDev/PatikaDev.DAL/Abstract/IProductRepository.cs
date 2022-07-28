using PatikaDev.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.DAL.Abstract
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAll();
        public void Insert(Product Product);
        public void Update(Product Product);
        public void Delete(int id);
        public Product Get(int id);
    }
}
