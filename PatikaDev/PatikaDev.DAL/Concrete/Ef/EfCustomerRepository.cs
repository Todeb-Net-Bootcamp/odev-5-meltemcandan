using PatikaDev.DAL.Abstract;
using PatikaDev.DAL.Contexts;
using PatikaDev.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PatikaDev.DAL.Concrete.Ef
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private ECommerceContext _context;

        public EFCustomerRepository(ECommerceContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Insert(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {

            _context.Customers.Update(customer);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var entity = _context.Customers.SingleOrDefault(x => x.Id == id);
            _context.Customers.Remove(entity);
            _context.SaveChanges();
        }

        public Customer Get(int id)
        {
            return _context.Customers.SingleOrDefault(x => x.Id == id);
        }
    }
}
