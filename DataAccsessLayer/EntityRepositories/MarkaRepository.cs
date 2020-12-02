using DataAccsessLayer.Abstract;
using DataEntity;
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
    public class MarkaRepository : Repository<TBL_MARKA>
    {
        public List<TBL_MARKA> MarkaList(string KatAdi)
        {
            var markaList = this.List();
            return markaList;
        }
        public List<TBL_MARKA> MarkaAdinaGoreListele(string MarAdi)
        {
            var markaList = this.IList(x => x.MARKA_ADI == MarAdi);
            return markaList;
        }


        public List<TBL_MARKA> MarkaListFunc(Func<object, bool> p)
        {
            return (List<TBL_MARKA>)this.List().Where(p);
        }
    }

}
