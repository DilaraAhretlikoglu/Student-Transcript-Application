namespace VTYS_Odev2
{
    partial class Ders_Silme_Ekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ders_Silme_Ekrani));
            this.dersSil_lbl = new System.Windows.Forms.Label();
            this.silinecekDersKoduTxt = new System.Windows.Forms.TextBox();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DersBilgiList3 = new System.Windows.Forms.GroupBox();
            this.SilmeTablo = new System.Windows.Forms.DataGridView();
            this.btnSilmeİptal = new System.Windows.Forms.Button();
            this.DersBilgiList3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SilmeTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // dersSil_lbl
            // 
            this.dersSil_lbl.AutoSize = true;
            this.dersSil_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersSil_lbl.Location = new System.Drawing.Point(42, 27);
            this.dersSil_lbl.Name = "dersSil_lbl";
            this.dersSil_lbl.Size = new System.Drawing.Size(210, 18);
            this.dersSil_lbl.TabIndex = 0;
            this.dersSil_lbl.Text = "Silinecek dersin kodunu giriniz:";
            // 
            // silinecekDersKoduTxt
            // 
            this.silinecekDersKoduTxt.Location = new System.Drawing.Point(270, 27);
            this.silinecekDersKoduTxt.Name = "silinecekDersKoduTxt";
            this.silinecekDersKoduTxt.Size = new System.Drawing.Size(172, 22);
            this.silinecekDersKoduTxt.TabIndex = 1;
            this.silinecekDersKoduTxt.TextChanged += new System.EventHandler(this.silinecekDersKoduTxt_TextChanged);
            // 
            // btnDersSil
            // 
            this.btnDersSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDersSil.ImageKey = "delete.png";
            this.btnDersSil.ImageList = this.ımageList1;
            this.btnDersSil.Location = new System.Drawing.Point(529, 19);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(127, 30);
            this.btnDersSil.TabIndex = 2;
            this.btnDersSil.Text = "Dersi Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            // 
            // DersBilgiList3
            // 
            this.DersBilgiList3.Controls.Add(this.SilmeTablo);
            this.DersBilgiList3.Location = new System.Drawing.Point(3, 110);
            this.DersBilgiList3.Name = "DersBilgiList3";
            this.DersBilgiList3.Size = new System.Drawing.Size(860, 328);
            this.DersBilgiList3.TabIndex = 3;
            this.DersBilgiList3.TabStop = false;
            this.DersBilgiList3.Text = "Ders Bilgileri";
            // 
            // SilmeTablo
            // 
            this.SilmeTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SilmeTablo.Location = new System.Drawing.Point(-1, 27);
            this.SilmeTablo.Name = "SilmeTablo";
            this.SilmeTablo.RowHeadersWidth = 51;
            this.SilmeTablo.RowTemplate.Height = 24;
            this.SilmeTablo.Size = new System.Drawing.Size(929, 295);
            this.SilmeTablo.TabIndex = 0;
            // 
            // btnSilmeİptal
            // 
            this.btnSilmeİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSilmeİptal.ImageKey = "cancel.png";
            this.btnSilmeİptal.ImageList = this.ımageList1;
            this.btnSilmeİptal.Location = new System.Drawing.Point(529, 75);
            this.btnSilmeİptal.Name = "btnSilmeİptal";
            this.btnSilmeİptal.Size = new System.Drawing.Size(127, 29);
            this.btnSilmeİptal.TabIndex = 4;
            this.btnSilmeİptal.Text = "İptal";
            this.btnSilmeİptal.UseVisualStyleBackColor = true;
            this.btnSilmeİptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ders_Silme_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.btnSilmeİptal);
            this.Controls.Add(this.DersBilgiList3);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.silinecekDersKoduTxt);
            this.Controls.Add(this.dersSil_lbl);
            this.Name = "Ders_Silme_Ekrani";
            this.Text = "Ders Silme Ekranı";
            this.Load += new System.EventHandler(this.Ders_Silme_Ekrani_Load);
            this.DersBilgiList3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SilmeTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dersSil_lbl;
        private System.Windows.Forms.TextBox silinecekDersKoduTxt;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.GroupBox DersBilgiList3;
        private System.Windows.Forms.DataGridView SilmeTablo;
        private System.Windows.Forms.Button btnSilmeİptal;
        private System.Windows.Forms.ImageList ımageList1;
    }
}