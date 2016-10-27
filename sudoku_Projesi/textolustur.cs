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
    class textolustur:Form
    {
        public textolustur()
        {
            int x = 302, y = 43;
            for (int i = 0; i < 9; i++)
            {
                TextBox t1 = new TextBox();
                t1.Name = "Text" + (i + 1);
                t1.Location = new System.Drawing.Point(x, y);
                t1.Multiline = true;
                t1.Size = new System.Drawing.Size(51, 51);
                this.Controls.Add(t1);
                x += 52;
            }
        }
    }
}
