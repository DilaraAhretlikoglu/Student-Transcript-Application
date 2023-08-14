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
    public partial class KayıtEklemeEkranı : Form
    {
        public KayıtEklemeEkranı()
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
                KayıtTablo.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;

            komut_ekle.Parameters.AddWithValue("@kodu",(dersKoduTxt.Text));
            komut_ekle.Parameters.AddWithValue("@adi", dersAdiTxt.Text);
            komut_ekle.Parameters.AddWithValue("@kredisi", Convert.ToInt32(dersKrediTxt.Text));
            komut_ekle.Parameters.AddWithValue("@akts", Convert.ToInt32(dersAktsTxt.Text));
            komut_ekle.Parameters.AddWithValue("@ogretimUyesi", ogretimUyesiTxt.Text);
            komut_ekle.Parameters.AddWithValue("@donem", dersDonemTxt.Text);
            komut_ekle.Parameters.AddWithValue("@harfNotu", dersHarfNotuTxt.Text);


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ders (ders_kodu, ders_adi, ders_kredisi, ders_akts, ogretim_uyesi,donem,harf_notu) values (@kodu, @adi, @kredisi, @akts, @ogretimUyesi,@donem,@harfNotu)";

            NpgsqlDataReader dr2 = komut_ekle.ExecuteReader();
            if (dr2.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr2);
                KayıtTablo.DataSource = dt;
            }
            komut_ekle.Dispose();
            baglanti.Close();

            verileri_goster("select * from ders");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa eski = new Anasayfa();
            eski.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void KayıtTablo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KayıtEklemeEkranı_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from ders");

        }
    }
}
