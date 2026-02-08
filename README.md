#  Kütüphane Rezervasyon ve Takip Sistemi

Bu proje, **Veri Yapıları ve Algoritmalar** dersi kapsamında geliştirilmiş bir C# Windows Forms uygulamasıdır. Hazır veri yapıları (List, Queue, Stack) yerine, bu yapılar manuel olarak kodlanmıştır.

##  Projenin Amacı
Kütüphane otomasyonu simülasyonu ile şu işlemler gerçekleştirilmektedir:
* Kitap Ekleme ve Takibi
* Öğrenci Kaydı ve Listeleme
* Kitap Ödünç Verme / İade Alma
* Otomatik Rezervasyon Ataması

## Kullanılan Veri Yapıları 

Projede C# hazır koleksiyonları yerine kendi geliştirdiğim sınıflar kullanılmıştır:

### 1. Bağlı Liste (Linked List)
* **Kullanım Yeri:** Kitapların ve Öğrencilerin listesini tutmak için kullanıldı.
* **Özellik:** Tek yönlü bağlı liste (Singly Linked List) yapısındadır. Veri ekleme, silme ve arama işlemlerinde temel yapı olarak görev yapar.

### 2. Kuyruk (Queue)
* **Kullanım Yeri:** Ödünç alınan bir kitabı bekleyen öğrencilerin rezervasyon sırası için kullanıldı.
* **Mantık:** **İlk Giren İlk Çıkar** mantığıyla çalışır. Kitap müsait değilse öğrenci `EkleKuyruk()` ile sıraya alınır. Kitap iade edildiğinde `KuyrukCikart()` metodu ile sıradaki öğrenciye otomatik atanır.

### 3. Yığıt (Stack)
* **Kullanım Yeri:** Sistemde yapılan işlemlerin (Logların) kaydını tutmak için kullanıldı.
* **Mantık:** **Son Giren İlk Çıkar** mantığıyla çalışır. Son yapılan işlem en üstte görüntülenir.

##  Kullanılan Algoritmalar

* **Sıralama (Bubble Sort):** "En Çok Okunan Kitaplar" listesi oluşturulurken, kitapların ödünç alma sayılarına göre büyükten küçüğe sıralanması için Kabarcık Sıralama algoritması kullanıldı.
* **Arama (Linear Search):** Kitap arama kutusunda; Kitap Adı, Yazar veya ISBN üzerinden filtreleme yapmak için Doğrusal Arama mantığı kullanıldı.

##  Ekran Görüntüleri
<img width="2011" height="1047" alt="Ekran görüntüsü 2025-12-29 025514" src="https://github.com/user-attachments/assets/97cb9c98-4815-40b6-a455-a59b99afa138" />
<img width="2022" height="1050" alt="Ekran görüntüsü 2025-12-29 025537" src="https://github.com/user-attachments/assets/b6d73011-d68d-40b5-a735-891986a5c738" />

<img width="2012" height="1055" alt="Ekran görüntüsü 2025-12-29 025646" src="https://github.com/user-attachments/assets/a8669537-f876-4462-a09b-8160a11d1739" />

Kurulum ve Çalıştırma:
1. Projeyi Visual Studio ile açın.
2. `Start` tuşuna basın.
3. **Not:** Proje açıldığında `OrnekVerileriYukle()` metodu sayesinde sistem otomatik olarak 10 Kitap ve 5 Öğrenci ile dolu gelir. Test etmek için veri girmenize gerek yoktur.
   
**Geliştirici:** Gülse Döven

