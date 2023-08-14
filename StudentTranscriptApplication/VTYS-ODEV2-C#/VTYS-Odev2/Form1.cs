using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTYS_Odev2
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
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
                ListeTablo.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void kayıtEkle_btn_Click(object sender, EventArgs e)
        {
            KayıtEklemeEkranı yeni = new KayıtEklemeEkranı();
            yeni.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from ders");
        }

        private void göster_btn_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from ders");
        }

        private void kayıtSil_btn_Click(object sender, EventArgs e)
        {
            Ders_Silme_Ekrani yeni2 = new Ders_Silme_Ekrani();
            yeni2.Show();
            this.Hide();
        }

        private void kayıtGüncelle_btn_Click(object sender, EventArgs e)
        {
            Ders_Güncelleme_Ekranı yenimi = new Ders_Güncelleme_Ekranı();
            yenimi.Show();
            this.Hide();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            
        }

        private void ara_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                baglanti.Open();
                DataTable dt = new DataTable();
                NpgsqlDataAdapter ara = new NpgsqlDataAdapter("select * from ders where ders_kodu like '%" + ara_txt.Text + "%'", baglanti);
                ara.Fill(dt);
                baglanti.Close();
                if (dt.Rows.Count > 0)
                {
                    ListeTablo.DataSource = dt;
                    ListeTablo.Refresh();
                }
                else
                {
                    MessageBox.Show("Aranan bilgi veritabanında bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Veritabanı bağlantısı açılırken bir hata oluştu, hata mesajını gösterin
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            verileri_goster("select * from ders");
        }

        private void transkriptGörüntüle_btn_Click(object sender, EventArgs e)
        {
            Form6 yenimi = new Form6();
            yenimi.Show();
            this.Hide();
        }
    }
    
}
