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
        public virtual DbSet<UserType> UserType { get; set; }
    }

    public class UyeKayitSetInitializer : CreateDatabaseIfNotExists<UyeKayitDbBaglan>
    {
        protected override void Seed(UyeKayitDbBaglan db)
        {
            db.PType.AddRange(new List<PType>()
            {
                new PType() { TName="Genel Müdür"},
                new PType() { TName="Müdür"},
                new PType() { TName="Eleman"},
                new PType() { TName="Stajer"},
            });
          
            db.User.AddRange(new List<User>()
            {
                new User() { UName="Admin",Pass="Admin",UserTypeID=1},
            });

            db.UserType.AddRange(new List<UserType>()
            {
                new UserType() { ID=1,UserTypeName="Admin"},
                new UserType() { ID=2,UserTypeName="Yönetici"},
                new UserType() { ID=3,UserTypeName="Üye Kayýt"},
                new UserType() { ID=4,UserTypeName="Üye Ýzleme"},
            });

            db.SaveChanges();
        }
    }
}


