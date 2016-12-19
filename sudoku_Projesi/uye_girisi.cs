using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sudoku_Projesi
{
    public partial class uye_girisi : Form
    {
        private sqlBaglanti baglan;
        private Form1 frm;
        public static string k_adi;
        public uye_girisi()
        {
            InitializeComponent();
            baglan = new sqlBaglanti();
            try
            {
                baglan.sc.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası Oluştu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.komut.CommandText = "INSERT INTO uyeler(k_adi,sifre) VALUES ('"+textBox3.Text+"','"+textBox4.Text+"')";
            baglan.dr = baglan.komut.ExecuteReader();
            try
            {
                if (textBox3.TextLength != 0 && textBox4.TextLength != 0)
                {
                    baglan.dr.Read();
                    MessageBox.Show("Kaydınız başarıyla alındı, Şimdi giriş yapınız.");
                }
                else
                    MessageBox.Show("Boş değer Girmeyin");
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİNİZ");
            }
            baglan.dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglan.komut.CommandText = "SELECT * FROM uyeler where k_adi='" + textBox1.Text + "' AND sifre='" + textBox2.Text + "'";
            baglan.dr = baglan.komut.ExecuteReader();
            try
            {
                if (textBox1.TextLength != 0 && textBox2.TextLength != 0&&baglan.dr.Read())
                {
                    k_adi = textBox1.Text;
                    MessageBox.Show("Başarıyla giriş yaptınız");
                    k_adi = textBox1.Text;
                    
                    
                }
                else
                    MessageBox.Show("Boş değer Girmeyin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİNİZ");
            }
            baglan.dr.Close();
        }
    }
}
