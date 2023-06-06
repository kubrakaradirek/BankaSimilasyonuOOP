using BABankOOP.Exceptions;
using BABankOOP.Insanlar.Musteriler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BABankOOP.Banka
{
    public class BankaSubesi
    {
        public List<MusteriVip> vipMusteriler = new List<MusteriVip>();
        public List<MusteriBireysel> bireyselMusteriler = new List<MusteriBireysel>();

        public BankaSubesi()
        {
            Oku();
        }

        ~BankaSubesi()
        {
            Kaydet();
        }

        public Musteri MusteriOlustur(Musteri musteri)
        {
            if (musteri.Bakiye > 100000)
            {
                MusteriVip musteriVip = (MusteriVip)musteri;
                vipMusteriler.Add(musteriVip);
            }
            else
            {
                MusteriBireysel musteriBireysel = (MusteriBireysel)musteri;
                bireyselMusteriler.Add(musteriBireysel);
            }
            return musteri;
        }

        public void Kaydet()
        {
            StreamWriter writerVip = new StreamWriter("vipMusteriler.Json");
            writerVip.Write(JsonSerializer.Serialize(vipMusteriler));
            writerVip.Close();

            StreamWriter writerBireysel = new StreamWriter("bireyselMusteriler.Json");
            writerBireysel.Write(JsonSerializer.Serialize(bireyselMusteriler));
            writerBireysel.Close();
        }

        public void Oku()
        {
            StreamReader readerVip = new StreamReader("vipMusteriler.Json");
            string jSon = readerVip.ReadToEnd();
            readerVip.Close();
            this.vipMusteriler = JsonSerializer.Deserialize<List<MusteriVip>>(jSon);

            StreamReader readerBireysel = new StreamReader("bireyselMusteriler.Json");
            string jSonn = readerBireysel.ReadToEnd();
            readerBireysel.Close();
            this.bireyselMusteriler = JsonSerializer.Deserialize<List<MusteriBireysel>>(jSonn);
        }
    }
}