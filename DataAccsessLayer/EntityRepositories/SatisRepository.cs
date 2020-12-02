using DataAccsessLayer.Abstract;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityRepositories
{
   public class SatisRepository: Repository<TBL_SATIS>
    {
        public List<TBL_SATIS> SatisList()
        {
            var SatisList = this.List();

            return SatisList;
        }
    }
}
