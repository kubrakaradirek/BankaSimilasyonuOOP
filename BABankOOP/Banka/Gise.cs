using BABankOOP.Enums;
using BABankOOP.Insanlar.Musteriler;
using BABankOOP.Insanlar.Personeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Banka
{
    public class Gise
    {
        private Veznedar Vezndar { get; }
        public Gise(Veznedar veznedar)
        {
            this.Vezndar = veznedar;
           
            //bankaSubesi.MusteriOlustur(Musterim); !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        }

        public Musteri Musterim { get; set; }
        public IslemSonucu Sonuc { get; set; }

        public void MusteriCagirveİsleminiYap(Musteri musteri)
        {
            this.Musterim = musteri;
            IslemYap(musteri);
            this.Musterim.Sonuc = this.Sonuc;
            MusteriyiSonucHakkindaBilgilendir();
            this.Musterim = null;
        }

        public void MusteriyiSonucHakkindaBilgilendir()
        {
            this.Musterim.Sonuc = this.Sonuc;
        }

        public void IslemYap(Musteri musteri, decimal miktar)
        {
            IslemTuru islemTuru = new IslemTuru();
            switch (islemTuru)
            {
                case IslemTuru.ParaCekme:
                    ParaCek(musteri);
                    break;
                case IslemTuru.ParaYatirma:
                    ParaYatir(musteri, miktar);
                    break;
                default:
                    throw new Exceptions.ExceptionGecersizIslem();
            }
        }

        public void ParaYatir(Musteri musteri, decimal miktar)
        {
            musteri.Bakiye += musteri.Miktar;
        }

        public void ParaCek(Musteri musteri)
        {
            if (musteri.Bakiye >= musteri.Miktar)
            {
                musteri.Bakiye -= musteri.Miktar;
            }
            else
            {
                throw new Exceptions.ExceptionYetersizBakiye();
            }
        }




    }
}
