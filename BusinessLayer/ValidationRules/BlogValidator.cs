using FluentValidation;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.ValidationRules;

public class BlogValidator:AbstractValidator<Blog>
{
    public BlogValidator()
    {
        RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını boş geçemezsiniz");
        RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz");
        RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz");
        RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az karakter girişi yapınız.");
        RuleFor(x => x.BlogTitle).MinimumLength(5)
            .WithMessage("Lütfen 4 karakterden daha fazla karakter girişi yapınız.");

    }
}