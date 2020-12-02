using DataEntity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity.ValidationRules.FluentValidation
{
    public class KategoriValidator : AbstractValidator<TBL_KATEGORILER>
    {
        public KategoriValidator()
        {
            RuleFor(k => k.KATEGORI_ADI).NotEmpty().WithMessage("Kategori adı boş olamaz.")
                .Length(3, 15).WithMessage("Kategori adı 3 ile 15 karakter arasında olmalıdır.");
        }
    }
}
