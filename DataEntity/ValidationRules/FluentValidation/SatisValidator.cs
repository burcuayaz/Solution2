using DataEntity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.ValidationRules.FluentValidation
{
    public class SatisValidator : AbstractValidator<TBL_SATIS>
    {
        public SatisValidator()
        {
            RuleFor(k => k.KATEGORI_ID).NotNull().WithMessage("Kategori id boş olamaz.");
            RuleFor(k => k.MARKA_ID).NotNull().WithMessage("Marka id boş olamaz.");
            RuleFor(k => k.MODEL_ID).NotNull().WithMessage("Model id boş olamaz.");
            RuleFor(k => k.MUSTERI_ID).NotNull().WithMessage("Müşteri id boş olamaz.");
            RuleFor(k => k.ADET).NotNull().WithMessage("Adet belirtiniz!").GreaterThan(0);
            RuleFor(k => k.FIYAT).NotNull().WithMessage("Bu alanı boş bırakamazsınız").ScalePrecision(2, 10);
            RuleFor(p => p.TARIH).NotEmpty().WithMessage("Bu alanı boş bırakamazsınız")
            .LessThan(p => DateTime.Now).WithMessage("Geçerli bir tarih giriniz");
        }
    }
}
