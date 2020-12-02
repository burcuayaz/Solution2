using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity

    {
        using System;
        using System.Collections.Generic;

        public partial class TBL_MARKA
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            public TBL_MARKA()
            {
                this.TBL_MODEL = new HashSet<TBL_MODEL>();
                this.TBL_SATIS = new HashSet<TBL_SATIS>();
            }

            public int ID { get; set; }
            public string MARKA_ADI { get; set; }
            public int KATEGORI_ID { get; set; }

            public virtual TBL_KATEGORILER TBL_KATEGORILER { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<TBL_MODEL> TBL_MODEL { get; set; }
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<TBL_SATIS> TBL_SATIS { get; set; }
        }
    }
