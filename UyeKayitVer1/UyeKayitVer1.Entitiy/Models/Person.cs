
namespace UyeKayitVer1.Entitiy.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Pname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //diğer klas bağlantısı
        public int PTypeID { get; set; }
        public virtual PType PType { get; set; }


    }
}
