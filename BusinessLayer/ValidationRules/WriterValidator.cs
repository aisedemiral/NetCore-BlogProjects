using FluentValidation;
using Mvc_Projem.EntityLayer.Concrete;

namespace BusinessLayer.ValidationRules;

public class WriterValidator:AbstractValidator<Writer>
{
    public WriterValidator()
    {
        RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.;");
        RuleFor(x => x.WriterMail).NotEmpty().WithMessage("mail adresi boş geçilemez");
        RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("şifre boş geçilemez.");
        RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter girişi yapınız.");
        RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapınız.");
    }
}