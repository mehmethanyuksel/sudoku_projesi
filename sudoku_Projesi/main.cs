using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku_Projesi
{
    public partial class main : Form
    {
        public static main mai;
        public main()
        {
            InitializeComponent();
            mai = this;
        }



        private void main_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            uye_girisi uye_ekrani = new uye_girisi();
            uye_ekrani.Show();
            uye_ekrani.groupBox1.BringToFront();
            uye_ekrani.groupBox2.SendToBack();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            uye_girisi uye_ekrani = new uye_girisi();
            uye_ekrani.Show();
            uye_ekrani.groupBox1.BringToFront();
            uye_ekrani.groupBox2.SendToBack();
            uye_ekrani.Text = "Giriş Yap";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            uye_girisi uye_ekrani = new uye_girisi();
            uye_ekrani.Show();
            uye_ekrani.groupBox2.BringToFront();
            uye_ekrani.groupBox1.SendToBack();
            uye_ekrani.Text = "Kayıt Ol";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
