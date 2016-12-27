using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku_Projesi
{
    class AddBox
    {
        public AddBox()
        {
            int x = 302, y = 30;
            for (int sutun = 1; sutun <= 9; sutun++)
            {
                for (int satir = 1; satir <= 9; satir++)
                {
                    ekle(x, y, satir, sutun);
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
        public void ekle(int x, int y, int satir, int sutun)
        {
            TextBox textbox = new TextBox();                    //Textbox sınıfından nesne üret
            textbox.Name = "Textbox" + sutun + satir;           //Textbox'a isim ver, textbox'ın text'i değil ismi
            textbox.Location = new System.Drawing.Point(x, y);  //Konum
            textbox.Multiline = true;                           //Çok satırlılık normalde aşşa dogru uzamıyodu bu kodla uzayabılıyo artık 
            textbox.Size = new System.Drawing.Size(51, 51);     //Boyut
            textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;//dikeyde satırın ortalanması ıcın cursor ın ortada cıkması ıcın 
            textbox.MaxLength = 1;                              // max 1 karaktere ızın verır rakam ıcın yaptık yani
            textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))); // font ozeelıklerı
            Form1.frm.Controls.Add(textbox); // form 1 deki frm.this ile buraya oluşturdugumuz nesneyi 
            textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
        }
        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
