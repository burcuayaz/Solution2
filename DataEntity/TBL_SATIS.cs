using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    using DataEntity.ValidationRules.FluentValidation;
    using FluentValidation.Attributes;
    using System;
    using System.Collections.Generic;

  //  [Validator(typeof(SatisValidator))]
    public partial class TBL_SATIS
    {
        public int ID { get; set; }
        public int KATEGORI_ID { get; set; }
        public int MARKA_ID { get; set; }
        public int MODEL_ID { get; set; }
        public int MUSTERI_ID { get; set; }
        public int ADET { get; set; }
        public decimal FIYAT { get; set; }
        public System.DateTime TARIH { get; set; }

        public virtual TBL_KATEGORILER TBL_KATEGORILER { get; set; }
        public virtual TBL_MARKA TBL_MARKA { get; set; }
        public virtual TBL_MODEL TBL_MODEL { get; set; }
        public virtual TBL_MUSTERILER TBL_MUSTERILER { get; set; }
    }
}

