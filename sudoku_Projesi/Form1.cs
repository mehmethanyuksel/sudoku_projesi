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
    public partial class Form1 : Form
    {
        
        //private Timer t = new Timer(); //Timer'ı hallet
        public static Form1 frm;
        kontrolEt kontroll;
        public Form1()
        {
            //t.Start();
            InitializeComponent();
            frm = this; // form 1 in this i bu daha sonra addbox sınıfında ısımıze yarıcak
            //label1.Text = t.ToString();
        }
        private int[,] matris = new int[9, 9];
        Boolean kontroleKontrol = false;
        private void Form1_Load(object sender, EventArgs e)
        {
           //AddBox addtxt = new AddBox();
           baslangicDegerleri baslangic = new baslangicDegerleri();
           
        }
        private void matriseAl()
        {
            try
            {
                for (int i = 1; i <= 9; i++)
                    for (int j = 1; j <= 9; j++)
                        matris[i - 1, j - 1] = int.Parse(((TextBox)this.Controls["textbox" + i + j]).Text); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lütfen tüm alanları doldurup yeniden deneyiniz.");
                kontroleKontrol = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            matriseAl();
            if (kontroleKontrol==false)
            {
                kontroll = new kontrolEt(matris);
                MessageBox.Show(kontroll.text);
            }
            else
                kontroleKontrol = false;
        }
        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
    
}
