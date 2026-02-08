using KutuphaneUygulamasi.VeriYapilari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.Modeller
{
    public class Ogrenci
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string OkulNo { get; set; }


        public int OduncAlinanKitapSayisi { get; set; }//Odunç alınan kitap sayısı 0 atanır istatislikler kısmında görüntülenebilmesi için.

        public Ogrenci(string ad, string soyad, string okulNo)
        {
            Ad = ad;
            Soyad = soyad;
            OkulNo = okulNo;
            OduncAlinanKitapSayisi = 0; 
        }
        public override string ToString()
        {
            return $"{Ad} {Soyad} - No: {OkulNo}";
        }
    }
}