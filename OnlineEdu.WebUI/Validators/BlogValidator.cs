using FluentValidation;
using OnlineEdu.WebUI.DTOs.BlogDtos;

namespace OnlineEdu.WebUI.Validators
{
    public class BlogValidator : AbstractValidator<CreateBlogDto>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Blog Başlığı Boş Bırakılamaz");
            RuleFor(x => x.Title).MaximumLength(30).WithMessage("Blog Başlığı En Fazla 30 Karakter Olabilir");

        }
    }
}
