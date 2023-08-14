using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTYS_Odev2
{
    public partial class Ders_Silme_Ekrani : Form
    {
        public Ders_Silme_Ekrani()
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
                SilmeTablo.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_sil = new NpgsqlCommand();
            komut_sil.Connection = baglanti;
            komut_sil.Parameters.AddWithValue("@kodu", (silinecekDersKoduTxt.Text));

            komut_sil.CommandType = CommandType.Text;
            komut_sil.CommandText = "delete from ders where ders_kodu = @kodu";

            int affectedRows = komut_sil.ExecuteNonQuery();

            if (affectedRows == 0)
            {
                MessageBox.Show("Veritabanında belirtilen ders kodu ile eşleşen bir kayıt bulunamadı.");
            }

            komut_sil.Dispose();
            baglanti.Close();

            verileri_goster("select * from ders");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Anasayfa eski = new Anasayfa();
            eski.Show();
            this.Hide();
        }

        private void silinecekDersKoduTxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_getir;

            if (silinecekDersKoduTxt.Text.Trim() == "")
            {
                komut_getir = new NpgsqlCommand("select * from ders", baglanti);
            }
            else
            {
                komut_getir = new NpgsqlCommand();
                komut_getir.Connection = baglanti;
                komut_getir.Parameters.AddWithValue("@kodu", silinecekDersKoduTxt.Text);
                komut_getir.CommandType = CommandType.Text;
                komut_getir.CommandText = "select * from ders where ders_kodu = @kodu";
            }

            NpgsqlDataReader dr = komut_getir.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                SilmeTablo.DataSource = dt;
            }

            komut_getir.Dispose();
            baglanti.Close();

        }

        private void Ders_Silme_Ekrani_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from ders");



        }
    }
}
