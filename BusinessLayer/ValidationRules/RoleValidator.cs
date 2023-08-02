using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class RoleValidator : AbstractValidator<Role>
    {

        //Kullanacağımız doğrulama kurallarını constructor içine yazıyoruz
        public RoleValidator()
        {
            RuleFor(x => x.RoleName).NotEmpty().WithMessage("Role Adını Boş Geçemezsiniz");
            RuleFor(x => x.RoleName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapın");
            RuleFor(x => x.RoleName).MaximumLength(25).WithMessage("Lütfen 25 karakterden fazla değer girişi yapmayın");
        }
    }
}
