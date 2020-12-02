
using DataEntity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccsessLayer.Validation.FluentValidation
{
    public class KullaniciValidator : AbstractValidator<TBL_KULLANICI>
    {
        public KullaniciValidator()
        {
            RuleFor(k => k.KULLANICI_ADI).NotNull().WithMessage("Kullanıcı adı boş olamaz.")
                 .Length(2, 15).WithMessage("Kullanıcı adı 2 ile 15 karakter arasında olmalıdır.");
            RuleFor(k => k.AD).NotNull().WithMessage("Ad boş bırakılamaz.")
                 .Length(2, 20).WithMessage("Ad 2 ile 15 karakter arasında olmalıdır.");
            RuleFor(k =>k.SOYAD).Length(2, 20).WithMessage("Soyad 2 ile 15 karakter arasında olmalıdır.");
            RuleFor(k => k.MAIL).EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.")
                .When(x => !String.IsNullOrEmpty(x.MAIL));
            RuleFor(k => k.TELEFON).NotNull().WithMessage("Telefon boş bırakılamaz.");
            RuleFor(x => x.SIFRE).NotEmpty().WithMessage("Lütfen şifrenizi giriniz")   
           .Length(5, 15)
           .Must(x => HasValidPassword(x));

        }
        private bool HasValidPassword(string SIFRE)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");
            var symbol = new Regex("(\\W)+");

            return (lowercase.IsMatch(SIFRE) && uppercase.IsMatch(SIFRE) && digit.IsMatch(SIFRE) && symbol.IsMatch(SIFRE));
        }
    }
}