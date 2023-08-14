using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_Odev2
{
    public partial class Ders_Güncelleme_Ekranı : Form
    {
        public Ders_Güncelleme_Ekranı()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=transkript;User Id=postgres;Password=1234");
        public void verileri_goster(string txt)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                guncelListe.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa yeni = new Anasayfa();
            yeni.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from ders");

        }

        private void guncelleİptalBtn_Click(object sender, EventArgs e)
        {
            Anasayfa eski = new Anasayfa();
            eski.Show();
            this.Hide();
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = baglanti;

            komut_guncelle.Parameters.AddWithValue("@kodu", guncelKodTxt.Text);
            komut_guncelle.Parameters.AddWithValue("@adi", guncelDersAdiTxt.Text);
            komut_guncelle.Parameters.AddWithValue("@kredisi", Convert.ToInt32(guncelDersKrediTxt.Text));
            komut_guncelle.Parameters.AddWithValue("@akts", Convert.ToInt32(guncelDersAktsTxt.Text));
            komut_guncelle.Parameters.AddWithValue("@ogretimUyesi", guncelOgretimUyesiTxt.Text);
            komut_guncelle.Parameters.AddWithValue("@donem", guncelDersDonemTxt.Text);
            komut_guncelle.Parameters.AddWithValue("@harfNotu", guncelDersHarfNotuTxt.Text);

            komut_guncelle.Parameters.AddWithValue("@hangi_kod", guncelle_txt.Text);

            komut_guncelle.CommandType = CommandType.Text;
            komut_guncelle.CommandText = "update ders set ders_kodu=@kodu, ders_adi=@adi, ders_kredisi=@kredisi, ders_akts=@akts, ogretim_uyesi=@ogretimUyesi,donem=@donem,harf_notu=@harfNotu where ders_kodu=@hangi_kod";

            int affectedRows = komut_guncelle.ExecuteNonQuery();

            if (affectedRows == 0)
            {
               
                MessageBox.Show("Veritabanında belirtilen ders kodu ile eşleşen bir kayıt bulunamadı.");
            }

            komut_guncelle.Dispose();
            baglanti.Close();

            verileri_goster("select * from ders");


        }

        private void guncelle_txt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_getir;

            if (guncelle_txt.Text.Trim() == "")
            {
                komut_getir = new NpgsqlCommand("select * from ders", baglanti);
            }
            else
            {
                komut_getir = new NpgsqlCommand();
                komut_getir.Connection = baglanti;
                komut_getir.Parameters.AddWithValue("@kodu", guncelle_txt.Text);
                komut_getir.CommandType = CommandType.Text;
                komut_getir.CommandText = "select * from ders where ders_kodu = @kodu";
            }

            NpgsqlDataReader dr = komut_getir.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                guncelListe.DataSource = dt;
            }

            komut_getir.Dispose();
            baglanti.Close();
        }
    }
}
