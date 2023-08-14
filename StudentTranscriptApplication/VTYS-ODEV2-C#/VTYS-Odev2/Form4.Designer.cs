namespace VTYS_Odev2
{
    partial class Ders_Güncelleme_Ekranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ders_Güncelleme_Ekranı));
            this.lblGuncellenecekDersKodu = new System.Windows.Forms.Label();
            this.guncelle_txt = new System.Windows.Forms.TextBox();
            this.guncelleGrpBx = new System.Windows.Forms.GroupBox();
            this.guncelListe = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_kod = new System.Windows.Forms.Label();
            this.guncelleİptalBtn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_kredi = new System.Windows.Forms.Label();
            this.guncelleBtn = new System.Windows.Forms.Button();
            this.lblAkts = new System.Windows.Forms.Label();
            this.guncelDersHarfNotuTxt = new System.Windows.Forms.TextBox();
            this.lblOgretimUyesi = new System.Windows.Forms.Label();
            this.guncelDersDonemTxt = new System.Windows.Forms.TextBox();
            this.lblDonem = new System.Windows.Forms.Label();
            this.guncelOgretimUyesiTxt = new System.Windows.Forms.TextBox();
            this.lblHarfNotu = new System.Windows.Forms.Label();
            this.guncelDersAktsTxt = new System.Windows.Forms.TextBox();
            this.guncelKodTxt = new System.Windows.Forms.TextBox();
            this.guncelDersKrediTxt = new System.Windows.Forms.TextBox();
            this.guncelDersAdiTxt = new System.Windows.Forms.TextBox();
            this.guncelleGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guncelListe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGuncellenecekDersKodu
            // 
            this.lblGuncellenecekDersKodu.AutoSize = true;
            this.lblGuncellenecekDersKodu.Location = new System.Drawing.Point(12, 9);
            this.lblGuncellenecekDersKodu.Name = "lblGuncellenecekDersKodu";
            this.lblGuncellenecekDersKodu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGuncellenecekDersKodu.Size = new System.Drawing.Size(224, 16);
            this.lblGuncellenecekDersKodu.TabIndex = 0;
            this.lblGuncellenecekDersKodu.Text = "Güncellenecek dersin kodunu giriniz:";
            // 
            // guncelle_txt
            // 
            this.guncelle_txt.Location = new System.Drawing.Point(252, 9);
            this.guncelle_txt.Name = "guncelle_txt";
            this.guncelle_txt.Size = new System.Drawing.Size(221, 22);
            this.guncelle_txt.TabIndex = 1;
            this.guncelle_txt.TextChanged += new System.EventHandler(this.guncelle_txt_TextChanged);
            // 
            // guncelleGrpBx
            // 
            this.guncelleGrpBx.Controls.Add(this.guncelListe);
            this.guncelleGrpBx.Location = new System.Drawing.Point(18, 262);
            this.guncelleGrpBx.Name = "guncelleGrpBx";
            this.guncelleGrpBx.Size = new System.Drawing.Size(933, 217);
            this.guncelleGrpBx.TabIndex = 28;
            this.guncelleGrpBx.TabStop = false;
            this.guncelleGrpBx.Text = "Ders Bilgileri";
            // 
            // guncelListe
            // 
            this.guncelListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guncelListe.Location = new System.Drawing.Point(4, 21);
            this.guncelListe.Name = "guncelListe";
            this.guncelListe.RowHeadersWidth = 51;
            this.guncelListe.RowTemplate.Height = 24;
            this.guncelListe.Size = new System.Drawing.Size(929, 188);
            this.guncelListe.TabIndex = 0;
            this.guncelListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_kod);
            this.groupBox2.Controls.Add(this.guncelleİptalBtn);
            this.groupBox2.Controls.Add(this.lbl_ad);
            this.groupBox2.Controls.Add(this.lbl_kredi);
            this.groupBox2.Controls.Add(this.guncelleBtn);
            this.groupBox2.Controls.Add(this.lblAkts);
            this.groupBox2.Controls.Add(this.guncelDersHarfNotuTxt);
            this.groupBox2.Controls.Add(this.lblOgretimUyesi);
            this.groupBox2.Controls.Add(this.guncelDersDonemTxt);
            this.groupBox2.Controls.Add(this.lblDonem);
            this.groupBox2.Controls.Add(this.guncelOgretimUyesiTxt);
            this.groupBox2.Controls.Add(this.lblHarfNotu);
            this.groupBox2.Controls.Add(this.guncelDersAktsTxt);
            this.groupBox2.Controls.Add(this.guncelKodTxt);
            this.groupBox2.Controls.Add(this.guncelDersKrediTxt);
            this.groupBox2.Controls.Add(this.guncelDersAdiTxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(18, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 216);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncelleme Ekranı";
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
            // guncelleİptalBtn
            // 
            this.guncelleİptalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleİptalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncelleİptalBtn.ImageKey = "cancel.png";
            this.guncelleİptalBtn.ImageList = this.ımageList1;
            this.guncelleİptalBtn.Location = new System.Drawing.Point(627, 156);
            this.guncelleİptalBtn.Name = "guncelleİptalBtn";
            this.guncelleİptalBtn.Size = new System.Drawing.Size(131, 41);
            this.guncelleİptalBtn.TabIndex = 18;
            this.guncelleİptalBtn.Text = "İptal";
            this.guncelleİptalBtn.UseVisualStyleBackColor = true;
            this.guncelleİptalBtn.Click += new System.EventHandler(this.guncelleİptalBtn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "update (4).png");
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
            // guncelleBtn
            // 
            this.guncelleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guncelleBtn.ImageKey = "update (4).png";
            this.guncelleBtn.ImageList = this.ımageList1;
            this.guncelleBtn.Location = new System.Drawing.Point(480, 156);
            this.guncelleBtn.Name = "guncelleBtn";
            this.guncelleBtn.Size = new System.Drawing.Size(141, 41);
            this.guncelleBtn.TabIndex = 15;
            this.guncelleBtn.Text = "Güncelle";
            this.guncelleBtn.UseVisualStyleBackColor = true;
            this.guncelleBtn.Click += new System.EventHandler(this.guncelleBtn_Click);
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
            // guncelDersHarfNotuTxt
            // 
            this.guncelDersHarfNotuTxt.Location = new System.Drawing.Point(523, 111);
            this.guncelDersHarfNotuTxt.Name = "guncelDersHarfNotuTxt";
            this.guncelDersHarfNotuTxt.Size = new System.Drawing.Size(198, 24);
            this.guncelDersHarfNotuTxt.TabIndex = 14;
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
            // guncelDersDonemTxt
            // 
            this.guncelDersDonemTxt.Location = new System.Drawing.Point(523, 73);
            this.guncelDersDonemTxt.Name = "guncelDersDonemTxt";
            this.guncelDersDonemTxt.Size = new System.Drawing.Size(198, 24);
            this.guncelDersDonemTxt.TabIndex = 13;
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
            // guncelOgretimUyesiTxt
            // 
            this.guncelOgretimUyesiTxt.Location = new System.Drawing.Point(523, 36);
            this.guncelOgretimUyesiTxt.Name = "guncelOgretimUyesiTxt";
            this.guncelOgretimUyesiTxt.Size = new System.Drawing.Size(198, 24);
            this.guncelOgretimUyesiTxt.TabIndex = 12;
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
            // guncelDersAktsTxt
            // 
            this.guncelDersAktsTxt.Location = new System.Drawing.Point(152, 146);
            this.guncelDersAktsTxt.Name = "guncelDersAktsTxt";
            this.guncelDersAktsTxt.Size = new System.Drawing.Size(198, 24);
            this.guncelDersAktsTxt.TabIndex = 11;
            // 
            // guncelKodTxt
            // 
            this.guncelKodTxt.Location = new System.Drawing.Point(152, 33);
            this.guncelKodTxt.Name = "guncelKodTxt";
            this.guncelKodTxt.Size = new System.Drawing.Size(198, 24);
            this.guncelKodTxt.TabIndex = 8;
            // 
            // guncelDersKrediTxt
            // 
            this.guncelDersKrediTxt.Location = new System.Drawing.Point(152, 111);
            this.guncelDersKrediTxt.Name = "guncelDersKrediTxt";
            this.guncelDersKrediTxt.Size = new System.Drawing.Size(198, 24);
            this.guncelDersKrediTxt.TabIndex = 10;
            // 
            // guncelDersAdiTxt
            // 
            this.guncelDersAdiTxt.Location = new System.Drawing.Point(152, 73);
            this.guncelDersAdiTxt.Name = "guncelDersAdiTxt";
            this.guncelDersAdiTxt.Size = new System.Drawing.Size(198, 24);
            this.guncelDersAdiTxt.TabIndex = 9;
            // 
            // Ders_Güncelleme_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.guncelleGrpBx);
            this.Controls.Add(this.guncelle_txt);
            this.Controls.Add(this.lblGuncellenecekDersKodu);
            this.Name = "Ders_Güncelleme_Ekranı";
            this.Text = "Ders Güncelleme Ekranı";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.guncelleGrpBx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guncelListe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuncellenecekDersKodu;
        private System.Windows.Forms.TextBox guncelle_txt;
        private System.Windows.Forms.GroupBox guncelleGrpBx;
        private System.Windows.Forms.DataGridView guncelListe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_kod;
        private System.Windows.Forms.Button guncelleİptalBtn;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_kredi;
        private System.Windows.Forms.Button guncelleBtn;
        private System.Windows.Forms.Label lblAkts;
        private System.Windows.Forms.TextBox guncelDersHarfNotuTxt;
        private System.Windows.Forms.Label lblOgretimUyesi;
        private System.Windows.Forms.TextBox guncelDersDonemTxt;
        private System.Windows.Forms.Label lblDonem;
        private System.Windows.Forms.TextBox guncelOgretimUyesiTxt;
        private System.Windows.Forms.Label lblHarfNotu;
        private System.Windows.Forms.TextBox guncelDersAktsTxt;
        private System.Windows.Forms.TextBox guncelKodTxt;
        private System.Windows.Forms.TextBox guncelDersKrediTxt;
        private System.Windows.Forms.TextBox guncelDersAdiTxt;
        private System.Windows.Forms.ImageList ımageList1;
    }
}