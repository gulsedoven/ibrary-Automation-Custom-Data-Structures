using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.VeriYapilari
{
    internal class Kuyruk
    {
        private Node Head;

        private Node Tail;
        public int ElemanSayisi { get; set; } // Kuyruktaki eleman sayısını tutar.

        public void EkleKuyruk(object veri)
        {
            Node newNode = new Node(veri);

            if (Head == null)//KUYRUK boşsa eklenen eleman hem ilk hem son düğümdür.
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            ElemanSayisi++; //Eklenen eleman sayısını arttırrır.
        }
        public object KuyrukCıkart()
        {
            if (Head == null) //KUyruk boşsa null döndürülür.
            {
                return null;
            }
            object veri = Head.Veri;

            Head = Head.Next;

            if (Head == null)
            {
                Tail = null;
            }
            ElemanSayisi--;//Çıkartılan eleman sayısı.

            return veri;
        }
        public bool IsEmpty()
        {
            return Head == null;
        }
        public object[] ListeyiGetir()
        {
            int sayac = 0;
            Node temp = Head;
            while (temp != null)//Önce sayaç hesaplanır
            {
                sayac++;
                temp = temp.Next;
            }

            object[] dizi = new object[sayac];
            temp = Head;
            int index = 0;
            while (temp != null)//Diziye atılır.
            {
                dizi[index] = temp.Veri;
                temp = temp.Next;
                index++;
            }

            return dizi;
        }
    }
}
