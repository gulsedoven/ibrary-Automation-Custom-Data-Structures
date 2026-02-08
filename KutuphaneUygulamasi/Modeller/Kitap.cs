
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneUygulamasi.VeriYapilari;// Kuyruk sınıfını görebilmek için eklendi.

namespace KutuphaneUygulamasi.Modeller
{
    internal class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string ISBN { get; set; }
        public string Kategori { get; set; }
        public int OduncSayisi { get; set; } //Kitap ödünç alma sayısını tutar çünkü istatisliklerde en çok ödünç alınan 5 kitabı göstereceğiz.
        public bool MusaitlikDurumu { get; set; }
        public Kuyruk RezervasyonKuyrugu { get; set; }//Kuyruk yapısını kullanarak rezarvasyon kuyruğu oluşturduk.
        public string OduncAlan { get; set; } //Ödünç alma işlemleri için.
        
        public Kitap(string ad, string yazar, string isbn, string kategori)
        {
            Ad = ad;
            Yazar = yazar;
            ISBN = isbn;
            Kategori = kategori;
            OduncSayisi = 0;
            MusaitlikDurumu = true;
            RezervasyonKuyrugu = new Kuyruk();
        }
        public override string ToString()
        {
            return $"{Ad} - {Yazar} ({ISBN})"; //Kitap bilgilerini sade bir şekilde görmeye yarıyor.
        }
    }
}
