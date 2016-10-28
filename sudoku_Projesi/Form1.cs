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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Random disableFalseRandom = new Random(); //11 ile 99 arası rastgele 15 tane deger üret ve buna göre 15 tane alanı doldur
           int x = 302, y = 30;
           for (int sutun = 1; sutun<= 9; sutun++)
            {
                for (int satir = 1; satir <= 9; satir++)
                {
                    textboxekle(x, y, satir, sutun);
                    x += 52;            // 52 piksel sağa kaydır
                    if (satir % 3 == 0) // her 3 sütunda 10 px boşluk bırak
                        x += 10;
                }
                x = 302;                // yatay konumu sıfırla
                y += 52;                // dikeyde 52 px aşağı in
                if (sutun % 3 == 0)     // her 3 satırda 10 px boşluk bırak
                    y += 10;   
            }
           
        }
        public void textboxekle(int x,int y, int satir,int sutun)
           {
               TextBox textbox = new TextBox();
               textbox.Name = "Textbox" + sutun + satir;
               textbox.Location = new System.Drawing.Point(x, y);
               textbox.Multiline = true;
               textbox.Size = new System.Drawing.Size(51, 51);
               textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               textbox.MaxLength = 1;
               textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.Controls.Add(textbox);
               textbox.Text = "3";
           }//eklenecek textboxların özellikleri
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matris = new int[9, 9];
            Boolean kontrol=false;
            try
            { 
                
                for (int i = 1; i<= 9; i++)
                {
                    for (int j = 1; j<= 9; j++)
                        matris[i - 1, j - 1] = int.Parse(((TextBox)this.Controls["textbox"+i+j]).Text);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Lütfen tüm alanları doldurup tekrar deneyiniz.");
            }
           /// KONTROL ALANI ///
            for (int i = 1; i <= 9; i++)
            {
                for (int j = i; j <= 9; j++)//satır kontrolü
                {
                    if (matris[i - 1, j - 1] == matris[i-1, j])
                    {
                        MessageBox.Show("Yanlış cevap tekrar deneyiniz.");
                        break;
                        kontrol = true;
                    }
                }
                for (int j = i; j <= 9; j++)//sütun kontrolü
                {
                    if (matris[j - 1, i - 1] == matris[j , i-1])
                    {
                        MessageBox.Show("Yanlış cevap tekrar deneyiniz.");
                        break;
                        kontrol = true;
                    }
                }
                //3lü alanlar kontrol edilecek
                if (kontrol = true)
                    break;
            }
            if (kontrol = false)
                MessageBox.Show("TEBRİKLER SONUCA ULAŞTINIZ!! YİHUUU");
        }//Kontrol etme olayı

        
       

        
    }
    
}
