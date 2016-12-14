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
        private int j, k, boss = 10;
        public int derece=20;
        private Random uret = new Random();
        kontrolEt knt;
        private int[,] matris = new int[9, 9];
        public baslangicDegerleri()
        {
            yeniuretim();
            textboxaAta();
        }
        private void yeniuretim()
        {
            
            for (int i = 0; i < derece; i++)
            {
                j = uret.Next(1, 9);
                k = uret.Next(1, 9);
                matris[j, k] = uret.Next(1, 9);
                for (int m = 0; m < 9; m++)
                    for (int l = 0; l < 9; l++)
                        if (matris[m, l] == 0)
                        {
                            matris[m, l] = boss;
                            boss++;
                        }
                knt = new kontrolEt(matris);
                if (knt.kontrol == true)
                {
                    i--;
                    matris[j, k] = 0;
                }
                knt.kontrol = false;
            }

        }
        private void textboxaAta()
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    Form1.frm.Controls["textbox" + (i + 1) + (j + 1)].Text = matris[i, j].ToString();
                    if (Form1.frm.Controls["textbox" + (i + 1) + (j + 1)].Text.Length >= 2)
                        Form1.frm.Controls["textbox" + (i + 1) + (j + 1)].Text = "";
                    else
                        Form1.frm.Controls["textbox" + (i + 1) + (j + 1)].Enabled = false;
                }
        }
    }
}
