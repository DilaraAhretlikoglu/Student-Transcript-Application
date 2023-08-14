namespace VTYS_Odev2
{
    partial class KayıtEklemeEkranı
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayıtEklemeEkranı));
            this.lbl_kod = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_kredi = new System.Windows.Forms.Label();
            this.lblAkts = new System.Windows.Forms.Label();
            this.lblOgretimUyesi = new System.Windows.Forms.Label();
            this.lblDonem = new System.Windows.Forms.Label();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.dersKoduTxt = new System.Windows.Forms.TextBox();
            this.dersAdiTxt = new System.Windows.Forms.TextBox();
            this.dersKrediTxt = new System.Windows.Forms.TextBox();
            this.dersAktsTxt = new System.Windows.Forms.TextBox();
            this.ogretimUyesiTxt = new System.Windows.Forms.TextBox();
            this.dersDonemTxt = new System.Windows.Forms.TextBox();
            this.dersHarfNotuTxt = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DersBilgiList2 = new System.Windows.Forms.GroupBox();
            this.KayıtTablo = new System.Windows.Forms.DataGridView();
            this.btnKayıtİptal = new System.Windows.Forms.Button();
            this.kayıtGrpBx = new System.Windows.Forms.GroupBox();
            this.DersBilgiList2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtTablo)).BeginInit();
            this.kayıtGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_kod
            // 
            this.lbl_kod.AutoSize = true;
            this.lbl_kod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kod.Location = new System.Drawing.Point(6, 39);
            this.lbl_kod.Name = "lbl_kod";
            this.lbl_kod.Size = new System.Drawing.Size(94, 18);
            this.lbl_kod.TabIndex = 1;
            this.lbl_kod.Text = "Dersin Kodu:";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(6, 76);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(79, 18);
            this.lbl_ad.TabIndex = 2;
            this.lbl_ad.Text = "Dersin Adı:";
            // 
            // lbl_kredi
            // 
            this.lbl_kredi.AutoSize = true;
            this.lbl_kredi.Location = new System.Drawing.Point(6, 111);
            this.lbl_kredi.Name = "lbl_kredi";
            this.lbl_kredi.Size = new System.Drawing.Size(102, 18);
            this.lbl_kredi.TabIndex = 3;
            this.lbl_kredi.Text = "Dersin kredisi:";
            // 
            // lblAkts
            // 
            this.lblAkts.AutoSize = true;
            this.lblAkts.Location = new System.Drawing.Point(6, 146);
            this.lblAkts.Name = "lblAkts";
            this.lblAkts.Size = new System.Drawing.Size(50, 18);
            this.lblAkts.TabIndex = 4;
            this.lblAkts.Text = "AKTS:";
            // 
            // lblOgretimUyesi
            // 
            this.lblOgretimUyesi.AutoSize = true;
            this.lblOgretimUyesi.Location = new System.Drawing.Point(394, 39);
            this.lblOgretimUyesi.Name = "lblOgretimUyesi";
            this.lblOgretimUyesi.Size = new System.Drawing.Size(106, 18);
            this.lblOgretimUyesi.TabIndex = 5;
            this.lblOgretimUyesi.Text = "Öğretim Üyesi:";
            // 
            // lblDonem
            // 
            this.lblDonem.AutoSize = true;
            this.lblDonem.Location = new System.Drawing.Point(394, 76);
            this.lblDonem.Name = "lblDonem";
            this.lblDonem.Size = new System.Drawing.Size(61, 18);
            this.lblDonem.TabIndex = 6;
            this.lblDonem.Text = "Dönem:";
            // 
            // lblHarfNotu
            // 
            this.lblHarfNotu.AutoSize = true;
            this.lblHarfNotu.Location = new System.Drawing.Point(394, 111);
            this.lblHarfNotu.Name = "lblHarfNotu";
            this.lblHarfNotu.Size = new System.Drawing.Size(76, 18);
            this.lblHarfNotu.TabIndex = 7;
            this.lblHarfNotu.Text = "Harf Notu:";
            // 
            // dersKoduTxt
            // 
            this.dersKoduTxt.Location = new System.Drawing.Point(152, 33);
            this.dersKoduTxt.Name = "dersKoduTxt";
            this.dersKoduTxt.Size = new System.Drawing.Size(198, 24);
            this.dersKoduTxt.TabIndex = 8;
            // 
            // dersAdiTxt
            // 
            this.dersAdiTxt.Location = new System.Drawing.Point(152, 73);
            this.dersAdiTxt.Name = "dersAdiTxt";
            this.dersAdiTxt.Size = new System.Drawing.Size(198, 24);
            this.dersAdiTxt.TabIndex = 9;
            // 
            // dersKrediTxt
            // 
            this.dersKrediTxt.Location = new System.Drawing.Point(152, 111);
            this.dersKrediTxt.Name = "dersKrediTxt";
            this.dersKrediTxt.Size = new System.Drawing.Size(198, 24);
            this.dersKrediTxt.TabIndex = 10;
            // 
            // dersAktsTxt
            // 
            this.dersAktsTxt.Location = new System.Drawing.Point(152, 146);
            this.dersAktsTxt.Name = "dersAktsTxt";
            this.dersAktsTxt.Size = new System.Drawing.Size(198, 24);
            this.dersAktsTxt.TabIndex = 11;
            // 
            // ogretimUyesiTxt
            // 
            this.ogretimUyesiTxt.Location = new System.Drawing.Point(523, 36);
            this.ogretimUyesiTxt.Name = "ogretimUyesiTxt";
            this.ogretimUyesiTxt.Size = new System.Drawing.Size(198, 24);
            this.ogretimUyesiTxt.TabIndex = 12;
            // 
            // dersDonemTxt
            // 
            this.dersDonemTxt.Location = new System.Drawing.Point(523, 73);
            this.dersDonemTxt.Name = "dersDonemTxt";
            this.dersDonemTxt.Size = new System.Drawing.Size(198, 24);
            this.dersDonemTxt.TabIndex = 13;
            this.dersDonemTxt.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dersHarfNotuTxt
            // 
            this.dersHarfNotuTxt.Location = new System.Drawing.Point(523, 111);
            this.dersHarfNotuTxt.Name = "dersHarfNotuTxt";
            this.dersHarfNotuTxt.Size = new System.Drawing.Size(198, 24);
            this.dersHarfNotuTxt.TabIndex = 14;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.ImageKey = "save.png";
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(494, 156);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(145, 36);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "save.png");
            // 
            // DersBilgiList2
            // 
            this.DersBilgiList2.Controls.Add(this.KayıtTablo);
            this.DersBilgiList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersBilgiList2.Location = new System.Drawing.Point(22, 234);
            this.DersBilgiList2.Name = "DersBilgiList2";
            this.DersBilgiList2.Size = new System.Drawing.Size(933, 204);
            this.DersBilgiList2.TabIndex = 17;
            this.DersBilgiList2.TabStop = false;
            this.DersBilgiList2.Text = "Ders Bilgileri";
            // 
            // KayıtTablo
            // 
            this.KayıtTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KayıtTablo.Location = new System.Drawing.Point(6, 21);
            this.KayıtTablo.Name = "KayıtTablo";
            this.KayıtTablo.RowHeadersWidth = 51;
            this.KayıtTablo.RowTemplate.Height = 24;
            this.KayıtTablo.Size = new System.Drawing.Size(921, 188);
            this.KayıtTablo.TabIndex = 0;
            this.KayıtTablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KayıtTablo_CellContentClick);
            // 
            // btnKayıtİptal
            // 
            this.btnKayıtİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtİptal.ImageKey = "cancel.png";
            this.btnKayıtİptal.ImageList = this.ımageList1;
            this.btnKayıtİptal.Location = new System.Drawing.Point(645, 156);
            this.btnKayıtİptal.Name = "btnKayıtİptal";
            this.btnKayıtİptal.Size = new System.Drawing.Size(131, 36);
            this.btnKayıtİptal.TabIndex = 18;
            this.btnKayıtİptal.Text = "İptal";
            this.btnKayıtİptal.UseVisualStyleBackColor = true;
            this.btnKayıtİptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // kayıtGrpBx
            // 
            this.kayıtGrpBx.Controls.Add(this.lbl_kod);
            this.kayıtGrpBx.Controls.Add(this.btnKayıtİptal);
            this.kayıtGrpBx.Controls.Add(this.lbl_ad);
            this.kayıtGrpBx.Controls.Add(this.lbl_kredi);
            this.kayıtGrpBx.Controls.Add(this.btnKaydet);
            this.kayıtGrpBx.Controls.Add(this.lblAkts);
            this.kayıtGrpBx.Controls.Add(this.dersHarfNotuTxt);
            this.kayıtGrpBx.Controls.Add(this.lblOgretimUyesi);
            this.kayıtGrpBx.Controls.Add(this.dersDonemTxt);
            this.kayıtGrpBx.Controls.Add(this.lblDonem);
            this.kayıtGrpBx.Controls.Add(this.ogretimUyesiTxt);
            this.kayıtGrpBx.Controls.Add(this.lblHarfNotu);
            this.kayıtGrpBx.Controls.Add(this.dersAktsTxt);
            this.kayıtGrpBx.Controls.Add(this.dersKoduTxt);
            this.kayıtGrpBx.Controls.Add(this.dersKrediTxt);
            this.kayıtGrpBx.Controls.Add(this.dersAdiTxt);
            this.kayıtGrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtGrpBx.Location = new System.Drawing.Point(22, 12);
            this.kayıtGrpBx.Name = "kayıtGrpBx";
            this.kayıtGrpBx.Size = new System.Drawing.Size(933, 216);
            this.kayıtGrpBx.TabIndex = 18;
            this.kayıtGrpBx.TabStop = false;
            this.kayıtGrpBx.Text = "Kayıt";
            // 
            // KayıtEklemeEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.kayıtGrpBx);
            this.Controls.Add(this.DersBilgiList2);
            this.Name = "KayıtEklemeEkranı";
            this.Text = "Kayıt Ekleme Ekranı";
            this.Load += new System.EventHandler(this.KayıtEklemeEkranı_Load);
            this.DersBilgiList2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KayıtTablo)).EndInit();
            this.kayıtGrpBx.ResumeLayout(false);
            this.kayıtGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_kod;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_kredi;
        private System.Windows.Forms.Label lblAkts;
        private System.Windows.Forms.Label lblOgretimUyesi;
        private System.Windows.Forms.Label lblDonem;
        private System.Windows.Forms.Label lblHarfNotu;
        private System.Windows.Forms.TextBox dersKoduTxt;
        private System.Windows.Forms.TextBox dersAdiTxt;
        private System.Windows.Forms.TextBox dersKrediTxt;
        private System.Windows.Forms.TextBox dersAktsTxt;
        private System.Windows.Forms.TextBox ogretimUyesiTxt;
        private System.Windows.Forms.TextBox dersDonemTxt;
        private System.Windows.Forms.TextBox dersHarfNotuTxt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox DersBilgiList2;
        private System.Windows.Forms.DataGridView KayıtTablo;
        private System.Windows.Forms.Button btnKayıtİptal;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox kayıtGrpBx;
    }
}