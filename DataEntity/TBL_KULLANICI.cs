using DataEntity.ValidationRules.FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;

namespace DataEntity
{
   

    //[Validator(typeof(KullaniciValidator))]
    public partial class TBL_KULLANICI
    {
       
        public int ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string MAIL { get; set; }
        public string TELEFON { get; set; }
        public string KULLANICI_ADI { get; set; }
        public string SIFRE { get; set; }
    }
}


