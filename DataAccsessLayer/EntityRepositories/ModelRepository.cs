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
using ModelValidator = DataAccsessLayer.Validation.FluentValidation.ModelValidator;

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


        public ResponseModel modelEkle(TBL_MODEL mod)
        {
            ResponseModel respons = new ResponseModel();
            List<Hatas> hatas = new List<Hatas>();
            ModelValidator modValidation = new ModelValidator();
            var errorOrSucces = modValidation.Validate(mod);
            if (errorOrSucces.Errors.Count == 0)
            {
                try
                {

                    this.Insert(mod);
                    hatas.Add(new Hatas
                    {
                        Message = "İşlem Başarılı"
                    });
                    respons.Code = 1;
                    respons.Message = "Succes";
                    respons.Data = hatas;

                }
                catch (Exception ex)
                {
                    hatas.Add(new Hatas
                    {
                        Message = ex.ToString()
                    });
                    respons.Code = 3;
                    respons.Message = "Error";
                    respons.Data = hatas;
                }
            }
            else
            {
                foreach (var item in errorOrSucces.Errors)
                {
                    hatas.Add(new Hatas
                    {
                        Message = item.ErrorMessage //kaç tane hata varsa burda listeleyip döndürüyor
                    });
                }
                respons.Code = 3;
                respons.Message = "Error";
                respons.Data = hatas;

            }

            return respons;
        }
    }
}

        


  


