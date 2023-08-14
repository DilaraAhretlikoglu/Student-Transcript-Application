namespace VTYS_Odev2
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.txtGano = new System.Windows.Forms.TextBox();
            this.btnGanoHesapla = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.DersBilgiList2 = new System.Windows.Forms.GroupBox();
            this.AlınanDersTablo = new System.Windows.Forms.DataGridView();
            this.lblGano = new System.Windows.Forms.Label();
            this.lblToplamKredi = new System.Windows.Forms.Label();
            this.txtToplamKredi = new System.Windows.Forms.TextBox();
            this.btnTranskriptİptal = new System.Windows.Forms.Button();
            this.DersBilgiList2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlınanDersTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGano
            // 
            this.txtGano.Location = new System.Drawing.Point(12, 398);
            this.txtGano.Multiline = true;
            this.txtGano.Name = "txtGano";
            this.txtGano.Size = new System.Drawing.Size(178, 30);
            this.txtGano.TabIndex = 0;
            // 
            // btnGanoHesapla
            // 
            this.btnGanoHesapla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGanoHesapla.ImageKey = "calculate_FILL0_wght400_GRAD0_opsz48.png";
            this.btnGanoHesapla.ImageList = this.ımageList1;
            this.btnGanoHesapla.Location = new System.Drawing.Point(324, 315);
            this.btnGanoHesapla.Name = "btnGanoHesapla";
            this.btnGanoHesapla.Size = new System.Drawing.Size(216, 40);
            this.btnGanoHesapla.TabIndex = 1;
            this.btnGanoHesapla.Text = "GANO HESAPLA";
            this.btnGanoHesapla.UseVisualStyleBackColor = true;
            this.btnGanoHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.png");
            this.ımageList1.Images.SetKeyName(1, "calculate_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // DersBilgiList2
            // 
            this.DersBilgiList2.Controls.Add(this.AlınanDersTablo);
            this.DersBilgiList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DersBilgiList2.Location = new System.Drawing.Point(1, 12);
            this.DersBilgiList2.Name = "DersBilgiList2";
            this.DersBilgiList2.Size = new System.Drawing.Size(971, 250);
            this.DersBilgiList2.TabIndex = 18;
            this.DersBilgiList2.TabStop = false;
            this.DersBilgiList2.Text = "Alınan Ders Bilgileri";
            // 
            // AlınanDersTablo
            // 
            this.AlınanDersTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlınanDersTablo.Location = new System.Drawing.Point(6, 21);
            this.AlınanDersTablo.Name = "AlınanDersTablo";
            this.AlınanDersTablo.RowHeadersWidth = 51;
            this.AlınanDersTablo.RowTemplate.Height = 24;
            this.AlınanDersTablo.Size = new System.Drawing.Size(968, 223);
            this.AlınanDersTablo.TabIndex = 0;
            // 
            // lblGano
            // 
            this.lblGano.AutoSize = true;
            this.lblGano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGano.Location = new System.Drawing.Point(19, 365);
            this.lblGano.Name = "lblGano";
            this.lblGano.Size = new System.Drawing.Size(56, 18);
            this.lblGano.TabIndex = 19;
            this.lblGano.Text = "GANO:";
            // 
            // lblToplamKredi
            // 
            this.lblToplamKredi.AutoSize = true;
            this.lblToplamKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKredi.Location = new System.Drawing.Point(9, 286);
            this.lblToplamKredi.Name = "lblToplamKredi";
            this.lblToplamKredi.Size = new System.Drawing.Size(181, 18);
            this.lblToplamKredi.TabIndex = 21;
            this.lblToplamKredi.Text = "TOPLAM DERS KREDİSİ:";
            // 
            // txtToplamKredi
            // 
            this.txtToplamKredi.Location = new System.Drawing.Point(12, 319);
            this.txtToplamKredi.Multiline = true;
            this.txtToplamKredi.Name = "txtToplamKredi";
            this.txtToplamKredi.Size = new System.Drawing.Size(178, 30);
            this.txtToplamKredi.TabIndex = 20;
            // 
            // btnTranskriptİptal
            // 
            this.btnTranskriptİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTranskriptİptal.ImageKey = "cancel.png";
            this.btnTranskriptİptal.ImageList = this.ımageList1;
            this.btnTranskriptİptal.Location = new System.Drawing.Point(324, 384);
            this.btnTranskriptİptal.Name = "btnTranskriptİptal";
            this.btnTranskriptİptal.Size = new System.Drawing.Size(216, 44);
            this.btnTranskriptİptal.TabIndex = 22;
            this.btnTranskriptİptal.Text = "İptal";
            this.btnTranskriptİptal.UseVisualStyleBackColor = true;
            this.btnTranskriptİptal.Click += new System.EventHandler(this.btnTranskriptİptal_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.btnTranskriptİptal);
            this.Controls.Add(this.lblToplamKredi);
            this.Controls.Add(this.txtToplamKredi);
            this.Controls.Add(this.lblGano);
            this.Controls.Add(this.DersBilgiList2);
            this.Controls.Add(this.btnGanoHesapla);
            this.Controls.Add(this.txtGano);
            this.Name = "Form6";
            this.Text = "Transkript Görüntüleme Ekranı";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.DersBilgiList2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlınanDersTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGano;
        private System.Windows.Forms.Button btnGanoHesapla;
        private System.Windows.Forms.GroupBox DersBilgiList2;
        private System.Windows.Forms.DataGridView AlınanDersTablo;
        private System.Windows.Forms.Label lblGano;
        private System.Windows.Forms.Label lblToplamKredi;
        private System.Windows.Forms.TextBox txtToplamKredi;
        private System.Windows.Forms.Button btnTranskriptİptal;
        private System.Windows.Forms.ImageList ımageList1;
    }
}