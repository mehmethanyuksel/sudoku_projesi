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
        public static Form1 frm;
        public Form1()
        {
            InitializeComponent();
            frm = this;
        }
        public int[,] matris = new int[9, 9];
        private void Form1_Load(object sender, EventArgs e)
        {
           AddBox addtxt = new AddBox();

           
        }
        private void matriseAl()
        {
            for (int i = 1; i <= 9; i++)
                for (int j = 1; j <= 9; j++)
                    matris[i - 1, j - 1] = int.Parse(((TextBox)this.Controls["textbox" + i + j]).Text); // textboxtaki değerleri matrise atadık
        }
        private void button1_Click(object sender, EventArgs e)
        {
            matriseAl();
            int tut=0;
            Boolean kontrol = false;
            try
            {
                if (kontrol == true)
                    for (int i = 0; i < 9; i++)
                    {
                        if (kontrol == true)
                            for (int j = 0; j < 9; j++)
                            {
                                tut = matris[i, j];
                                if (kontrol == false) 
                                    for (int k = j+1; k < 9; k++)
                                    {
                                        if (tut == matris[i, k])
                                        {
                                            kontrol = true;
                                            //MessageBox.Show(i+". satır yanlış");
                                            frm.Controls["textbox" + i + j].BackColor = System.Drawing.SystemColors.ScrollBar;
                               

                                        }
                                    }
                            }
                    }
                kontrol = false;
              
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen tüm alanları doldurup tekrar deneyiniz.");
            }
            
            
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

        }//Kontrol etme olayı

        
       

        
    }
    
}
