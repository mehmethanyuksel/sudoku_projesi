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
        public main()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uye_girisi uye_ekrani = new uye_girisi();
            uye_ekrani.Show();
            uye_ekrani.groupBox1.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uye_girisi uye_ekrani = new uye_girisi();
            uye_ekrani.Show();
            uye_ekrani.groupBox1.Location = new Point(200, 200);
            uye_ekrani.groupBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            main mainForm = new main();
            frm1.Show();
            mainForm.Hide();
            
        }

        private void main_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }
    }
}
