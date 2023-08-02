using EntityLayer.Contrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş geçilemez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Bu alanı boş geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(5).WithMessage("Kategori adı en az 5 karakter olmalıdır.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Kategori adı en fazla 20 karakter olmalıdır.");
        }
    }
}
