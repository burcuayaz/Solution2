using DataAccsessLayer.EntityFramework;
using DataEntity;
//using DataEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccsessLayer.ProdecureModels.ProdecureModels;

namespace DataAccsessLayer.Procedures
{
    public class Procedures
    {
        public List<MODEL_ARAC_LIST> KATEGORI_ARAC_LIST(prc_MODEL_ARAC_LIST v)
        {
            //GET_KATEGORI_ARAC @katAdi
            if (v == null) throw new ArgumentNullException("Storre Procedur:GET_KATEGORI_ARAC parametreleri Null olamaz");
            var prm1 = new SqlParameter("@katAdi", v.katAdi);
            using (var dataContext = new DataContext())
            {
                var sqlQery = dataContext.Database.SqlQuery<MODEL_ARAC_LIST>("GET_KATEGORI_ARAC @katAdi", prm1).ToList();
                return sqlQery;
            }
        }

        //public DataContext dataContext { get { return new DataContext(); } }
        public List<MODEL_MARKA_ARAC_LIST> KATEGORI_MARKA_MODEL_LIST(prc_MODEL_MARKA_ARAC_LIST v)
        {
            //GET_KATEGORI_MARKA_MODEL @katAdi, @marAdi
            if (v == null) throw new ArgumentNullException("Storre Procedur:GET_KATEGORI_MARKA_MODEL parametreleri Null olamaz");
            var prm1 = new SqlParameter("@katAdi", v.katAdi);
            var prm2 = new SqlParameter("@marAdi", v.marAdi);
            using (var dataContext = new DataContext())
            {
                var sqlQery = dataContext.Database.SqlQuery<MODEL_MARKA_ARAC_LIST>("GET_KATEGORI_MARKA_MODEL @katAdi, @marAdi", prm1, prm2).ToList();
                return sqlQery;
            }
        }


        public List<MODEL_DETAY> MODEL_DETAY_SAYFASI(prc_MODEL_DETAY v)
        {
            //GET_MODEL_DETAY @katAdi, @marAdi, modAdi
            if (v == null) throw new ArgumentNullException("Storre Procedur:GET_MODEL_DETAY parametreleri Null olamaz");
            var prm1 = new SqlParameter("@katAdi", v.katAdi);
            var prm2 = new SqlParameter("@marAdi", v.marAdi);
            var prm3 = new SqlParameter("@modAdi", v.modAdi);
            using (var dataContext = new DataContext())
            {
                var sqlQery = dataContext.Database.SqlQuery<MODEL_DETAY>("GET_MODEL_DETAY @katAdi, @marAdi, @modAdi", prm1, prm2, prm3).ToList();
                return sqlQery;
            }
        }
    }
}

