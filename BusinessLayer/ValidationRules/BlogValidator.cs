using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını boş geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini boş geçemezsiniz");
            RuleFor(x => x.BlogImage).MaximumLength(150).WithMessage("Blog Görselini 150den fazla giremezsiniz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Blog Başlığını 5 den az giremezsiniz");

        }
    }
}
