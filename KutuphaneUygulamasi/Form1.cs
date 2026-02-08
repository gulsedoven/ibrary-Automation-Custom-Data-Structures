using KutuphaneUygulamasi.Modeller;     // Kitap sınıfını görmek için
using KutuphaneUygulamasi.VeriYapilari; // BagliListe sınıfını görmek için




namespace KutuphaneUygulamasi
{
    public partial class Form1 : Form
    {
        BagliListe tumKitaplar = new BagliListe();
        BagliListe tumOgrenciler = new BagliListe();
        Stack islemLoglari = new Stack();
        public Form1()
        {
            InitializeComponent();
            OrnekVerileriYukle();


        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {

            string ad = txtKitapAd.Text;
            string yazar = txtYazar.Text;
            string isbn = txtISBN.Text;
            string kategori = cmbKategori.Text;

            if (ad == "" || isbn == "" || kategori == "") //Bilgilerin boş olup olmadığını kontrol et.

            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun!");
                return;
            }


            Kitap yeniKitap = new Kitap(ad, yazar, isbn, kategori);//Kitap sınıfından yeni bir nesne oluştur.
            if (isbn.Length != 13 && isbn.Length != 10)// ISBN uzunluk kontrolü 

            {
                MessageBox.Show("ISBN numarası 10 veya 13 haneli olmalıdır!");
                return;
            }

            tumKitaplar.Add(yeniKitap);
            ListeyiGuncelle();
            Temizle();

            MessageBox.Show("Kitap başarıyla eklendi!");


        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            string arananKelime = txtArama.Text.ToLower(); //Bu eklenmediğinde büyük küçük harf sorunu oluyor.

            lstKitaplar.Items.Clear(); 

            object[] kitaplar = tumKitaplar.ListeyiGetir();//Bağlı listeden kitap listesi alınıyor.

            foreach (object obj in kitaplar)
            {
                Kitap k = (Kitap)obj;

                if (k != null)
                {
                    if (k.Ad.ToLower().Contains(arananKelime) || k.Yazar.ToLower().Contains(arananKelime) ||k.ISBN.Contains(arananKelime))
                    {
                        // Eşleşiyorsa listeye ekle
                        lstKitaplar.Items.Add(k);
                    }
                }
            }

            if (lstKitaplar.Items.Count == 0)//Eğer kitap yoksa uyar.
            {
                MessageBox.Show("Aradığınız kriterlere uygun kitap bulunamadı.");
                ListeyiGuncelle();
            }
        }
        private void btnKitapSil_Click(object sender, EventArgs e)
        {

            if (lstKitaplar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen silinecek kitabı seçin!");
                return;
            }

            Kitap secilenKitap = (Kitap)lstKitaplar.SelectedItem;


            tumKitaplar.Sil(secilenKitap);

            ListeyiGuncelle();
            MessageBox.Show("Kitap silindi.");
        }

        private void ListeyiGuncelle()
        {
            lstKitaplar.Items.Clear(); // Temizlenip çalıştırılıyormuş.

            object[] kitaplar = tumKitaplar.ListeyiGetir(); // Listeyi çekiyoruz.

            foreach (object k in kitaplar)
            {
                if (k != null)
                {
                    lstKitaplar.Items.Add(k);
                }
            }
        }

        private void Temizle()
        {
            txtKitapAd.Clear();
            txtYazar.Clear();
            txtISBN.Clear();
            cmbKategori.Text = "";
        }
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {

            string ad = txtOgrAd.Text;
            string soyad = txtOgrSoyisim.Text;
            string no = txtOgrNo.Text;

            if (ad == "" || soyad == "" || no == "")
            {
                MessageBox.Show("Lütfen tüm öğrenci bilgilerini doldurun!");//eksiklikler kontrol ediliyor.
                return;
            }

            if (!long.TryParse(no, out long sonuc))//Okul numarasının rakamlardan oluşup oluşmadığını kontrol etme kısmı eklendi.

            {
                MessageBox.Show("Okul numarası sadece rakamlardan oluşmalıdır! (Harf giremezsiniz)");
                return;
            }
            else if (no.Length != 10)
            {
                MessageBox.Show("Okul numarası tam 10 haneli olmalıdır!");
                return;
            }

            Ogrenci yeniOgrenci = new Ogrenci(ad, soyad, no);

            tumOgrenciler.Add(yeniOgrenci);  //Bağlı liste kodundan ekle

            OgrenciListesiniGuncelle();
            OgrenciTemizle();

            MessageBox.Show("Öğrenci başarıyla eklendi!");
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (listBoxOgrnci.SelectedIndex == -1)
            {
                MessageBox.Show("Silmek için listeden bir öğrenci seçmelisin!");
                return;
            }

            Ogrenci silinecek = (Ogrenci)listBoxOgrnci.SelectedItem;//Seçilen itemi alıyoruz.

            tumOgrenciler.Sil(silinecek);

            OgrenciListesiniGuncelle();
            MessageBox.Show("Öğrenci silindi.");
        }


