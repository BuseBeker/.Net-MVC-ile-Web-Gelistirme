using EntityLayer.Concrete;
using FluentValidation;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Remoting;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(temp => temp.Name)
           .NotEmpty()
           .WithMessage("Ad alanı boş olamaz.");
            //.Matches(@"^[a-zA-Z]+$")
            //.WithMessage("Ad alanı sadece harf içermelidir.");

            RuleFor(temp => temp.Surname)
           .NotEmpty()
           .WithMessage("Soyad alanı boş olamaz.");
           //.Matches(@"^[a-zA-Z]+$")
           //.WithMessage("Soyad alanı sadece harf içermelidir.");

            RuleFor(temp => temp.Email)
           .NotEmpty()
           .WithMessage("E-posta alanı boş olamaz.")
           .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$")
           .WithMessage("Geçersiz e-posta adresi.");

            RuleFor(temp => temp.Phone)
           .NotEmpty()
           .WithMessage("Telefon numarası boş bırakılamaz.")
           .Matches(@"^\d{1,15}$")
           .WithMessage("Geçersiz telefon numarası.");

            RuleFor(temp => temp.Rumuz)
           .NotEmpty()
           .WithMessage("Kullanıcı Ad alanı boş olamaz.");
           //.Matches(@"^[a-zA-Z]+$")
           //.WithMessage("Ad alanı sadece harf içermelidir.");

            RuleFor(temp => temp.Password)
           .NotEmpty()
           .WithMessage("Şifre boş bırakılamaz.");
            //.Length(3, 60)
            //.WithMessage("Şifre en az 3, en fazla 60 karakter uzunluğunda olmalıdır.");

            RuleFor(temp => temp.BirthdayDate)
           .NotNull()
           .WithMessage("Doğum tarihi boş bırakılamaz.");
           //.LessThan(DateTime.Now.AddYears(-18))
           //.WithMessage("Yaşınız 18'den küçük olduğu için üye olamazsınız.");
            //RuleFor(x => x.Name).NotEmpty().WithMessage("Adınızı Boş Geçemezsiniz");
            //RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyadınızı Boş Geçemezsiniz");
            //RuleFor(x => x.Rumuz).NotEmpty().WithMessage("Kullanıcı Adınızı Boş Geçemezsiniz");
            //RuleFor(x => x.Email).EmailAddress.NotEmpty().WithMessage("");
        }
    }
}
