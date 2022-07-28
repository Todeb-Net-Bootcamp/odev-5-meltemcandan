using FluentValidation;
using PatikaDev.DTO.Basket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDev.Bussines.Configuration.Validator.FluentValidation
{
    public class ProductRequestValidator : AbstractValidator<ProductRequest>
    {
        public ProductRequestValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty();
            RuleFor(x => x.Barcode).NotEmpty();
            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.ProductCategoryId).NotEmpty();
        }
    }

}
