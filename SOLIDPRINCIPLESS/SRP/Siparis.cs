using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLESS.SRP
{
    public class SiparisItem
    {
        public int UrunId { get; set; }
        public short Adet { get; set; }
        public decimal SatisFiyati { get; set; }
    }

    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fiyat { get; set; }

    }

    public class Musteri
    {

        public string AdiSoyadi { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
    }

    public class MesajServisi
    {
        public void EPostaGonder(string musteriMail,string mesaj)
        {

        }

        public void SMSGonder(string musteriNo,string mesaj)
        {

        }
    }

    public class SatinAlma
    {
        public void SatinAl(List<SiparisItem> sepet,string musteri)
        {

        }
    }

    public static class KodOlusturucu
    {
        public static string SiparisKodOlustur()
        {
            return "sr3rsdfd";
        }

        public static string IslemTakipKoduOlustur()
        {
            return "23435345345";
        }

        public static string UrunKoduOlustur()
        {
            return "afdsdfsdf874512";
        }
    }

    public class Sepet
    {
        public List<SiparisItem> Sepettekiler { get; set; }
    }

    public class Siparis
    {
        MesajServisi _mesajServisi;
        SatinAlma _satinAlma;

        public Siparis()
        {
            _mesajServisi = new MesajServisi();
            _satinAlma = new SatinAlma();
        }

        public void siparisVer(Sepet sepet,Musteri ms)
        {
            string siparisKodu = KodOlusturucu.SiparisKodOlustur();
            _satinAlma.SatinAl(sepet.Sepettekiler,ms.AdiSoyadi);
            _mesajServisi.EPostaGonder(ms.Mail, "Siparişiniz Oluşturuldu");
        }
    }


    #region KotuSenaryo
    //public class Siparis
    //{
    //    private string SiparisKoduUret()
    //    {
    //        return "XADF565662";
    //    }

    //    public void SiparisVer(List<SiparisItem> sepet,string musteri)
    //    {
    //        //sipariş kodları
    //        string kod = SiparisKoduUret();
    //        SatinAl(sepet, musteri);
    //        //database kayıt at
    //        mesajAt();
    //    }

    //    private void mesajAt()
    //    {

    //    }
    //    private void SatinAl(List<SiparisItem> sepet,string musteri)
    //    {
    //        //satın alma kodları
    //    }
    //}
    #endregion


}
