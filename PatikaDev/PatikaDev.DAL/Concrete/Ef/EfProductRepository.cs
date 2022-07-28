using PatikaDev.DAL.Abstract;
using PatikaDev.DAL.Contexts;
using PatikaDev.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.DAL.Concrete.Ef
{
    public class EfProductRepository: IProductRepository
    {
        private ECommerceContext _context;

        public EfProductRepository(ECommerceContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Insert(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product)
        {

            _context.Products.Update(product);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var entity = _context.Products.SingleOrDefault(x => x.Id == id);
            _context.Products.Remove(entity);
            _context.SaveChanges();
        }

        public Product Get(int id)
        {
            return _context.Products.SingleOrDefault(x => x.Id == id);
        }
    }
}
