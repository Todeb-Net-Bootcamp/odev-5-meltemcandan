using PatikaDev.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.DAL.Abstract
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAll();
        public void Insert(Customer customer);
        public void Update(Customer customer);
        public void Delete(int id);
        public Customer Get(int id);
    }
}
