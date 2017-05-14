using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyeKayitVer1.Entitiy.Context;
using UyeKayitVer1.Entitiy.Models;
using UyeKayitVer1.Entitiy.Viewmodel;

namespace UyeKayitVer1.DAL.Depolar
{
    public class PersonDepo
    {
        public static void Add(Person Person)
        {
            using (UyeKayitDbBaglan db = new UyeKayitDbBaglan())
            {
                db.Person.Add(Person);
                db.SaveChanges();
            }
        }
        public static List<Person> GetAll()
        {
            using (UyeKayitDbBaglan db = new UyeKayitDbBaglan())
            {
                return db.Person.ToList();
            }
        }

        public static List<PersonVM> GetAllVM()
        {

            using (UyeKayitDbBaglan db= new UyeKayitDbBaglan())
            {
                return db.Person.Select(w => new PersonVM
                {
                    Pname = w.Pname,
                    Lastname = w.Lastname,
                    Phone = w.Phone,
                    Email= w.Email,
                    TName = w.PType.TName,
                }).ToList();


    }
        }


        

       
    
}
}
