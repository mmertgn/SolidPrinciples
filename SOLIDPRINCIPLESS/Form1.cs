using SOLIDPRINCIPLESS.OCP;
using SOLIDPRINCIPLESS.SRP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLIDPRINCIPLESS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form h = new Form1();
        //Form yy = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {

            #region SRP


            var spp = new Sepet();
            spp.Sepettekiler = new List<SiparisItem>();

            Siparis s = new Siparis();
            s.siparisVer(spp, new Musteri());

            #endregion





            #region OCP

            //BankaServisi y = new SanalKartIleOdeme();
            //BankaServisi u = new TelefonNumarasiIleOdeme();
            //BankaServisi o = new KrediKartOdeme();

            //string odemeSekli = ConfigurationManager.AppSettings["OdemeSekli"];

            //var odemeTipi = Enum.Parse(typeof(NakitOdemeTipi), odemeSekli);

            //BankaServisi bs = new NakitOdeme((NakitOdemeTipi)odemeTipi);
            //bs.OdemeYap(new MusteriBilgileri());

            //BankaServisi bs = new SanalKartIleOdeme();
            //bs.OdemeYap(new MusteriBilgileri());
            #endregion





        }
    }
}