        private void OgrenciListesiniGuncelle()
        {
            listBoxOgrnci.Items.Clear();//Liste temizlenir.

            object[] ogrenciler = tumOgrenciler.ListeyiGetir();

            foreach (object ogr in ogrenciler)
            {
                if (ogr != null)
                {
                    listBoxOgrnci.Items.Add(ogr);
                }
            }
        }


        private void OgrenciTemizle()//Liste temizleme fonk.
        {
            txtOgrAd.Clear();
            txtOgrSoyisim.Clear();
            txtOgrNo.Clear();
        }
        private void ComboBoxlariDoldur()
        {

            cmbKitapSecin.Items.Clear();
            cmbOgrenciSecin.Items.Clear();

            object[] kitaplar = tumKitaplar.ListeyiGetir();
            foreach (Kitap k in kitaplar)
            {
                if (k != null)
                    cmbKitapSecin.Items.Add(k.Ad);
            }

            object[] ogrenciler = tumOgrenciler.ListeyiGetir();//Öğrenciler comboxa aktarılıyor.
            foreach (Ogrenci o in ogrenciler)
            {
                if (o != null)
                    cmbOgrenciSecin.Items.Add(o.Ad + " " + o.Soyad);
            }
        }
        private void btnOduncAl_Click(object sender, EventArgs e)
        {
            if (cmbKitapSecin.SelectedIndex == -1 || cmbOgrenciSecin.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kitap ve bir öğrenci seçin!");
                return;
            }

            string secilenKitapAdi = cmbKitapSecin.Text;
            string secilenOgrenciAdi = cmbOgrenciSecin.Text;

            Kitap bulunanKitap = null;
            foreach (Kitap k in tumKitaplar.ListeyiGetir())
            {
                if (k != null && k.Ad == secilenKitapAdi) bulunanKitap = k;
            }

            Ogrenci bulunanOgrenci = null;
            foreach (Ogrenci o in tumOgrenciler.ListeyiGetir())
            {
                if (o != null && (o.Ad + " " + o.Soyad) == secilenOgrenciAdi) bulunanOgrenci = o;
            }


            if (bulunanKitap.MusaitlikDurumu == true)
            {
                bulunanKitap.MusaitlikDurumu = false;
                bulunanKitap.OduncAlan = bulunanOgrenci.Ad;


                bulunanKitap.OduncSayisi++;//İstatistik sayacı için ekledik.

                islemLoglari.Push($"{bulunanOgrenci.Ad}, '{bulunanKitap.Ad}' kitabını ödünç aldı.");//Log tutulması için ekledik.

                MessageBox.Show("Kitap öğrenciye verildi.");
            }
            else
            {
                bulunanKitap.RezervasyonKuyrugu.EkleKuyruk(bulunanOgrenci);//// Kitap meşgul ise öğrenci kuyruk yapısına eklenir.

                islemLoglari.Push($"Kitap dolu. {bulunanOgrenci.Ad}, '{bulunanKitap.Ad}' için sıraya girdi.");//Logları tutması iiçin ekleidk

                int siraSayisi = bulunanKitap.RezervasyonKuyrugu.ElemanSayisi;
                MessageBox.Show($"Kitap şu an başkasında! Öğrenci sıraya alındı.\nKuyruktaki Sıra: {siraSayisi}");
            }
        }

