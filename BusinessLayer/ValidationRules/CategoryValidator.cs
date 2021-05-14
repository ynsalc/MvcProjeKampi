using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adı Boş Bırakılamaz!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklama Boş Bırakılamaz!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter girişi yapılmalı");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("20 karakterden fazla giriş yapılamaz");
        }
    }
}
