namespace KutuphaneUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label3;
            Label label5;
            Label label4;
            Label label2;
            Label label13;
            pnlKitapIslemleri = new Panel();
            btnAra = new Button();
            txtArama = new TextBox();
            cmbKategori = new ComboBox();
            btnKitapSil = new Button();
            lstKitaplar = new ListBox();
            btnKitapEkle = new Button();
            txtISBN = new TextBox();
            txtYazar = new TextBox();
            txtKitapAd = new TextBox();
            label6 = new Label();
            cmbKitapSecin = new ComboBox();
            label10 = new Label();
            cmbOgrenciSecin = new ComboBox();
            btnOduncAl = new Button();
            btnIadeEt = new Button();
            pnlOduncIade = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnLoglar = new Button();
            btnCikis = new Button();
            btnOduncIade = new Button();
            btnOgrenciİslemleri = new Button();
            btnKitapİslemleri = new Button();
            pnlOgrenciIslemleri = new Panel();
            txtOgrAd = new TextBox();
            listBoxOgrnci = new ListBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnOgrenciSil = new Button();
            txtOgrNo = new TextBox();
            btnOgrenciEkle = new Button();
            txtOgrSoyisim = new TextBox();
            pnlLoglar = new Panel();
            btnTabloYenile = new Button();
            lstEnCokOkunanlar = new ListBox();
            listLogGecmisi = new ListBox();
            label12 = new Label();
            label11 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label13 = new Label();
            pnlKitapIslemleri.SuspendLayout();
            pnlOduncIade.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlOgrenciIslemleri.SuspendLayout();
            pnlLoglar.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 15F);
            label3.Location = new Point(42, 327);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 10;
            label3.Text = "Kategori:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 15F);
            label5.Location = new Point(39, 135);
            label5.Name = "label5";
            label5.Size = new Size(83, 30);
            label5.TabIndex = 3;
            label5.Text = "Yazar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 15F);
            label4.Location = new Point(39, 231);
            label4.Name = "label4";
            label4.Size = new Size(80, 30);
            label4.TabIndex = 2;
            label4.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 15F);
            label2.Location = new Point(39, 39);
            label2.Name = "label2";
            label2.Size = new Size(125, 30);
            label2.TabIndex = 0;
            label2.Text = "Kitap Adı:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Georgia", 15F);
            label13.Location = new Point(42, 568);
            label13.Name = "label13";
            label13.Size = new Size(127, 30);
            label13.TabIndex = 14;
            label13.Text = "Kitap Ara:";
            // 
            // pnlKitapIslemleri
            // 
            pnlKitapIslemleri.BackColor = Color.WhiteSmoke;
            pnlKitapIslemleri.Controls.Add(label13);
            pnlKitapIslemleri.Controls.Add(btnAra);
            pnlKitapIslemleri.Controls.Add(txtArama);
            pnlKitapIslemleri.Controls.Add(cmbKategori);
            pnlKitapIslemleri.Controls.Add(label3);
            pnlKitapIslemleri.Controls.Add(btnKitapSil);
            pnlKitapIslemleri.Controls.Add(label5);
            pnlKitapIslemleri.Controls.Add(label4);
            pnlKitapIslemleri.Controls.Add(label2);
            pnlKitapIslemleri.Controls.Add(lstKitaplar);
            pnlKitapIslemleri.Controls.Add(btnKitapEkle);
            pnlKitapIslemleri.Controls.Add(txtISBN);
            pnlKitapIslemleri.Controls.Add(txtYazar);
            pnlKitapIslemleri.Controls.Add(txtKitapAd);
            pnlKitapIslemleri.ForeColor = SystemColors.ControlText;
            pnlKitapIslemleri.ImeMode = ImeMode.NoControl;
            pnlKitapIslemleri.Location = new Point(49, 16);
            pnlKitapIslemleri.Name = "pnlKitapIslemleri";
            pnlKitapIslemleri.Size = new Size(1709, 902);
            pnlKitapIslemleri.TabIndex = 5;
            // 
            // btnAra
            // 
            btnAra.AutoEllipsis = true;
            btnAra.BackColor = SystemColors.GrayText;
            btnAra.FlatAppearance.BorderSize = 0;
            btnAra.FlatStyle = FlatStyle.Flat;
            btnAra.Font = new Font("Georgia", 15F);
            btnAra.ForeColor = SystemColors.ButtonHighlight;
            btnAra.Location = new Point(751, 556);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(220, 55);
            btnAra.TabIndex = 13;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = false;
            btnAra.Click += btnAra_Click;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(206, 574);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(200, 25);
            txtArama.TabIndex = 12;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { "Dünya Klasikleri", "Bilim Kurgu\t", "Fantastik", "Gerilim", "Hikaye", "", "Siyaset", "Roman", "Şiir", "Tarih\t" });
            cmbKategori.Location = new Point(206, 327);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(197, 26);
            cmbKategori.TabIndex = 11;
            // 
            // btnKitapSil
            // 
            btnKitapSil.AutoEllipsis = true;
            btnKitapSil.BackColor = SystemColors.GrayText;
            btnKitapSil.FlatAppearance.BorderSize = 0;
            btnKitapSil.FlatStyle = FlatStyle.Flat;
            btnKitapSil.Font = new Font("Georgia", 15F);
            btnKitapSil.ForeColor = SystemColors.ButtonHighlight;
            btnKitapSil.Location = new Point(1098, 430);
            btnKitapSil.Name = "btnKitapSil";
            btnKitapSil.Size = new Size(220, 55);
            btnKitapSil.TabIndex = 9;
            btnKitapSil.Text = "Kitap Sil";
            btnKitapSil.UseVisualStyleBackColor = false;
            btnKitapSil.Click += btnKitapSil_Click;
            // 
            // lstKitaplar
            // 
            lstKitaplar.FormattingEnabled = true;
            lstKitaplar.ItemHeight = 18;
            lstKitaplar.Location = new Point(39, 693);
            lstKitaplar.Name = "lstKitaplar";
            lstKitaplar.Size = new Size(1594, 166);
            lstKitaplar.TabIndex = 8;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.AutoEllipsis = true;
            btnKitapEkle.BackColor = SystemColors.GrayText;
            btnKitapEkle.FlatAppearance.BorderSize = 0;
            btnKitapEkle.FlatStyle = FlatStyle.Flat;
            btnKitapEkle.Font = new Font("Georgia", 15F);
            btnKitapEkle.ForeColor = SystemColors.ButtonHighlight;
            btnKitapEkle.Location = new Point(751, 430);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(220, 55);
            btnKitapEkle.TabIndex = 7;
            btnKitapEkle.Text = "Kitap Ekle";
            btnKitapEkle.UseVisualStyleBackColor = false;
            btnKitapEkle.Click += btnKitapEkle_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(206, 237);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(197, 25);
            txtISBN.TabIndex = 6;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(206, 141);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(197, 25);
            txtYazar.TabIndex = 5;
            // 
            // txtKitapAd
            // 
            txtKitapAd.Location = new Point(206, 45);
            txtKitapAd.Name = "txtKitapAd";
            txtKitapAd.Size = new Size(197, 25);
            txtKitapAd.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Georgia", 17F);
            label6.Location = new Point(54, 99);
            label6.Name = "label6";
            label6.Size = new Size(171, 34);
            label6.TabIndex = 0;
            label6.Text = "Kitap Seçin:";
            // 
            // cmbKitapSecin
            // 
            cmbKitapSecin.FormattingEnabled = true;
            cmbKitapSecin.Location = new Point(328, 99);
            cmbKitapSecin.Name = "cmbKitapSecin";
            cmbKitapSecin.Size = new Size(196, 26);
            cmbKitapSecin.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Georgia", 17F);
            label10.Location = new Point(54, 231);
            label10.Name = "label10";
            label10.Size = new Size(202, 34);
            label10.TabIndex = 2;
            label10.Text = "Öğrenci Seçin:";
            // 
            // cmbOgrenciSecin
            // 
            cmbOgrenciSecin.FormattingEnabled = true;
            cmbOgrenciSecin.Location = new Point(328, 237);
            cmbOgrenciSecin.Name = "cmbOgrenciSecin";
            cmbOgrenciSecin.Size = new Size(196, 26);
            cmbOgrenciSecin.TabIndex = 3;
            // 
            // btnOduncAl
            // 
            btnOduncAl.AutoEllipsis = true;
            btnOduncAl.BackColor = Color.DarkOliveGreen;
            btnOduncAl.FlatAppearance.BorderSize = 0;
            btnOduncAl.FlatStyle = FlatStyle.Flat;
            btnOduncAl.Font = new Font("Georgia", 15F);
            btnOduncAl.ForeColor = SystemColors.ButtonHighlight;
            btnOduncAl.Location = new Point(825, 408);
            btnOduncAl.Name = "btnOduncAl";
            btnOduncAl.Size = new Size(220, 55);
            btnOduncAl.TabIndex = 7;
            btnOduncAl.Text = "Ödünç Al";
            btnOduncAl.UseVisualStyleBackColor = false;
            btnOduncAl.Click += btnOduncAl_Click;
            // 
            // btnIadeEt
            // 
            btnIadeEt.AutoEllipsis = true;
            btnIadeEt.BackColor = Color.Maroon;
            btnIadeEt.FlatAppearance.BorderSize = 0;
            btnIadeEt.FlatStyle = FlatStyle.Flat;
            btnIadeEt.Font = new Font("Georgia", 15F);
            btnIadeEt.ForeColor = SystemColors.ButtonHighlight;
            btnIadeEt.Location = new Point(1152, 408);
            btnIadeEt.Name = "btnIadeEt";
            btnIadeEt.Size = new Size(220, 55);
            btnIadeEt.TabIndex = 8;
            btnIadeEt.Text = "İade Et";
            btnIadeEt.UseVisualStyleBackColor = false;
            btnIadeEt.Click += btnIadeEt_Click;
            // 
            // pnlOduncIade
            // 
            pnlOduncIade.BackColor = Color.WhiteSmoke;
            pnlOduncIade.Controls.Add(btnIadeEt);
            pnlOduncIade.Controls.Add(btnOduncAl);
            pnlOduncIade.Controls.Add(cmbOgrenciSecin);
            pnlOduncIade.Controls.Add(label10);
            pnlOduncIade.Controls.Add(cmbKitapSecin);
            pnlOduncIade.Controls.Add(label6);
            pnlOduncIade.Location = new Point(277, 70);
            pnlOduncIade.Name = "pnlOduncIade";
            pnlOduncIade.Size = new Size(1709, 896);
            pnlOduncIade.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(274, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1709, 78);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 30F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(22, 12);
            label1.Name = "label1";
            label1.Size = new Size(550, 58);
            label1.TabIndex = 0;
            label1.Text = "Kütüphane Uygulaması";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btnLoglar);
            panel2.Controls.Add(btnCikis);
            panel2.Controls.Add(btnOduncIade);
            panel2.Controls.Add(btnOgrenciİslemleri);
            panel2.Controls.Add(btnKitapİslemleri);
            panel2.Location = new Point(0, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 975);
            panel2.TabIndex = 13;
            // 
            // btnLoglar
            // 
            btnLoglar.AutoEllipsis = true;
            btnLoglar.BackColor = SystemColors.GrayText;
            btnLoglar.FlatAppearance.BorderSize = 0;
            btnLoglar.FlatStyle = FlatStyle.Flat;
            btnLoglar.Font = new Font("Georgia", 15F);
            btnLoglar.ForeColor = SystemColors.ButtonHighlight;
            btnLoglar.Location = new Point(25, 601);
            btnLoglar.Name = "btnLoglar";
            btnLoglar.Size = new Size(220, 55);
            btnLoglar.TabIndex = 12;
            btnLoglar.Text = "Log  - İstatistik";
            btnLoglar.UseVisualStyleBackColor = false;
            btnLoglar.Click += btnLoglar_Click;
            // 
            // btnCikis
            // 
            btnCikis.AutoEllipsis = true;
            btnCikis.BackColor = SystemColors.GrayText;
            btnCikis.FlatAppearance.BorderSize = 0;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Font = new Font("Georgia", 15F);
            btnCikis.ForeColor = SystemColors.ButtonHighlight;
            btnCikis.Location = new Point(25, 777);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(220, 55);
            btnCikis.TabIndex = 11;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnOduncIade
            // 
            btnOduncIade.AutoEllipsis = true;
            btnOduncIade.BackColor = SystemColors.GrayText;
            btnOduncIade.FlatAppearance.BorderSize = 0;
            btnOduncIade.FlatStyle = FlatStyle.Flat;
            btnOduncIade.Font = new Font("Georgia", 15F);
            btnOduncIade.ForeColor = SystemColors.ButtonHighlight;
            btnOduncIade.Location = new Point(25, 425);
            btnOduncIade.Name = "btnOduncIade";
            btnOduncIade.Size = new Size(220, 55);
            btnOduncIade.TabIndex = 10;
            btnOduncIade.Text = "Ödünç - İade";
            btnOduncIade.UseVisualStyleBackColor = false;
            btnOduncIade.Click += btnOduncIade_Click;
            // 
            // btnOgrenciİslemleri
            // 
            btnOgrenciİslemleri.AutoEllipsis = true;
            btnOgrenciİslemleri.BackColor = SystemColors.GrayText;
            btnOgrenciİslemleri.FlatAppearance.BorderSize = 0;
            btnOgrenciİslemleri.FlatStyle = FlatStyle.Flat;
            btnOgrenciİslemleri.Font = new Font("Georgia", 15F);
            btnOgrenciİslemleri.ForeColor = SystemColors.ButtonHighlight;
            btnOgrenciİslemleri.Location = new Point(25, 249);
            btnOgrenciİslemleri.Name = "btnOgrenciİslemleri";
            btnOgrenciİslemleri.Size = new Size(220, 55);
            btnOgrenciİslemleri.TabIndex = 9;
            btnOgrenciİslemleri.Text = "Öğrenci İşlemleri";
            btnOgrenciİslemleri.UseVisualStyleBackColor = false;
            btnOgrenciİslemleri.Click += btnOgrenciIslemleri_Click;
            // 
            // btnKitapİslemleri
            // 
            btnKitapİslemleri.AutoEllipsis = true;
            btnKitapİslemleri.BackColor = SystemColors.GrayText;
            btnKitapİslemleri.FlatAppearance.BorderSize = 0;
            btnKitapİslemleri.FlatStyle = FlatStyle.Flat;
            btnKitapİslemleri.Font = new Font("Georgia", 15F);
            btnKitapİslemleri.ForeColor = SystemColors.ButtonHighlight;
            btnKitapİslemleri.Location = new Point(25, 73);
            btnKitapİslemleri.Name = "btnKitapİslemleri";
            btnKitapİslemleri.Size = new Size(220, 55);
            btnKitapİslemleri.TabIndex = 8;
            btnKitapİslemleri.Text = "Kitap İşlemleri";
            btnKitapİslemleri.UseVisualStyleBackColor = false;
            btnKitapİslemleri.Click += btnKitapIslemleri_Click;
            // 
            // pnlOgrenciIslemleri
            // 
            pnlOgrenciIslemleri.BackColor = Color.WhiteSmoke;
            pnlOgrenciIslemleri.Controls.Add(txtOgrAd);
            pnlOgrenciIslemleri.Controls.Add(listBoxOgrnci);
            pnlOgrenciIslemleri.Controls.Add(label9);
            pnlOgrenciIslemleri.Controls.Add(label8);
            pnlOgrenciIslemleri.Controls.Add(label7);
            pnlOgrenciIslemleri.Controls.Add(btnOgrenciSil);
            pnlOgrenciIslemleri.Controls.Add(txtOgrNo);
            pnlOgrenciIslemleri.Controls.Add(btnOgrenciEkle);
            pnlOgrenciIslemleri.Controls.Add(txtOgrSoyisim);
            pnlOgrenciIslemleri.Location = new Point(163, 65);
            pnlOgrenciIslemleri.Name = "pnlOgrenciIslemleri";
            pnlOgrenciIslemleri.Size = new Size(1696, 896);
            pnlOgrenciIslemleri.TabIndex = 14;
            // 
            // txtOgrAd
            // 
            txtOgrAd.Location = new Point(471, 56);
            txtOgrAd.Name = "txtOgrAd";
            txtOgrAd.Size = new Size(217, 25);
            txtOgrAd.TabIndex = 13;
            // 
            // listBoxOgrnci
            // 
            listBoxOgrnci.FormattingEnabled = true;
            listBoxOgrnci.ItemHeight = 18;
            listBoxOgrnci.Location = new Point(25, 458);
            listBoxOgrnci.Name = "listBoxOgrnci";
            listBoxOgrnci.Size = new Size(1647, 364);
            listBoxOgrnci.TabIndex = 21;
            // 
            // label9
            // 
            label9.Font = new Font("Georgia", 15F);
            label9.Location = new Point(55, 151);
            label9.Name = "label9";
            label9.Size = new Size(207, 46);
            label9.TabIndex = 20;
            label9.Text = "Soyisim:";
            // 
            // label8
            // 
            label8.Font = new Font("Georgia", 15F);
            label8.Location = new Point(55, 246);
            label8.Name = "label8";
            label8.Size = new Size(207, 46);
            label8.TabIndex = 19;
            label8.Text = "Okul Numarası :";
            // 
            // label7
            // 
            label7.Font = new Font("Georgia", 15F);
            label7.Location = new Point(55, 56);
            label7.Name = "label7";
            label7.Size = new Size(207, 46);
            label7.TabIndex = 18;
            label7.Text = "İsim:";
            // 
            // btnOgrenciSil
            // 
            btnOgrenciSil.AutoEllipsis = true;
            btnOgrenciSil.BackColor = SystemColors.GrayText;
            btnOgrenciSil.FlatAppearance.BorderSize = 0;
            btnOgrenciSil.FlatStyle = FlatStyle.Flat;
            btnOgrenciSil.Font = new Font("Georgia", 15F);
            btnOgrenciSil.ForeColor = SystemColors.ButtonHighlight;
            btnOgrenciSil.Location = new Point(1272, 339);
            btnOgrenciSil.Name = "btnOgrenciSil";
            btnOgrenciSil.Size = new Size(220, 55);
            btnOgrenciSil.TabIndex = 16;
            btnOgrenciSil.Text = "Öğrenci Sil";
            btnOgrenciSil.UseVisualStyleBackColor = false;
            btnOgrenciSil.Click += btnOgrenciSil_Click;
            // 
            // txtOgrNo
            // 
            txtOgrNo.Location = new Point(471, 252);
            txtOgrNo.Name = "txtOgrNo";
            txtOgrNo.Size = new Size(217, 25);
            txtOgrNo.TabIndex = 15;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.AutoEllipsis = true;
            btnOgrenciEkle.BackColor = SystemColors.GrayText;
            btnOgrenciEkle.FlatAppearance.BorderSize = 0;
            btnOgrenciEkle.FlatStyle = FlatStyle.Flat;
            btnOgrenciEkle.Font = new Font("Georgia", 15F);
            btnOgrenciEkle.ForeColor = SystemColors.ButtonHighlight;
            btnOgrenciEkle.Location = new Point(960, 339);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(220, 55);
            btnOgrenciEkle.TabIndex = 17;
            btnOgrenciEkle.Text = "Öğrenci Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = false;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // txtOgrSoyisim
            // 
            txtOgrSoyisim.Location = new Point(471, 154);
            txtOgrSoyisim.Name = "txtOgrSoyisim";
            txtOgrSoyisim.Size = new Size(217, 25);
            txtOgrSoyisim.TabIndex = 14;
            // 
            // pnlLoglar
            // 
            pnlLoglar.Controls.Add(pnlKitapIslemleri);
            pnlLoglar.Controls.Add(btnTabloYenile);
            pnlLoglar.Controls.Add(lstEnCokOkunanlar);
            pnlLoglar.Controls.Add(listLogGecmisi);
            pnlLoglar.Controls.Add(label12);
            pnlLoglar.Controls.Add(label11);
            pnlLoglar.Location = new Point(152, 65);
            pnlLoglar.Name = "pnlLoglar";
            pnlLoglar.Size = new Size(1718, 896);
            pnlLoglar.TabIndex = 15;
            // 
            // btnTabloYenile
            // 
            btnTabloYenile.AutoEllipsis = true;
            btnTabloYenile.BackColor = SystemColors.GrayText;
            btnTabloYenile.FlatAppearance.BorderSize = 0;
            btnTabloYenile.FlatStyle = FlatStyle.Flat;
            btnTabloYenile.Font = new Font("Georgia", 15F);
            btnTabloYenile.ForeColor = SystemColors.ButtonHighlight;
            btnTabloYenile.Location = new Point(1378, 770);
            btnTabloYenile.Name = "btnTabloYenile";
            btnTabloYenile.Size = new Size(220, 55);
            btnTabloYenile.TabIndex = 7;
            btnTabloYenile.Text = "Tablo Yenile";
            btnTabloYenile.UseVisualStyleBackColor = false;
            btnTabloYenile.Click += btnTabloYenile_Click;
            // 
            // lstEnCokOkunanlar
            // 
            lstEnCokOkunanlar.FormattingEnabled = true;
            lstEnCokOkunanlar.ItemHeight = 18;
            lstEnCokOkunanlar.Location = new Point(896, 90);
            lstEnCokOkunanlar.Name = "lstEnCokOkunanlar";
            lstEnCokOkunanlar.Size = new Size(702, 598);
            lstEnCokOkunanlar.TabIndex = 3;
            // 
            // listLogGecmisi
            // 
            listLogGecmisi.FormattingEnabled = true;
            listLogGecmisi.ItemHeight = 18;
            listLogGecmisi.Location = new Point(19, 90);
            listLogGecmisi.Name = "listLogGecmisi";
            listLogGecmisi.Size = new Size(702, 598);
            listLogGecmisi.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Georgia", 25F);
            label12.Location = new Point(896, 20);
            label12.Name = "label12";
            label12.Size = new Size(489, 48);
            label12.TabIndex = 1;
            label12.Text = "En Çok Okunan Kitaplar:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Georgia", 25F);
            label11.Location = new Point(19, 20);
            label11.Name = "label11";
            label11.Size = new Size(260, 48);
            label11.TabIndex = 0;
            label11.Text = "Log Geçmişi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2023, 1026);
            Controls.Add(pnlLoglar);
            Controls.Add(pnlOgrenciIslemleri);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlOduncIade);
            Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            pnlKitapIslemleri.ResumeLayout(false);
            pnlKitapIslemleri.PerformLayout();
            pnlOduncIade.ResumeLayout(false);
            pnlOduncIade.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnlOgrenciIslemleri.ResumeLayout(false);
            pnlOgrenciIslemleri.PerformLayout();
            pnlLoglar.ResumeLayout(false);
            pnlLoglar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlKitapIslemleri;
        private ComboBox cmbKategori;
        private Button btnKitapSil;
        private ListBox lstKitaplar;
        private Button btnKitapEkle;
        private TextBox txtISBN;
        private TextBox txtYazar;
        private TextBox txtKitapAd;
        private Label label6;
        private ComboBox cmbKitapSecin;
        private Label label10;
        private ComboBox cmbOgrenciSecin;
        private Button btnOduncAl;
        private Button btnIadeEt;
        private Panel pnlOduncIade;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnLoglar;
        private Button btnCikis;
        private Button btnOduncIade;
        private Button btnOgrenciİslemleri;
        private Button btnKitapİslemleri;
        private Panel pnlOgrenciIslemleri;
        private TextBox txtOgrAd;
        private ListBox listBoxOgrnci;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnOgrenciSil;
        private TextBox txtOgrNo;
        private Button btnOgrenciEkle;
        private TextBox txtOgrSoyisim;
        private Panel pnlLoglar;
        private Button btnTabloYenile;
        private ListBox lstEnCokOkunanlar;
        private ListBox listLogGecmisi;
        private Label label12;
        private Label label11;
        private Button btnAra;
        private TextBox txtArama;
    }
}
