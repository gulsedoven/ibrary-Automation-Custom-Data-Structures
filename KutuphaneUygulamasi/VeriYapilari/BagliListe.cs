using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.VeriYapilari
{
    internal class BagliListe
    {
        public Node Head { get; set; }
        public void Add(object veri)
        {
            Node newNode = new Node(veri);//Boşsa başa eklenir.
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;//son düğümün nextini yeni düğüme bağlarız.
            }
        }
        public object[] ListeyiGetir()
        {
            int sayac = 0;//Listedeki eleman sayısını hesapladık.   
            Node temp = Head;
            int index = 0;
            while (temp != null)
            {
                sayac++;
                temp = temp.Next;


            }
            object[] dizi = new object[sayac];//sayaca bağlı dizi oluşturuyoruz.
            temp = Head;
            index = 0;
            while (temp != null)//gezerek diziyi aktarıyoruz.
            {
                dizi[index] = temp.Veri;
                temp = temp.Next;
                index++;

            }
            return dizi;


        }
        public void Sil(object silinecekVeri)
        {
            if (Head == null) //Boşsa işlem yapılmaz.
                return;


            if (Head.Veri == silinecekVeri)//Headi headden sonraki düğüm yapıyoruz.
            {
                Head = Head.Next; 
                return;
            }


            Node current = Head;
            while (current.Next != null)//Silinecek düğümden bir önceki düğümü buluyoruz.
            {
 
                if (current.Next.Veri == silinecekVeri)
                {
                    current.Next = current.Next.Next;//Bağı kopartıp sonrakine bağlıyoruz.
                    return;
                }
                current = current.Next;
            }
        }
    }
}
