using DataAccsessLayer.Abstract;
using DataAccsessLayer.DTOs;
using DataAccsessLayer.Validation.FluentValidation;
using DataEntity;
//using DataEntity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using static DataAccsessLayer.ProdecureModels.ProdecureModels;


namespace DataAccsessLayer.EntityRepositories
{
    public class ModelRepository : Repository<TBL_MODEL>
    {
        public List<TBL_MODEL> ModelList()
        {
            var modelList = this.List();

            return modelList;
        }
        public List<TBL_MODEL> ModelAdinaGoreListele(string ModAdi)
        {
            var modelList = this.IList(x => x.MODEL_ADI == ModAdi);
            return modelList;
        }


        
             
    }


}
