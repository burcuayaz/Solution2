using DataAccsessLayer.Abstract;
using DataAccsessLayer.DTOs;
using DataAccsessLayer.Validation.FluentValidation;
using DataEntity;
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

        
        public ResponseModel kullaniciEkle(TBL_KULLANICI kul)
        {
            ResponseModel respons = new ResponseModel();
            List<Hatas> hatas = new List<Hatas>();
            KullaniciValidator kulValidation = new KullaniciValidator();
            var errorOrSucces = kulValidation.Validate(kul);
            if (errorOrSucces.Errors.Count==0)
            {
                try
                {

                    this.Insert(kul);
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
                        Message =item.ErrorMessage //kaç tane hata varsa burda listeleyip döndürüyor
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
