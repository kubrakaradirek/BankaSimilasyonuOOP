using BABankOOP.Enums;
using BABankOOP.Exceptions;
using BABankOOP.Insanlar.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Banka
{
    public class Numarator : Musteri
    {
        public List<Fis> fisNumarasiSirasi = new List<Fis>();

        public IslemTuru IslemTuru { get; set; }

        public Fis FisVer(Musteri musteri)
        {
            Fis fis = new Fis(musteri);
            fisNumarasiSirasi.Add(fis);
            return fis;
        }

        public int bireyselMusteriSayaci = 1; // aslında burası vipmüsteri sayacı
        public Musteri SonrakiMusteriyiAl()
        {
            if (fisNumarasiSirasi.Count > 0)
            {
                Fis sonrakiFis = fisNumarasiSirasi[0];
                fisNumarasiSirasi.RemoveAt(0); 
                
                if (sonrakiFis.Musteri is MusteriVip)
                {
                    bireyselMusteriSayaci++;
                    if (bireyselMusteriSayaci % 4 == 0)
                    {
                        Musteri sonrakiMusteriBireysel = fisNumarasiSirasi.FirstOrDefault(fis => fis.Musteri is MusteriBireysel)?.Musteri;  // Koleksiyonda, listede bulunan ilk değeri bize geri döner. Eğer bir veri yok ise de default olarak bir değer döner.       
                        Musteri sonrakiMusteriGise = fisNumarasiSirasi.FirstOrDefault(fis => fis.Musteri is MusteriGise)?.Musteri;

                        if (sonrakiMusteriBireysel != null && sonrakiMusteriGise != null)
                        {
                            fisNumarasiSirasi.RemoveAll(fis => fis.Musteri == sonrakiMusteriBireysel || fis.Musteri == sonrakiMusteriGise); 
                            return sonrakiMusteriBireysel;
                        }
                    }
                }
                else if (sonrakiFis.Musteri is MusteriBireysel || sonrakiFis.Musteri is MusteriGise)
                {
                    bireyselMusteriSayaci = 1; // Sıradaki müşteri bireysel veya gişe müşterisi olduğunda sayaç sıfırlanır
                }
                return sonrakiFis.Musteri;
            }            
             throw new ExceptionSiradaMusteriYok();
        }
    }
}


