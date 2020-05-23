using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace canEgrisi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboOgretim.SelectedIndex = 0;
			/*Hizli Kayit*/
			//string[] row = { "1", "Yasin", "Yiğit", "Erkek", "Birinci Öğretim", "70", "80" };
			//Ogrenci ogrenci = new Ogrenci("1", "Yasin", "Yiğit", "Erkek", "Birinci Öğretim", 70, 80);
			//ogrenciler.Add(ogrenci);
			//ListViewItem newItem = new ListViewItem(row);
			//listView1.Items.Add(newItem);
			////listView1.Items.Add(newItem);
		}
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			string cinsiyet = "";
			if (radioErkek.Checked)
			{
				cinsiyet = "Erkek";
			}
			else if (radioKiz.Checked)
			{
				cinsiyet = "Kız";
			}
			double sinifOrtalama = 0.0, ogrencilerinHamNotKareToplami = 0.0;
			int ogrenciSayisi = 0;
			//Yeni bir ogrenci olusturalim.
			Ogrenci ogrenci = new Ogrenci(txtNumara.Text, txtIsim.Text, txtSoyisim.Text, cinsiyet, comboOgretim.SelectedItem.ToString(), Convert.ToInt32(txtVize.Text), Convert.ToInt32(txtFinal.Text));
			//Ogrenciyi listeye ekleyelim.
			ogrenciler.Add(ogrenci);
			//Ogrenci sayisini bulalim.
			ogrenciSayisi = ogrenciler.Count();
			//Sinif ortalamasini bulmak icin her bir ogrencini ortalamasini toplayip ogrenci sayisina bolelim.
			foreach (var item in ogrenciler)
			{
				sinifOrtalama += item.getOrtalama();
				ogrencilerinHamNotKareToplami += Math.Pow(item.getOrtalama(), 2);
			}
			sinifOrtalama /= ogrenciSayisi;
			lblOrtalama.Text = "Ortalama: " + sinifOrtalama.ToString("F", CultureInfo.InvariantCulture);
			lblKayitSayisi.Text = "Kayit Sayisi: " + ogrenciSayisi.ToString();
			//Mevcut ogrenci icin T-Skoru hesaplayalim.


			listView1.Items.Clear();
			ListViewItem newItem;
			foreach (var item in ogrenciler) //her yeni ogrenci eklendiginde
			{
				item.tSkorHesapla(sinifOrtalama, ogrenciSayisi, ogrencilerinHamNotKareToplami); //her bir ogrencinin tskorunu yeniden hesaplayalim
				string harfNotu = "";
				harfNotu = item.harfNotuHesapla(sinifOrtalama, item.getTSkor()); //harf notunu da yeniden hesaplayalim
				string[] row = {item.getNumara(), item.getIsim(), item.getSoyisim(), item.getCinsiyet(), item.getOgretim(), item.getVize().ToString(), item.getFinal().ToString(), harfNotu, item.getTSkor().ToString(), item.getBasariDurumu() }; //yeni bir row olusturalim listviewa ekleyebilmek icin
				newItem = new ListViewItem(row); //listviewitem olarak tanimlayalim
				listView1.Items.Add(newItem); //ekleyelim.
			}


		}
		private List<Ogrenci> ogrenciler = new List<Ogrenci>(); //Tum ogrencileri elimizde tutalim.
		private void BtnAra_Click(object sender, EventArgs e)
		{
			listView1.Items.Clear(); //listview temizle
			ListViewItem newItem;
			if (txtNumaraAra.Text == "") //arama kutusu bossa
			{
				foreach (var item in ogrenciler) //her bir ogrenciyi yeniden ekle
				{
					string[] row = { item.getNumara(), item.getIsim(), item.getSoyisim(), item.getCinsiyet(), item.getOgretim(), item.getVize().ToString(), item.getFinal().ToString(), item.getHarfNotu(), item.getTSkor().ToString(), item.getBasariDurumu() };
					newItem = new ListViewItem(row);
					listView1.Items.Add(newItem);
				}
				return;
			}
			foreach (var item in ogrenciler)
			{
				if (item.getNumara() == txtNumaraAra.Text) //aranan numara ogrencilerden birisine aitse sadece o ogrenciyi ekle
				{
					string[] row = { item.getNumara(), item.getIsim(), item.getSoyisim(), item.getCinsiyet(), item.getOgretim(), item.getVize().ToString(), item.getFinal().ToString(), item.getHarfNotu(), item.getTSkor().ToString(), item.getBasariDurumu() };
					newItem = new ListViewItem(row);
					listView1.Items.Add(newItem);
					return;
				}
			}
		}

		private void BtnSil_Click(object sender, EventArgs e)
		{

			int index;
			var indeksler = listView1.SelectedIndices;
			if (listView1.SelectedItems.Count > 0) // item secildiyse
			{
				for (int i = listView1.SelectedItems.Count - 1; i >= 0; i--)
				{
					ListViewItem itm = listView1.SelectedItems[i]; //Itemi listviewitem tipine getir
					ogrenciler.RemoveAt(itm.Index); //Bu ogrenciyi sil
					listView1.Items[itm.Index].Remove(); //Itemi listeden sil
				}
			}
			hesapla();
		}
		private void hesapla() //Her bir silme ya da ekleme isleminden sonra notlar tekrar hesaplanmak zorunda.
		{
			double sinifOrtalama = 0.0, ogrencilerinHamNotKareToplami = 0.0;
			int ogrenciSayisi = 0;
			ogrenciSayisi = ogrenciler.Count();

			foreach (var item in ogrenciler) //Her bir ogrenci icin ortalama al
			{
				sinifOrtalama += item.getOrtalama();
				ogrencilerinHamNotKareToplami += Math.Pow(item.getOrtalama(), 2);
			}
			sinifOrtalama /= ogrenciSayisi;

			lblOrtalama.Text = "Ortalama: " + sinifOrtalama.ToString("F", CultureInfo.InvariantCulture);
			lblKayitSayisi.Text = "Kayit Sayisi: " + ogrenciSayisi.ToString();
			//Mevcut ogrenci icin T-Skoru hesaplayalim.
			foreach (Ogrenci ogr in ogrenciler) //Her bir ogrenci icin harf notu hesapla
			{
				ogr.harfNotuHesapla(sinifOrtalama, ogr.tSkorHesapla(sinifOrtalama, ogrenciSayisi, ogrencilerinHamNotKareToplami));
			}
			listView1.Items.Clear();
			ListViewItem newItem;
			//Eski notlari silmek ve yenilerini gosterebilmek icin
			foreach (var item in ogrenciler) //her bir ogrenciyi yeniden ekle
			{
				string[] row = { item.getNumara(), item.getIsim(), item.getSoyisim(), item.getCinsiyet(), item.getOgretim(), item.getVize().ToString(), item.getFinal().ToString(), item.getHarfNotu(), item.getTSkor().ToString(), item.getBasariDurumu()};
				newItem = new ListViewItem(row);
				listView1.Items.Add(newItem);
			}
		}
	}
	public class Ogrenci
	{
		private string numara, isim, soyisim, cinsiyet, ogretim, harfNotu;
		private int vize, final;
		private double ortalama, tSkor;
		private int HBAL = 50;

		public Ogrenci(string numara, string isim, string soyisim, string cinsiyet, string ogretim, int vize, int final)
		{
			this.numara = numara;
			this.isim = isim;
			this.soyisim = soyisim;
			this.cinsiyet = cinsiyet;
			this.ogretim = ogretim;
			this.vize = vize;
			this.final = final;
			this.ortalama = vize * 0.4 + final * 0.6; //ortalama hesapla
		}
		public string getNumara() //ogrencinin numarasini dondur... (get-set fonskiyonlari)
		{
			return this.numara;
		}
		public string getBasariDurumu()
		{
			string basariDurumu = "";
			switch (this.harfNotu)
			{
				case "AA":
				case "BA":
				case "BB":
				case "CB":
				case "CC":
					basariDurumu = "Başarılı";
					break;
				case "DC":
				case "DD":
					basariDurumu = "Şartlı Başarılı";
					break;
				case "FF":
					basariDurumu = "Başarısız";
					break;
			}
			return basariDurumu;
		}
		public string getIsim() //ogrencinin ismini dondur...
		{
			return this.isim;
		}
		public string getSoyisim()
		{
			return this.soyisim;
		}
		public string getCinsiyet()
		{
			return this.cinsiyet;
		}
		public string getOgretim()
		{
			return this.ogretim;
		}
		public int getVize()
		{
			return this.vize;
		}
		public int getFinal()
		{
			return this.final;
		}
		public double getTSkor()
		{
			return this.tSkor;
		}
		public double getOrtalama()
		{
			return this.ortalama;
		}
		public string getHarfNotu()
		{
			return this.harfNotu;
		}
		public double tSkorHesapla(double sinifOrtalama, int ogrenciSayisi, double ogrencilerinHamNotKareToplami)
		{
			if (this.ortalama < HBAL) //ogrenci ortalamasi HBAL'dan kucukse FF
			{
				this.tSkor = 0.0;
				return this.tSkor;
			}
			double ogrencilerinHamPuanToplami = sinifOrtalama * ogrenciSayisi; //notlar toplami
			double islem1 = Math.Pow(ogrencilerinHamPuanToplami, 2); 
			double islem2 = Math.Sqrt((ogrenciSayisi * ogrencilerinHamNotKareToplami) - islem1); 

			this.tSkor = (((this.ortalama - sinifOrtalama) / ((1.0 / ogrenciSayisi) * islem2)) * 10) + 50; // skor hesaplama
			return this.tSkor;
		}
		//tablo 2 sol kisim
		private double[,] sinifOrtalamAraliklari = { { 100.0, 80.0 },
													 { 79.99, 70.0 },
													 { 69.99, 62.50 },
													 { 62.49, 57.50 },
													 { 57.49, 52.50 },
													 { 52.49,47.50 },
													 { 47.49,42.50 },
													 { 42.49,0.0 } };

		//tablo 1 ve tablo 2 sag kisim
		private double[,,] ogrenciTSkorlari = { {
													{ 100.0,88.0 },
													{ 87.99,81.0 },
													{ 80.99,74.0 },
													{ 73.99,67.0 },
													{ 66.99,60.0 },
													{ 59.99,53.0 },
													{ 52.99,45.0 },
													{ 44.99,0.0 }
												},
												{
													{ 100.0,59.0 },
													{ 58.99,54.0 },
													{ 53.99,49.0 },
													{ 48.99,44.0 },
													{ 43.99,39.0 },
													{ 38.99,34.0 },
													{ 33.99,29.0 },
													{ 28.99,0.0 }
												},
												{
													{ 100.0, 61.00 },
													{ 60.99,56.0 },
													{ 55.99,51.0 },
													{ 50.99,46.0 },
													{ 45.99,41.0 },
													{ 40.99,36.0 },
													{ 35.99,31.0 },
													{ 30.99,0.0 }
												},
												{
													{ 100.00,63.0 },
													{ 62.99,58.0 },
													{ 57.99,53.0 },
													{ 52.99,48.0 },
													{ 47.99,43.0 },
													{ 42.99,38.0 },
													{ 37.99,33.0 },
													{ 32.99,0.0 }
												},
												{
													{ 100.0, 65.00 },
													{ 64.99,60.0 },
													{ 59.99,55.0 },
													{ 54.99,50.0 },
													{ 49.99,45.0 },
													{ 44.99,40.0 },
													{ 39.99,35.0 },
													{ 34.99,0.0 }
												},
												{
													{ 100.00,67.0 },
													{ 66.99,62.0 },
													{ 61.99,57.0 },
													{ 56.99,52.0 },
													{ 51.99,47.0 },
													{ 46.99,42.0 },
													{ 41.99,37.0 },
													{ 36.99,0.0 }
												},
												{
													{ 100.0, 69.00 },
													{ 68.99,64.0 },
													{ 63.99,59.0 },
													{ 58.99,54.0 },
													{ 53.99,49.0 },
													{ 48.99,44.0 },
													{ 43.99,40.0 },
													{ 39.99,0.0 }
												},
												{
													{ 100.00,71.0 },
													{ 70.99,66.0 },
													{ 65.99,61.0 },
													{ 60.99,56.0 },
													{ 55.99,51.0 },
													{ 50.99,47.0 },
													{ 46.99,43.0 },
													{ 42.99,0.0 }
												}

												};

		private string[] harfNotlari = { "AA", "BA", "BB", "CB", "CC", "DC", "DD", "FF" };
		public string harfNotuHesapla(double sinifOrtalama, double tSkor)
		{
			for (int m = 0; m < 8; m++) //toplamda 8 farklı sinif ortalama agirligi var.
			{
					if (sinifOrtalama <= sinifOrtalamAraliklari[m, 0] && sinifOrtalamAraliklari[m, 1] <= sinifOrtalama) //ogrenci hangi aralikta ise
					{
							for (int j = 0; j < 7; j++) //o araliktaki her bir sutunu gez, (harf notu)
							{

								if (m > 0) //eger sinif ortalamasi 80-100 arasinda degil ise ogrencinin tskoru ile not verilecek
						{
									if (ogrenciTSkorlari[m, j, 0] >= tSkor && tSkor >= ogrenciTSkorlari[m, j, 1]) //ogrencinin tskor araligini bulalim
									{
										this.harfNotu = harfNotlari[j]; //Bu araliga gore notlandiralim.
										return this.harfNotu;
									}
								}
								else //eger sinif ortalamasi 80-100 arasinda ise ogrencinin tskoru degil ortalamasi ile not verilecek
								{
									if (ogrenciTSkorlari[m, j, 0] >= this.ortalama && this.ortalama >= ogrenciTSkorlari[m, j, 1])
									{
										this.harfNotu = harfNotlari[j];
										return this.harfNotu;
									}
								}
							}
					}
			}
			this.harfNotu = "FF"; //Hicbir yere uymuyor ise
			return this.harfNotu;
		}
	}
}
