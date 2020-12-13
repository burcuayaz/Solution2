using DataEntity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Validation.FluentValidation
{
    public class ModelValidator : AbstractValidator<TBL_MODEL>
    {
        public ModelValidator() {

            RuleFor(k => k.MODEL_ADI).NotNull().WithMessage("Bu alan boş bırakılamaz.").Length(1, 50); ;
            RuleFor(k => k.KATEGORI_ID).NotNull().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(k => k.MARKA_ID).NotNull().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(p => p.TARIH).NotEmpty().WithMessage("Bu alanı boş bırakamazsınız")
            .LessThan(p => DateTime.Now).WithMessage("Geçerli bir tarih giriniz");
            RuleFor(k => k.MOTOR_HACMI).NotNull().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(k => k.VITES_TURU).NotNull().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(k => k.RENK).NotNull().WithMessage("Renk belirtiniz!");
            RuleFor(k => k.MOTOR_GUCU).NotNull().WithMessage("Bu alan boş bırakılamaz.");
            RuleFor(k => k.FIYAT).NotNull().WithMessage("Bu alanı boş bırakamazsınız").ScalePrecision(2, 10);
           
        }
    }
}