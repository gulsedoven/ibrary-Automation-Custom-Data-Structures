using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi.VeriYapilari
{
    internal class Stack
    {
        private Node Top;
        public Stack()
        {
            Top = null;
        }

        public void Push(object veri)
        {
            Node newNode = new Node(veri);  
            if (Top == null)//Yığıt boşsa yeni düğüm top olur.
            {
                Top = newNode;
            }
            else
            {
                newNode.Next = Top;//Yeni top yeni düğğüm olur.
                Top = newNode;
            }
        }
        public object Pop()
        {
            if (Top == null)//Yığıt boşsa geriye dönmez.
            {
                return null;
            }
            object veri = Top.Veri;//Nesne olarak atandı.
            Top = Top.Next;//Düğümü kaydır.
            return veri;
        }
        public object[] ListeyiGetir()
        {

            int sayac = 0;//Kayıtları sayac olarak hesaplıyoruz.
            Node temp = Top;
            while (temp != null)
            {
                sayac++;
                temp = temp.Next;
            }
            object[] dizi = new object[sayac];//Sayac kadar dizi oluşturup verileri tek tek aktarıyoruz.
            temp = Top;
            int index = 0;
            while (temp != null)
            {
                dizi[index] = temp.Veri;
                temp = temp.Next;
                index++;
            }
            return dizi;
        }
    }
}

