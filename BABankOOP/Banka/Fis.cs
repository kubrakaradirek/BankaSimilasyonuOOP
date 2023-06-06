using BABankOOP.Insanlar.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BABankOOP.Banka
{
    public class Fis
    {
        public Musteri Musteri { get;}

        private static int _fisNumarasi = 1;

        public int FisNumarasi { get => _fisNumarasi++; }

        public Fis(Musteri musteri)
        {
            this.Musteri = musteri;
        }

        public void MusteriSorgula(BankaSubesi bankaSubesi , Numarator numarator)
        {

            if (bankaSubesi.vipMusteriler.Contains(this.Musteri))
            {
                Fis fisVip = new Fis((MusteriVip)this.Musteri);
                numarator.fisNumarasiSirasi.Add(fisVip);
            }
            else if (bankaSubesi.bireyselMusteriler.Contains(this.Musteri))
            {
                Fis fisBireysel = new Fis((MusteriBireysel)this.Musteri);
                numarator.fisNumarasiSirasi.Add(fisBireysel);
            }
            else
            {
                Fis fisGise = new Fis((MusteriGise)this.Musteri);
                numarator.fisNumarasiSirasi.Add(fisGise);
            }
        }
    }
}
