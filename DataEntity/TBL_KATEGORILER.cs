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

   // [Validator(typeof(KategoriValidator))]
    public partial class TBL_KATEGORILER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_KATEGORILER()
        {
            this.TBL_MARKA = new HashSet<TBL_MARKA>();
            this.TBL_MODEL = new HashSet<TBL_MODEL>();
            this.TBL_SATIS = new HashSet<TBL_SATIS>();
        }

        public int ID { get; set; }
        public string KATEGORI_ADI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_MARKA> TBL_MARKA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_MODEL> TBL_MODEL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_SATIS> TBL_SATIS { get; set; }
    }
}
