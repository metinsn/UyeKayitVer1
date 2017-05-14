using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyeKayitVer1.Entitiy.Context;
using UyeKayitVer1.Entitiy.Models;

namespace UyeKayitVer1.DAL.Depolar
{
    public class PTypeDepo
    {
        public static void Add( PType  PType)
        {
            using (UyeKayitDbBaglan db = new UyeKayitDbBaglan())
            {
                db. PType.Add( PType);
                db.SaveChanges();
            }
        }
        public static List< PType> GetAll()
        {
            using (UyeKayitDbBaglan db = new UyeKayitDbBaglan())
            {
                return db. PType.ToList();
            }
        }

       

    }
}
