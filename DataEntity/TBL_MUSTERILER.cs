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

   // [Validator(typeof(MusteriValidator))]
    public partial class TBL_MUSTERILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MUSTERILER()
        {
            this.TBL_SATIS = new HashSet<TBL_SATIS>();
        }

        public int ID { get; set; }
        public string ADSOYAD { get; set; }
        public string TELEFON { get; set; }
        public string ADRES { get; set; }
        public string MAIL { get; set; }
        public System.DateTime KAYIT_TARIHI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SATIS> TBL_SATIS { get; set; }
    }
}
