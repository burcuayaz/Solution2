using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.ProdecureModels
{
    public class ProdecureModels
    {
        public class prc_MODEL_ARAC_LIST
        {
            public string katAdi { get; set; }
        }

        public class MODEL_ARAC_LIST
        {
            public int KAT_ID { get; set; }

            public int MARKA_ID { get; set; }
            public string KATEGORI_ADI { get; set; }

            public string MARKA_ADI { get; set; }

        }




        public class prc_MODEL_MARKA_ARAC_LIST
        {
            public string katAdi { get; set; }
            public string marAdi { get; set; }
        }
        public class MODEL_MARKA_ARAC_LIST
        {
            public int KAT_ID { get; set; }

            public int MODEL_ID { get; set; }
            public int MARKA_ID { get; set; }

            public string KATEGORI_ADI { get; set; }

            public string MARKA_ADI { get; set; }
            public string MODEL_ADI { get; set; }

        }




        public class prc_MODEL_DETAY
        {
            public string katAdi { get; set; }
            public string marAdi { get; set; }
            public string modAdi { get; set; }

        }
        public class MODEL_DETAY
        {
            public int KAT_ID { get; set; }
            public int MODEL_ID { get; set; }
            public int MARKA_ID { get; set; }
            public string KATEGORI_ADI { get; set; }
            public string MARKA_ADI { get; set; }
            public decimal FIYAT { get; set; }
            public string RENK { get; set; }
            public int MOTOR_GUCU { get; set; }
            public int MOTOR_HACMI { get; set; }
            public string VITES_TURU { get; set; }
            public string RESIM { get; set; }
            public string ACIKLAMA { get; set; }
        }
    }
}

