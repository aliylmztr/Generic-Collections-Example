namespace GenericCollectionsExample
{
    public class Musteri
    {
        public int id;
        public string isim;
        public string soyisim;
        public string email;

        public Musteri(int id, string isim, string soyisim, string email)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.email = email;
        }

        public override string ToString()
        {
            return "Id: " + this.id + " İsim: " + this.isim + " Soyisim: " + this.soyisim + " Email: " + this.email;
        }

    }
}
