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
    public partial class uye_girisi : Form
    {
        public uye_girisi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox3.TextLength != 0 && textBox4.TextLength != 0)
                {

                }
                else
                {
                    MessageBox.Show("Boş değer Girmeyin");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİNİZ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.TextLength != 0 && textBox2.TextLength != 0)
                {

                }
                else
                {
                    MessageBox.Show("Boş değer Girmeyin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİNİZ");
            }
        }
    }
}