        private void btnIadeEt_Click(object sender, EventArgs e)
        {
            if (cmbKitapSecin.SelectedIndex == -1)
            {
                MessageBox.Show("İade edilecek kitabı seçin!");
                return;
            }

            string secilenKitapAdi = cmbKitapSecin.Text;
            Kitap bulunanKitap = null;
            foreach (Kitap k in tumKitaplar.ListeyiGetir())
                if (k != null && k.Ad == secilenKitapAdi) bulunanKitap = k;

            if (bulunanKitap.MusaitlikDurumu == true)
            {
                MessageBox.Show("Hata: Bu kitap zaten kütüphanede (müsait)!");
                return;
            }
            islemLoglari.Push($"'{bulunanKitap.Ad}' kitabı iade edildi.");


            if (!bulunanKitap.RezervasyonKuyrugu.IsEmpty())
            {

                Ogrenci siradakiOgrenci = (Ogrenci)bulunanKitap.RezervasyonKuyrugu.KuyrukCıkart();//Sıradan öğrenci almak için bu komut kullanıldı
                bulunanKitap.OduncAlan = siradakiOgrenci.Ad;//Kuyruktaki sıradaki öğrenci çekildi.
                bulunanKitap.MusaitlikDurumu = false;
                bulunanKitap.OduncSayisi++;
                islemLoglari.Push($"Kitap otomatik olarak sıradaki {siradakiOgrenci.Ad} kişisine verildi.");

                MessageBox.Show($"İade alındı. Ancak sırada bekleyen {siradakiOgrenci.Ad} olduğu için kitap ona devredildi!");
            }
            else
            {

                bulunanKitap.MusaitlikDurumu = true;
                bulunanKitap.OduncAlan = ""; // Kimse yok

                MessageBox.Show("Kitap iade alındı ve rafa kaldırıldı. ");
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void LoglariListele()
        {

            listLogGecmisi.Items.Clear();
            object[] loglar = islemLoglari.ListeyiGetir();

            if (loglar != null)
            {
                foreach (object log in loglar)
                {
                    listLogGecmisi.Items.Add(log);
                }
            }


            EnCokOkunanlariHesapla();
        }

        private void EnCokOkunanlariHesapla()
        {
            lstEnCokOkunanlar.Items.Clear();


            object[] anaVeri = tumKitaplar.ListeyiGetir();
            if (anaVeri == null || anaVeri.Length == 0) return;


            int boy = anaVeri.Length;
            Kitap[] siralanacakDizi = new Kitap[boy];

            for (int i = 0; i < boy; i++)
            {
                siralanacakDizi[i] = (Kitap)anaVeri[i];
            }
            for (int i = 0; i < boy - 1; i++)//Bubble Sort ile sıralama yapıyoruz.
            {
                for (int j = 0; j < boy - i - 1; j++)//Kitap ödünç alma sayıları karşılaştırılıyor.
                {
                    if (siralanacakDizi[j].OduncSayisi < siralanacakDizi[j + 1].OduncSayisi)//Swap
                    {
                        Kitap gecici = siralanacakDizi[j];
                        siralanacakDizi[j] = siralanacakDizi[j + 1];
                        siralanacakDizi[j + 1] = gecici;
                    }
                }
            }

            int yazdirilacakAdet;//Listeleme yapılacak sayı tutuluyor.

            if (boy < 5)
            {
                yazdirilacakAdet = boy;
            }
            else
            {
                yazdirilacakAdet = 5;
            }

            for (int i = 0; i < yazdirilacakAdet; i++)
            {
                Kitap k = siralanacakDizi[i];
                lstEnCokOkunanlar.Items.Add($"{i + 1}. {k.Ad} - ({k.OduncSayisi} kez okundu)");
            }
        }


        private void btnTabloYenile_Click(object sender, EventArgs e)
        {
            LoglariListele();
            MessageBox.Show("Tablo güncellendi!");//Logları tekrar listeleyip tabloyu yeniler.
        }
        private void TumPanelleriGizle()  //Önce paneller  gizlenir.
        {

            if (pnlKitapIslemleri != null) pnlKitapIslemleri.Visible = false;
            if (pnlOgrenciIslemleri != null) pnlOgrenciIslemleri.Visible = false;
            if (pnlOduncIade != null) pnlOduncIade.Visible = false;
            if (pnlLoglar != null) pnlLoglar.Visible = false;
        }
        private void btnKitapIslemleri_Click(object sender, EventArgs e)
        {
            TumPanelleriGizle();

            pnlKitapIslemleri.Visible = true;
            pnlKitapIslemleri.BringToFront();// Bu paneli en öne getirir
        }

    
        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            TumPanelleriGizle();
            pnlOgrenciIslemleri.Visible = true;
            pnlOgrenciIslemleri.BringToFront();// Bu paneli en öne getirir
        }

       
        private void btnOduncIade_Click(object sender, EventArgs e)
        {
            TumPanelleriGizle();
            pnlOduncIade.Visible = true;


            pnlOduncIade.BringToFront();

            ComboBoxlariDoldur();
        }

        
        private void btnLoglar_Click(object sender, EventArgs e)
        {
            TumPanelleriGizle();
            pnlLoglar.Visible = true;
            pnlLoglar.BringToFront();

            LoglariListele();
        }

     
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (pnlKitapIslemleri != null) pnlKitapIslemleri.Parent = this;  // Panellerin parent'ını form olarak ekliyoruz.
            if (pnlOgrenciIslemleri != null) pnlOgrenciIslemleri.Parent = this;
            if (pnlOduncIade != null) pnlOduncIade.Parent = this;
            if (pnlLoglar != null) pnlLoglar.Parent = this;

            System.Drawing.Point panelKonumu = new System.Drawing.Point(280, 68);// Panellerin konum HATASI almamak için eklendi

            if (pnlKitapIslemleri != null) pnlKitapIslemleri.Location = panelKonumu;
            if (pnlOgrenciIslemleri != null) pnlOgrenciIslemleri.Location = panelKonumu;
            if (pnlOduncIade != null) pnlOduncIade.Location = panelKonumu;
            if (pnlLoglar != null) pnlLoglar.Location = panelKonumu;


            TumPanelleriGizle();
            if (pnlKitapIslemleri != null)
            {
                pnlKitapIslemleri.Visible = true;
                pnlKitapIslemleri.BringToFront(); // Bu paneli en öne getirir
            }
        }
        private void OrnekVerileriYukle()//Ornek veriler yüklendi.
        {

            tumKitaplar.Add(new Kitap("Sefiller", "Victor Hugo", "9789750736", "Roman"));
            tumKitaplar.Add(new Kitap("Suç ve Ceza", "Fyodor Dostoyevski", "9789750719", "Roman"));
            tumKitaplar.Add(new Kitap("1984", "George Orwell", "9789750718", "Bilim Kurgu"));
            tumKitaplar.Add(new Kitap("Simyacı", "Paulo Coelho", "9789750726", "Roman"));
            tumKitaplar.Add(new Kitap("Kürk Mantolu Madonna", "Sabahattin Ali", "9789753638", "Roman"));
            tumKitaplar.Add(new Kitap("Yüzüklerin Efendisi", "J.R.R. Tolkien", "9789753420", "Fantastik"));
            tumKitaplar.Add(new Kitap("Harry Potter", "J.K. Rowling", "9789750802", "Fantastik"));
            tumKitaplar.Add(new Kitap("Da Vinci Şifresi", "Dan Brown", "9789752104", "Gerilim"));
            tumKitaplar.Add(new Kitap("Dönüşüm", "Franz Kafka", "9789750715", "Hikaye"));
            tumKitaplar.Add(new Kitap("Nutuk", "Mustafa Kemal Atatürk", "9789751020", "Tarih"));


            tumOgrenciler.Add(new Ogrenci("Ahmet", "Yılmaz", "2023100101"));
            tumOgrenciler.Add(new Ogrenci("Ayşe", "Demir", "2023100102"));
            tumOgrenciler.Add(new Ogrenci("Mehmet", "Kaya", "2023100103"));
            tumOgrenciler.Add(new Ogrenci("Fatma", "Çelik", "2023100104"));
            tumOgrenciler.Add(new Ogrenci("Ali", "Öztürk", "2023100105"));


            ListeyiGuncelle();
            OgrenciListesiniGuncelle();
        }

    }


}
