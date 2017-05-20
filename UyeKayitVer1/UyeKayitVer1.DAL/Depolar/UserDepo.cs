using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyeKayitVer1.Entitiy.Context;
using UyeKayitVer1.Entitiy.Models;

namespace UyeKayitVer1.DAL.Depolar
{
    public class UserDepo
    {
        public static void Add(User User)
        {
            using (UyeKayitDbBaglan db = new UyeKayitDbBaglan())
            {
                db.User.Add(User);
                db.SaveChanges();
            }
        }
        public static List<User> GetAll()
        {
            using (UyeKayitDbBaglan db = new UyeKayitDbBaglan())
            {
                return db.User.ToList();
            }
        }
    }
}
