using FluentValidation;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.ValidationRules;

public class CategoryValidator:AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz!!");
        RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş geçemezsiniz!!");
        RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Kategori adı en fazla 30 karakter alabilir!!");
        RuleFor(x => x.CategoryDescription).MinimumLength(2).WithMessage("Kategori adı en az 2 karakter içermelidir!!");
    }

    
}