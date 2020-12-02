
using DataEntity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataEntity.ValidationRules.FluentValidation
{
    public class MarkaValidator : AbstractValidator<TBL_MARKA>
    {
        public MarkaValidator()
        {
            RuleFor(k => k.KATEGORI_ID).NotNull().WithMessage("Bu alanı boş bırakmayınız");
            RuleFor(k => k.MARKA_ADI).NotNull().WithMessage("Bu alanı boş bırakamazsınız!").Length(2, 20);
        }
    }
}
