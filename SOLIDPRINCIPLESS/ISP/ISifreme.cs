using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLESS.ISP
{


    #region BadSenaryo

    //public interface ISifreme
    //{
    //    string Sifrele(string sifrelenecekMetin);
    //    string SifreCoz(string cozulecekMetin);
    //}

    //B sınıfı Isifrelenin tüm methodlarını kullanabilirken A sınıfı sadece 1 tanesini kullanması gerekiyor. Bu sebeple kullanılmayan dummy gereksiz kod oluşmuş oluyor. Bu sebeple interface sorumluluğunun başka interfacelere dağıtışması lazım.

    //Hash
    //public class ASifreleme : ISifreme
    //{
    //    public string SifreCoz(string cozulecekMetin)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string Sifrele(string sifrelenecekMetin)
    //    {
    //        return "Asfsdfsdfs";
    //    }
    //}

    //public class BSifreleme : ISifreme
    //{
    //    public string SifreCoz(string cozulecekMetin)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public string Sifrele(string sifrelenecekMetin)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    #endregion

    public interface ISifreCoz
    {
        string Coz(string sifre);
    } 

    public interface ISifrele
    {
        string Sifrele(string duzMetin);
    }

    public class A : ISifrele
    {
        public string Sifrele(string duzMetin)
        {
            throw new NotImplementedException();
        }
    }




}
