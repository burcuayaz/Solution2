
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
using static DataAccsessLayer.ProdecureModels.ProdecureModels;

namespace DataAccsessLayer.EntityRepositories
{
    public class KategoriRepository : Repository<TBL_KATEGORILER>
    {

        public ResponseModel kategoriEkle(TBL_KATEGORILER kat)
        {
            ResponseModel respons = new ResponseModel();
            List<Hatas> hatas = new List<Hatas>();
            KategoriValidator katValidation = new KategoriValidator();
            var errorOrSucces = katValidation.Validate(kat);
            if (errorOrSucces.Errors.Count == 0)
            {
                try
                {

                    this.Insert(kat);
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
    

        public List<TBL_KATEGORILER> KategoriAdinaGoreListele(string KatAdi)
        {
            var kategoriList = this.IList(x => x.KATEGORI_ADI == KatAdi);

            return kategoriList;
        }
       
    }
}
