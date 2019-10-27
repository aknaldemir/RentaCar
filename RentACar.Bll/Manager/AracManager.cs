using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using RentACar.Dal.Concrete;
using RentACar.Entity;

namespace RentACar.Bll.Manager
{
    public class AracManager
    {
        private AracDal _aracDal;
        public AracManager()
        {
            _aracDal=new AracDal();
        }

        private int _result;

        public int Add(Arac arac)
        {
            if (arac!=null)
            {
                if (!string.IsNullOrWhiteSpace(arac.SasiNo) & arac.SasiNo.Length!=17)
                {
                   
                    if (arac.Kilometre>0)
                    {
                        if (arac.GunlukFiyat>0)
                        {
                            _result = _aracDal.Add(arac);
                        }
                        else
                        {
                            throw new Exception("Günlük Fiyat sıfırdan büyük olmalı.");
                        }
                    }
                    else
                    {
                        throw new Exception("Kilometre sıfırdan küçük olamaz.");
                    }
                }
                else
                {
                    throw new Exception("Şasi Numarası uygun formatta değil.");
                }
            }
            else
            {
                throw new Exception("Araç null olamaz");
            }   

            return _result;
        }



    }
}
