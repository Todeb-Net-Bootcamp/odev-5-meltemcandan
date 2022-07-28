using AutoMapper;
using PatikaDev.DTO.Customer;
using PatikaDev.Models.Entities;

namespace PatikaDev.Bussines.Configuration.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CustomerRequest, Customer>();
            CreateMap<Customer, CustomerResponse>();
        }
    }
}
