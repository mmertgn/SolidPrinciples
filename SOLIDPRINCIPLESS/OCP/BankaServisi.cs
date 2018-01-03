using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLESS.OCP
{
    public class MusteriBilgileri
    {
        public string KrediKartNo { get; set; }
        public string KartBitisSuresi { get; set; }
        public string CVC { get; set; }
        public string KartSahibi { get; set; }
        public string KartTipi { get; set; }
        public string IBAN { get; set; }


    }

    //bank servis değişem açık ama gelişeme kapalıdır.
    //çünki her bir müşteri isteğinde veya yapılan işlem trüeüne göre kodda güncellemeye gidilecektir.

    public abstract class BankaServisi
    {
        public abstract void OdemeYap(MusteriBilgileri ms);
    }

    public enum NakitOdemeTipi
    {
        KapidaOdeme,
        EFT,
        HAVALE
    }

    public class NakitOdeme : BankaServisi
    {
        private NakitOdemeTipi _odemeTipi;

        public NakitOdeme(NakitOdemeTipi odemeTipi)
        {
            _odemeTipi = odemeTipi;
        }

        public override void OdemeYap(MusteriBilgileri ms)
        {
            //Nakit işlemler için gerekli düzenlemeler buraya yapılsın
        }
    }

    public class KrediKartOdeme : BankaServisi
    {
        public override void OdemeYap(MusteriBilgileri ms)
        {
            
        }
    }

    public class TelefonNumarasiIleOdeme : BankaServisi
    {
        public override void OdemeYap(MusteriBilgileri ms)
        {
            throw new NotImplementedException();
        }
    }

    public class SanalKartIleOdeme : BankaServisi
    {
        public override void OdemeYap(MusteriBilgileri ms)
        {
           
        }
    }

    #region BadSenaryo
    //public class BankaServisi
    //{

    //    public void NakitSatinAl(MusteriBilgileri musteri)
    //    {
    //        //kapıda ödeme veya havale seçenekleri, para transfer EFT gibi kullanılabilir.
    //    }

    //    public void TelefonNumaraUzerindenSatinAl(MusteriBilgileri musteri)
    //    {
    //        //telefon bankacılığı kullanmak gerekir ve telefon üzerinden hesap entegrasyonu gereklidir. 
    //    }

    //    public void KrediKartiIleSatinAl(MusteriBilgileri musteri)
    //    {
    //        switch (musteri.KartTipi)
    //        {
    //            case "Master":
    //                //taksitlendirme senaryoları düşünülerek buraya farklı if else blokları yazılabilir.

    //                break;
    //            case "Visa":
    //                break;
    //            default:
    //                break;
    //        }
    //    }

    //    public void SanalKartIleSatinAl(MusteriBilgileri musteri)
    //    {
    //        //musterinin sanal kart puanı her 100 tl ve üzerinde 10 puan artsın.
    //        //eğer yeterli puanı varsa işlem yap.
    //    }

    //}
    #endregion


}
