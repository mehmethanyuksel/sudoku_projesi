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
        private Random disableFalseRandom = new Random();
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
            TextBox textbox = new TextBox();
            textbox.Name = "Textbox" + sutun + satir;
            textbox.Location = new System.Drawing.Point(x, y);
            textbox.Multiline = true;
            textbox.Size = new System.Drawing.Size(51, 51);
            textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textbox.MaxLength = 1;
            textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            Form1.frm.Controls.Add(textbox);
            textbox.Text = Convert.ToString(disableFalseRandom.Next(1, 9));
        }
    }
}
