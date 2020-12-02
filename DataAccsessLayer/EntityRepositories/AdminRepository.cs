using DataAccsessLayer.Abstract;
using DataEntity;
using DataEntity.ValidationRules.FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityRepositories
{

    public class AdminRepository : Repository<TBL_KULLANICI>
    {
        public List<TBL_KULLANICI> KullaniciList()
        {
            var KullaniciList = this.List();

            return KullaniciList;
        }


        public List<string> kullaniciEkle(TBL_KULLANICI kul)
        {
            this.Insert(kul);

            return null;
        }
    }
}
