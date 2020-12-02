
using DataAccsessLayer.Abstract;
using DataEntity;
using DataEntity.ValidationRules.FluentValidation;
//using DataEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccsessLayer.ProdecureModels.ProdecureModels;

namespace DataAccsessLayer.EntityRepositories
{
    public class KategoriRepository : Repository<TBL_KATEGORILER>
    {

        public List<string> kategoriEkle(TBL_KATEGORILER k1)
        {
            this.Insert(k1);
            return null;
        }

        public List<TBL_KATEGORILER> KategoriAdinaGoreListele(string KatAdi)
        {
            var kategoriList = this.IList(x => x.KATEGORI_ADI == KatAdi);

            return kategoriList;
        }

    }
}
