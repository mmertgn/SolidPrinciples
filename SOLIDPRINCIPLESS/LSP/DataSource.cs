using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPRINCIPLESS.LSP
{
    #region KotuSenaryo
    //public abstract class DataSource
    //{
    //    public abstract void GetAllData();
    //    public abstract void Save();
    //}
    //public class DatabaseSource : DataSource
    //{
    //    public override void GetAllData()
    //    {
    //        //Veri çekme
    //    }
    //    public override void Save()
    //    {
    //        //veri kaydetme
    //    }
    //}
    //public class ExcelFile : DataSource
    //{
    //    public override void GetAllData()
    //    {
    //        //Veri çekme
    //    }
    //    public override void Save()
    //    {
    //        //veri kaydetme
    //    }
    //}
    ////Burada Save işlemi xml için yapılmasın isteniyor o yüzden save içi except
    //public class XMLSource : DataSource
    //{
    //    public override void GetAllData()
    //    {
    //        //Veri çekme
    //    }
    //    public override void Save()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion

    #region MyRegion
    public abstract class DataSource
    {
        public abstract void GetAllData();
    }

    public interface ISaveData
    {
        void Save();
    }

    public class DatabaseSource : DataSource,ISaveData
    {
        public override void GetAllData()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
    public class ExcelFile : DataSource, ISaveData
    {
        public override void GetAllData()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    //Xml de save işlemi olmadığında save interface ini implemente etmeyerek lsp ye uygun kod yazmış oluruz.
    public class XMLFile : DataSource
    {
        public override void GetAllData()
        {
            throw new NotImplementedException();
        }
        
    }
    #endregion
    //Olması Gereken


}
