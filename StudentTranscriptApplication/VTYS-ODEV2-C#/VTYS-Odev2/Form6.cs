using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_Odev2
{
    public partial class Form6 : Form
    {
        public Form6()
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
                AlınanDersTablo.DataSource = dt;
            }
            komut.Dispose();
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double total_credits = 0;
            double total_grade_points = 0;

            string connectionString = ("Server=localhost;Database=transkript;User Id=postgres;Password=1234");
            using (NpgsqlConnection baglanti = new NpgsqlConnection(connectionString))
            {
                baglanti.Open();

                string queryString = "SELECT ders_adi, ders_kredisi, harf_notu FROM ders WHERE harf_notu IS NOT NULL";
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, baglanti))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string course_name = reader["ders_adi"].ToString();
                            int credit = Convert.ToInt32(reader["ders_kredisi"]);
                            string grade = reader["harf_notu"].ToString();

                            double grade_point = 0;
                            if (grade == "AA")
                            {
                                grade_point = 4.0;
                            }
                            else if (grade == "BA")
                            {
                                grade_point = 3.5;
                            }
                            else if (grade == "BB")
                            {
                                grade_point = 3.0;
                            }
                            else if (grade == "CB")
                            {
                                grade_point = 2.5;
                            }
                            else if (grade == "CC")
                            {
                                grade_point = 2.0;
                            }
                            else if (grade == "DC")
                            {
                                grade_point = 1.5;
                            }
                            else if (grade == "DD")
                            {
                                grade_point = 1.0;

                            }
                            else if (grade == "FD")
                            {
                                grade_point = 0.5;
                            }
                            else if (grade == "FF")
                            {
                                grade_point = 0.0;
                            }

                            total_credits += credit;
                            total_grade_points += grade_point * credit;
                        }
                    }
                }
            }

            double gpa = total_grade_points / total_credits;
            double truncatedNum = Math.Truncate(gpa * 100) / 100;
            txtGano.Text = Convert.ToString(truncatedNum);
            txtToplamKredi.Text = Convert.ToString(total_credits);
            

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            verileri_goster("select * from ders  where harf_notu is not null");
        }

        private void btnTranskriptİptal_Click(object sender, EventArgs e)
        {
            Anasayfa eski = new Anasayfa();
            eski.Show();
            this.Hide();
        }
    }
}
