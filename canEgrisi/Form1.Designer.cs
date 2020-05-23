namespace canEgrisi
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioErkek = new System.Windows.Forms.RadioButton();
            this.radioKiz = new System.Windows.Forms.RadioButton();
            this.comboOgretim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumaraAra = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmNumara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSoyisim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCinsiyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOgretim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmVize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHarfNotu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBasariDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTSkor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioErkek);
            this.groupBox1.Controls.Add(this.radioKiz);
            this.groupBox1.Controls.Add(this.comboOgretim);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumara);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(318, 129);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(165, 31);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Öğretim";
            // 
            // radioErkek
            // 
            this.radioErkek.AutoSize = true;
            this.radioErkek.Checked = true;
            this.radioErkek.Location = new System.Drawing.Point(176, 124);
            this.radioErkek.Name = "radioErkek";
            this.radioErkek.Size = new System.Drawing.Size(65, 21);
            this.radioErkek.TabIndex = 13;
            this.radioErkek.TabStop = true;
            this.radioErkek.Text = "Erkek";
            this.radioErkek.UseVisualStyleBackColor = true;
            // 
            // radioKiz
            // 
            this.radioKiz.AutoSize = true;
            this.radioKiz.Location = new System.Drawing.Point(76, 124);
            this.radioKiz.Name = "radioKiz";
            this.radioKiz.Size = new System.Drawing.Size(48, 21);
            this.radioKiz.TabIndex = 12;
            this.radioKiz.Text = "Kız";
            this.radioKiz.UseVisualStyleBackColor = true;
            // 
            // comboOgretim
            // 
            this.comboOgretim.FormattingEnabled = true;
            this.comboOgretim.Items.AddRange(new object[] {
            "Birinci Öğretim",
            "İkinci Öğretim"});
            this.comboOgretim.Location = new System.Drawing.Point(318, 99);
            this.comboOgretim.Name = "comboOgretim";
            this.comboOgretim.Size = new System.Drawing.Size(165, 24);
            this.comboOgretim.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Final";
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(318, 71);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(165, 22);
            this.txtFinal.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vize";
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(318, 40);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(165, 22);
            this.txtVize.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyisim";
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(76, 96);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(165, 22);
            this.txtSoyisim.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "İsim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(76, 68);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(165, 22);
            this.txtIsim.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numara";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(76, 40);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(165, 22);
            this.txtNumara.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAra);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNumaraAra);
            this.groupBox2.Location = new System.Drawing.Point(502, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bul";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(69, 49);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(165, 31);
            this.btnAra.TabIndex = 15;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Numara";
            // 
            // txtNumaraAra
            // 
            this.txtNumaraAra.Location = new System.Drawing.Point(69, 21);
            this.txtNumaraAra.Name = "txtNumaraAra";
            this.txtNumaraAra.Size = new System.Drawing.Size(165, 22);
            this.txtNumaraAra.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblKayitSayisi);
            this.groupBox3.Controls.Add(this.lblOrtalama);
            this.groupBox3.Location = new System.Drawing.Point(502, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 77);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bilgiler";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Location = new System.Drawing.Point(33, 40);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(84, 17);
            this.lblKayitSayisi.TabIndex = 16;
            this.lblKayitSayisi.Text = "Kayıt Sayısı:";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(6, 18);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(111, 17);
            this.lblOrtalama.TabIndex = 15;
            this.lblOrtalama.Text = "Sınıf Ortalaması:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNumara,
            this.clmIsim,
            this.clmSoyisim,
            this.clmCinsiyet,
            this.clmOgretim,
            this.clmVize,
            this.clmFinal,
            this.clmHarfNotu,
            this.clmTSkor,
            this.clmBasariDurumu});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 179);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(745, 263);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmNumara
            // 
            this.clmNumara.Text = "Numara";
            // 
            // clmIsim
            // 
            this.clmIsim.Text = "İsim";
            // 
            // clmSoyisim
            // 
            this.clmSoyisim.Text = "Soyisim";
            // 
            // clmCinsiyet
            // 
            this.clmCinsiyet.DisplayIndex = 5;
            this.clmCinsiyet.Text = "Cinsiyet";
            // 
            // clmOgretim
            // 
            this.clmOgretim.DisplayIndex = 6;
            this.clmOgretim.Text = "Öğretim";
            // 
            // clmVize
            // 
            this.clmVize.DisplayIndex = 3;
            this.clmVize.Text = "Vize";
            // 
            // clmFinal
            // 
            this.clmFinal.DisplayIndex = 4;
            this.clmFinal.Text = "Final";
            // 
            // clmHarfNotu
            // 
            this.clmHarfNotu.Text = "Harf Notu";
            // 
            // clmBasariDurumu
            // 
            this.clmBasariDurumu.Text = "Başarı Durumu";
            // 
            // clmTSkor
            // 
            this.clmTSkor.Text = "T Skoru";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(754, 179);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(23, 263);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 449);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Çan Eğrisi Harf Notu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton radioErkek;
		private System.Windows.Forms.RadioButton radioKiz;
		private System.Windows.Forms.ComboBox comboOgretim;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtFinal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtVize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoyisim;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIsim;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumara;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNumaraAra;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lblKayitSayisi;
		private System.Windows.Forms.Label lblOrtalama;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader clmNumara;
		private System.Windows.Forms.ColumnHeader clmIsim;
		private System.Windows.Forms.ColumnHeader clmSoyisim;
		private System.Windows.Forms.ColumnHeader clmCinsiyet;
		private System.Windows.Forms.ColumnHeader clmOgretim;
		private System.Windows.Forms.ColumnHeader clmVize;
		private System.Windows.Forms.ColumnHeader clmFinal;
		private System.Windows.Forms.ColumnHeader clmHarfNotu;
		private System.Windows.Forms.ColumnHeader clmTSkor;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.ColumnHeader clmBasariDurumu;
	}
}

