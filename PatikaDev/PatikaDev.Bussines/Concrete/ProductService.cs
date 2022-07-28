using AutoMapper;
using PatikaDev.Bussines.Abstract;
using PatikaDev.Bussines.Configuration;
using PatikaDev.Bussines.Configuration.Extension;
using PatikaDev.Bussines.Configuration.Validator.FluentValidation;
using PatikaDev.DAL.Abstract;
using PatikaDev.DTO.Basket;
using PatikaDev.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.Bussines.Concrete
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _repository;
        private IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<ProductResponse> GetAll()
        {
            var data = _repository.GetAll();
            var mappedData = data.Select(x => _mapper.Map<ProductResponse>(x)).ToList();
            return mappedData;
        }

        public IEnumerable<ProductResponse> GetAllForReport()
        {
            var data = _repository.GetAll();
            var mappedData = data.Select(x => _mapper.Map<ProductResponse>(x)).ToList();
            return mappedData;
        }

        public CommandResponse Insert(ProductRequest request)
        {

            var validator = new ProductRequestValidator();
            validator.Validate(request).ThrowIfException();



            var entity = _mapper.Map<Product>(request);




            _repository.Insert(entity);

            return new CommandResponse
            {
                Status = true,
                Message = $"Ürün eklendi. "
            };
        }

        public CommandResponse Update(ProductRequest request)
        {

            var validator = new ProductRequestValidator();
            validator.Validate(request).ThrowIfException();

            var entity = _repository.Get(request.Id);
            if (entity == null)
            {
                return new CommandResponse()
                {
                    Status = false,
                    Message = "Veri tabanında bu Id de ürün bulunmamaktadır"
                };
            }

            var mappedEntity = _mapper.Map(request, entity);

            _repository.Update(mappedEntity);

            return new CommandResponse
            {
                Status = true,
                Message = $"Ürün Güncellendi"
            };
        }

        public CommandResponse Delete(int id)
        {
            _repository.Delete(id);

            return new CommandResponse
            {
                Status = true,
                Message = $"Ürün silindi. Id={id}"
            };
        }
    }
}
