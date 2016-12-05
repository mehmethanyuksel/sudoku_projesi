using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku_Projesi
{
    class baslangicDegerleri:AddBox
    {
        private Random uret = new Random();
        public baslangicDegerleri()
        {
            int j,k;
            for (int i = 0; i < 30; i++)
            {
                j = uret.Next(1,9);
                k = uret.Next(1,9);
                Form1.frm.Controls["textbox" + j + k].Enabled = false;
                Form1.frm.Controls["textbox" + j + k].Text = Convert.ToString(uret.Next(1, 9));
                //Form1.frm.Controls["textbox" + j + k].BackColor = System.Drawing.Color.LightGray;
                //Form1.frm.Controls["textbox" + j + k].ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
