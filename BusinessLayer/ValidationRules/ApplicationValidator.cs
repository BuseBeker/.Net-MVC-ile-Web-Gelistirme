using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ApplicationValidator : AbstractValidator<Application>
    {
        public ApplicationValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adınızı Boş Geçemezsiniz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadınızı Boş Geçemezsiniz");
            RuleFor(x => x.Project_name).NotEmpty().WithMessage("Proje Adını Boş Geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz");
            RuleFor(x => x.ProjectType).NotEmpty().WithMessage("Proje Türünü Boş Geçemezsiniz");
        }
    }
}
