using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    using FluentValidation.Attributes;
    using System;
    using System.Collections.Generic;

    //  [Validator(typeof(ModelValidator))]
    public partial class TBL_MODEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MODEL()
        {

        }

        public int ID { get; set; }
        public string MODEL_ADI { get; set; }
        public int KATEGORI_ID { get; set; }
        public int MARKA_ID { get; set; }
        public System.DateTime TARIH { get; set; }
        public Nullable<int> MOTOR_HACMI { get; set; }
        public string VITES_TURU { get; set; }
        public string RENK { get; set; }
        public Nullable<int> MOTOR_GUCU { get; set; }
        public decimal FIYAT { get; set; }
        //   public string RESİM { get; set; }
        //    public string ACIKLAMA { get; set; }


        public virtual TBL_KATEGORILER TBL_KATEGORILER { get; set; }
        public virtual TBL_MARKA TBL_MARKA { get; set; }
    }
     
}

