using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.VeriYapilari
{
    internal class Node
    {
        public object Veri { get; set; }//her türlü veri tutması için object türünde tanımlandı.
        public Node Next { get; set; }
        public Node(object veri)
        {
            this.Veri = veri;
            this.Next = null; //Başlangıçta bağlı değil.
        }
    }
}
