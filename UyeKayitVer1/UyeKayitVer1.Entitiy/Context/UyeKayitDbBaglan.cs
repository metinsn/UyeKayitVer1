namespace UyeKayitVer1.Entitiy.Context
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class UyeKayitDbBaglan : DbContext
    {
        public UyeKayitDbBaglan()
            : base("name=UyeKayitDb")
        {
            Database.SetInitializer(new UyeKayitSetInitializer());
        }

        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PType> PType { get; set; }
        public virtual DbSet<User> User { get; set; }
    }

    public class UyeKayitSetInitializer : CreateDatabaseIfNotExists<UyeKayitDbBaglan>
    {
        protected override void Seed(UyeKayitDbBaglan db)
        {
            db.PType.AddRange(new List<PType>()
            {
                new PType() { TName="Genel M�d�r"},
                new PType() { TName="M�d�r"},
                new PType() { TName="Eleman"},
                new PType() { TName="Stajer"},
            });
            db.User.AddRange(new List<User>()
            {
                new User() { UName="Admin",Pass="Admin"},
            });
            db.SaveChanges();
        }
    }
}


