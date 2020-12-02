
using DataEntity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Validation.FluentValidation
{
    public class MusteriValidator : AbstractValidator<TBL_MUSTERILER>
    {
        public MusteriValidator()
        {
            RuleFor(m => m.ADSOYAD).NotNull().WithMessage("Bu alanı boş bırakamazsınız.")
                 .Length(2, 30).WithMessage("AdSoyad 2 ile 30 karakter arasında olmalıdır.").WithErrorCode("ER_01");
            //  RuleFor(m => m.TELEFON).NotNull().WithMessage("Bu alanı boş bırakamazsınız.").InclusiveBetween(1, 10).WithErrorCode("ER_03");
            RuleFor(m => m.ADRES).NotNull().WithMessage("Adres boş bırakılamaz.").WithErrorCode("ER_04");
            RuleFor(m => m.MAIL).EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.").When(x => !String.IsNullOrEmpty(x.MAIL)).WithErrorCode("ER_05");
            RuleFor(m => m.KAYIT_TARIHI) .NotEmpty().WithMessage("Bu alanı boş bırakamazsınız")
            .LessThan(p => DateTime.Now).WithMessage("Geçerli bir tarih giriniz").WithErrorCode("ER_06");
        }
    }
}
