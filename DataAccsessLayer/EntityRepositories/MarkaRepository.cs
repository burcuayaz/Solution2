﻿using DataAccsessLayer.Abstract;
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



        public ResponseModel markaEkle(TBL_MARKA mar)
        {
            ResponseModel respons = new ResponseModel();
            List<Hatas> hatas = new List<Hatas>();
            MarkaValidator marValidation = new MarkaValidator();
            var errorOrSucces = marValidation.Validate(mar);
            if (errorOrSucces.Errors.Count == 0)
            {
                try
                {

                    this.Insert(mar);
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
