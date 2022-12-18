using System;

namespace Erişim_Belirleyiciler_ve_Kurucu_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Söz Dizimi
            //class SinifAdi
            /*{
               [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
               [Erişim Belirleyici] [Geri Dönüş Tipi] ([Parametre Listesi])
               {
                   //Metot Komutları
               }
              }*/

              /*Erişim BElirleyici
                =)Public: Her yerden erişilebilir.
                =)Private: Sadece tanımlandığı sınıf içerisinden erişilebilir.
                =)Interenal:Sadece bulunduğu proje içerisinden erişilebilir
                =)Protected: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
                */

                Console.WriteLine("*****Çalışan 1******");
                Calisan calisan1=new Calisan("Ayşe","Kara",23425634,"İnsan Kaynakları");
                calisan1.CalisanBilgileri();

                Console.WriteLine("*****Çalışan 2******");

                Calisan calisan2=new Calisan();
                calisan2.Ad="Deniz";
                calisan2.Soyad="Arda";
                calisan2.No=25646789;
                calisan2.Departman="Satın Alma";

                calisan2.CalisanBilgileri();

                 Console.WriteLine("*****Çalışan 3******");

                 Calisan calisan3=new Calisan("Ayşe","Kara");

                calisan3.CalisanBilgileri();

            
             
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
        }

        public Calisan(string ad,string soyad)
        {
            this.Ad=ad;
            this.Soyad=soyad;
        }

        public Calisan()
        {

        }

        //Bu çalışan sınfımın bilgilerini yazdıracağım bir tanede metot Bu çalışsan sınıfının bilgilerini getiren metot

        public void CalisanBilgileri()
        {
           
           Console.WriteLine("Çalışan Adı: {0}",Ad);

           Console.WriteLine("Çalışan Soyadı: {0}",Soyad);

           Console.WriteLine("Çalışan Nosu: {0}",No);

           Console.WriteLine("Çalışan Departmanı: {0}",Departman);
           
        }
    }
}
