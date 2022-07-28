using PatikaDev.Bussines.Configuration;
using PatikaDev.DTO.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.Bussines.Abstract
{
    public interface ICustomerService
    {
        public IEnumerable<CustomerResponse> GetAll();
        public CommandResponse Insert(CustomerRequest request);
        public CommandResponse Update(CustomerRequest request);
        public CommandResponse Delete(int id);

    }
}
