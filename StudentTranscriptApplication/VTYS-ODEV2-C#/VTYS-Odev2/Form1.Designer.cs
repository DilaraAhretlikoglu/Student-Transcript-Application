namespace VTYS_Odev2
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.ListeTablo = new System.Windows.Forms.DataGridView();
            this.DersBilgi_GrpBx = new System.Windows.Forms.GroupBox();
            this.Komut_GrpBx = new System.Windows.Forms.GroupBox();
            this.btnTranskriptGörüntüle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKayıtGüncelle = new System.Windows.Forms.Button();
            this.btnKayıtSil = new System.Windows.Forms.Button();
            this.btnKayıtEkle = new System.Windows.Forms.Button();
            this.ara_lbl = new System.Windows.Forms.Label();
            this.ara_txt = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListeTablo)).BeginInit();
            this.DersBilgi_GrpBx.SuspendLayout();
            this.Komut_GrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListeTablo
            // 
            this.ListeTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeTablo.Location = new System.Drawing.Point(10, 23);
            this.ListeTablo.Name = "ListeTablo";
            this.ListeTablo.RowHeadersWidth = 51;
            this.ListeTablo.RowTemplate.Height = 24;
            this.ListeTablo.Size = new System.Drawing.Size(1014, 196);
            this.ListeTablo.TabIndex = 0;
            // 
            // DersBilgi_GrpBx
            // 
            this.DersBilgi_GrpBx.Controls.Add(this.ListeTablo);
            this.DersBilgi_GrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersBilgi_GrpBx.Location = new System.Drawing.Point(2, 70);
            this.DersBilgi_GrpBx.Name = "DersBilgi_GrpBx";
            this.DersBilgi_GrpBx.Size = new System.Drawing.Size(1014, 232);
            this.DersBilgi_GrpBx.TabIndex = 1;
            this.DersBilgi_GrpBx.TabStop = false;
            this.DersBilgi_GrpBx.Text = "Ders Bilgileri";
            // 
            // Komut_GrpBx
            // 
            this.Komut_GrpBx.Controls.Add(this.btnTranskriptGörüntüle);
            this.Komut_GrpBx.Controls.Add(this.btnKayıtGüncelle);
            this.Komut_GrpBx.Controls.Add(this.btnKayıtSil);
            this.Komut_GrpBx.Controls.Add(this.btnKayıtEkle);
            this.Komut_GrpBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Komut_GrpBx.Location = new System.Drawing.Point(2, 361);
            this.Komut_GrpBx.Name = "Komut_GrpBx";
            this.Komut_GrpBx.Size = new System.Drawing.Size(1014, 141);
            this.Komut_GrpBx.TabIndex = 2;
            this.Komut_GrpBx.TabStop = false;
            this.Komut_GrpBx.Text = "Komutlar";
            // 
            // btnTranskriptGörüntüle
            // 
            this.btnTranskriptGörüntüle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTranskriptGörüntüle.ImageKey = "visibility_FILL0_wght400_GRAD0_opsz48.png";
            this.btnTranskriptGörüntüle.ImageList = this.ımageList1;
            this.btnTranskriptGörüntüle.Location = new System.Drawing.Point(776, 55);
            this.btnTranskriptGörüntüle.Name = "btnTranskriptGörüntüle";
            this.btnTranskriptGörüntüle.Size = new System.Drawing.Size(212, 52);
            this.btnTranskriptGörüntüle.TabIndex = 3;
            this.btnTranskriptGörüntüle.Text = "Transkript";
            this.btnTranskriptGörüntüle.UseVisualStyleBackColor = true;
            this.btnTranskriptGörüntüle.Click += new System.EventHandler(this.transkriptGörüntüle_btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "save.png");
            this.ımageList1.Images.SetKeyName(1, "cancel.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "update (4).png");
            this.ımageList1.Images.SetKeyName(4, "visibility_FILL0_wght400_GRAD0_opsz48.png");
            this.ımageList1.Images.SetKeyName(5, "filter_list_FILL0_wght400_GRAD0_opsz48.png");
            this.ımageList1.Images.SetKeyName(6, "search_FILL0_wght400_GRAD0_opsz48.png");
            this.ımageList1.Images.SetKeyName(7, "add_circle_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // btnKayıtGüncelle
            // 
            this.btnKayıtGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtGüncelle.ImageKey = "update (4).png";
            this.btnKayıtGüncelle.ImageList = this.ımageList1;
            this.btnKayıtGüncelle.Location = new System.Drawing.Point(520, 55);
            this.btnKayıtGüncelle.Name = "btnKayıtGüncelle";
            this.btnKayıtGüncelle.Size = new System.Drawing.Size(212, 52);
            this.btnKayıtGüncelle.TabIndex = 2;
            this.btnKayıtGüncelle.Text = "    Kayıt Güncelle";
            this.btnKayıtGüncelle.UseVisualStyleBackColor = true;
            this.btnKayıtGüncelle.Click += new System.EventHandler(this.kayıtGüncelle_btn_Click);
            // 
            // btnKayıtSil
            // 
            this.btnKayıtSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtSil.ImageKey = "delete.png";
            this.btnKayıtSil.ImageList = this.ımageList1;
            this.btnKayıtSil.Location = new System.Drawing.Point(260, 55);
            this.btnKayıtSil.Name = "btnKayıtSil";
            this.btnKayıtSil.Size = new System.Drawing.Size(212, 52);
            this.btnKayıtSil.TabIndex = 1;
            this.btnKayıtSil.Text = "Kayıt Sil ";
            this.btnKayıtSil.UseVisualStyleBackColor = true;
            this.btnKayıtSil.Click += new System.EventHandler(this.kayıtSil_btn_Click);
            // 
            // btnKayıtEkle
            // 
            this.btnKayıtEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayıtEkle.ImageKey = "add_circle_FILL0_wght400_GRAD0_opsz48.png";
            this.btnKayıtEkle.ImageList = this.ımageList1;
            this.btnKayıtEkle.Location = new System.Drawing.Point(10, 55);
            this.btnKayıtEkle.Name = "btnKayıtEkle";
            this.btnKayıtEkle.Size = new System.Drawing.Size(212, 52);
            this.btnKayıtEkle.TabIndex = 0;
            this.btnKayıtEkle.Text = "Kayıt Ekle";
            this.btnKayıtEkle.UseVisualStyleBackColor = true;
            this.btnKayıtEkle.Click += new System.EventHandler(this.kayıtEkle_btn_Click);
            // 
            // ara_lbl
            // 
            this.ara_lbl.AutoSize = true;
            this.ara_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara_lbl.Location = new System.Drawing.Point(12, 31);
            this.ara_lbl.Name = "ara_lbl";
            this.ara_lbl.Size = new System.Drawing.Size(335, 18);
            this.ara_lbl.TabIndex = 3;
            this.ara_lbl.Text = "Bilgilerini görmek istediğiniz dersin kodunu giriniz: ";
            // 
            // ara_txt
            // 
            this.ara_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ara_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara_txt.Location = new System.Drawing.Point(388, 31);
            this.ara_txt.Multiline = true;
            this.ara_txt.Name = "ara_txt";
            this.ara_txt.Size = new System.Drawing.Size(373, 29);
            this.ara_txt.TabIndex = 4;
            this.ara_txt.TextChanged += new System.EventHandler(this.ara_txt_TextChanged);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListele.ImageKey = "filter_list_FILL0_wght400_GRAD0_opsz48.png";
            this.btnListele.ImageList = this.ımageList1;
            this.btnListele.Location = new System.Drawing.Point(12, 298);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(212, 48);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Dersleri Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.göster_btn_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageKey = "search_FILL0_wght400_GRAD0_opsz48.png";
            this.btnAra.ImageList = this.ımageList2;
            this.btnAra.Location = new System.Drawing.Point(797, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(97, 35);
            this.btnAra.TabIndex = 7;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "search_FILL0_wght400_GRAD0_opsz48.png");
            this.ımageList2.Images.SetKeyName(1, "refresh_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // btnYenile
            // 
            this.btnYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYenile.ImageKey = "refresh_FILL0_wght400_GRAD0_opsz48.png";
            this.btnYenile.ImageList = this.ımageList2;
            this.btnYenile.Location = new System.Drawing.Point(900, 31);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(116, 35);
            this.btnYenile.TabIndex = 8;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.button2_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 514);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.ara_txt);
            this.Controls.Add(this.ara_lbl);
            this.Controls.Add(this.Komut_GrpBx);
            this.Controls.Add(this.DersBilgi_GrpBx);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeTablo)).EndInit();
            this.DersBilgi_GrpBx.ResumeLayout(false);
            this.Komut_GrpBx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListeTablo;
        private System.Windows.Forms.GroupBox DersBilgi_GrpBx;
        private System.Windows.Forms.GroupBox Komut_GrpBx;
        private System.Windows.Forms.Button btnTranskriptGörüntüle;
        private System.Windows.Forms.Button btnKayıtGüncelle;
        private System.Windows.Forms.Button btnKayıtSil;
        private System.Windows.Forms.Button btnKayıtEkle;
        private System.Windows.Forms.Label ara_lbl;
        private System.Windows.Forms.TextBox ara_txt;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button btnYenile;
    }
}

