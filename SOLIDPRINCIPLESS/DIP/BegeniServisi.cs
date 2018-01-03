using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLESS.DIP
{   //begeni servis üzerinden bir profil beğeniliyor yada begeni kaldırılıyor
    //yanlız bu işlemi yapabilmek için beğenilecek olan 
    //begeni işlemleri için bu servis database ile çalışmalı ve bu sayede bu işlemi yapmalıdır.

    public class Begeni
    {
        public string Begenen { get; set; }
        public string Begenilen { get; set; }
    }

    public static class BegeniBaglanti
    {
        public static BegeniDatabaseİslemi Baglan()
        {
            return new BegeniDatabaseİslemi();
        }
    }

    public class BegeniServisi
    {
        //BegeniDatabaseİslemi veriIslemleri = new BegeniDatabaseİslemi();
        BegeniDatabaseİslemi veriIslemleri = BegeniBaglanti.Baglan();

        //bir sınıfın içinde başka bir sınıftan doğrudan instance almamalıyız. bunun yerine bir aracı kullanmalıyız. 
        public void Begen(Begeni begeni)
        {
            if (veriIslemleri.BegeniVarMi())
            {
                veriIslemleri.BegeniSil(begeni);
            }
            else
            {
                veriIslemleri.Begen(begeni);
            }
        }
    }

    public class BegeniDatabaseİslemi
    {
        public bool BegeniVarMi()
        {
            return false;
        }

        public void Begen(Begeni b)
        {

        }

        public void BegeniSil(Begeni b)
        {

        }
    }

}
