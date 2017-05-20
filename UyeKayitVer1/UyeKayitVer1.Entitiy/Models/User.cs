

namespace UyeKayitVer1.Entitiy.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UName { get; set; }
        public string Usname { get; set; }
        public string Pass { get; set; }

        public int UserTypeID { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
