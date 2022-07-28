using AutoMapper;
using PatikaDev.Bussines.Abstract;
using PatikaDev.Bussines.Configuration;
using PatikaDev.Bussines.Configuration.Extension;
using PatikaDev.Bussines.Configuration.Validator.FluentValidation;
using PatikaDev.DAL.Abstract;
using PatikaDev.DTO.Customer;
using PatikaDev.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PatikaDev.Bussines.Concrete
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _repository;
        private IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<CustomerResponse> GetAll()
        {
            var data = _repository.GetAll();
            var mappedData = data.Select(x => _mapper.Map<CustomerResponse>(x)).ToList();
            return mappedData;
        }

        public IEnumerable<CustomerResponse> GetAllForReport()
        {
            var data = _repository.GetAll();
            var mappedData = data.Select(x => _mapper.Map<CustomerResponse>(x)).ToList();
            return mappedData;
        }

        public CommandResponse Insert(CustomerRequest request)
        {

            var validator = new CustomerRequestValidator();
            validator.Validate(request).ThrowIfException();

           

            var entity = _mapper.Map<Customer>(request);

           


            _repository.Insert(entity);

            return new CommandResponse
            {
                Status = true,
                Message = $"Müşteri eklendi. "
            };
        }

        public CommandResponse Update(CustomerRequest request)
        {

            var validator = new CustomerRequestValidator();
            validator.Validate(request).ThrowIfException();

            var entity = _repository.Get(request.Id);
            if (entity == null)
            {
                return new CommandResponse()
                {
                    Status = false,
                    Message = "Veri tabanında bu Id de kayıt bulunmamaktadır"
                };
            }

            var mappedEntity = _mapper.Map(request, entity);

            _repository.Update(mappedEntity);

            return new CommandResponse
            {
                Status = true,
                Message = $"Müşteri Güncellendi"
            };
        }

        public CommandResponse Delete(int id)
        {
            _repository.Delete(id);

            return new CommandResponse
            {
                Status = true,
                Message = $"Müşteri silindi. Id={id}"
            };
        }

    }
}
