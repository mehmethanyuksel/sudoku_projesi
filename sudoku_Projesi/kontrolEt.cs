using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku_Projesi
{
    class kontrolEt
    {
        public string text;
        public Boolean kontrol = false;
        private int tuty = 0, tutd = 0, tut, ybitis = 3, ybos = 0, dbitis = 3, dbos = 0;
        public int tutk, tuti;
        private string strtut, strkont;
        private int[,] matrisim = new int[9, 9];
        public kontrolEt(int[,] matris)
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    matrisim[i, j] = matris[i, j];
            dokuzluKontrol();
            satirsutun();
        }
        private void satirsutun()
        {
            if (kontrol == false)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (kontrol == false)
                        for (int j = 0; j < 9; j++)
                        {
                            tuty = matrisim[i, j];
                            tutd = matrisim[j, i];
                            if (kontrol == false)
                                for (int k = j + 1; k < 9; k++)
                                    if (tuty == matrisim[i, k])
                                    {
                                        kontrol = true;
                                        text = (i + 1) + ". Satırda hata tespit edildi";
                                        tutk = k;
                                        tuti = i;
                                        Form1.dogrumu = false;
                                        break;
                                    }
                            if (kontrol == false)
                                for (int k = j + 1; k < 9; k++)
                                    if (tutd == matrisim[k, i])
                                    {
                                        kontrol = true;
                                        text = (i + 1) + ". Sütunda hata tespit edildi";
                                        tutk = k;
                                        tuti = i;
                                        Form1.dogrumu = false;
                                        break;
                                    }
                        }
                }

            }
        }

        private void dokuzluKontrol()
        {
            if (kontrol == false)
            {
                for (int m = 1; m <= 9; m++)
                {
                    if (kontrol == false)
                        for (int i = ybos; i < ybitis; i++)
                            if (kontrol == false)
                                for (int j = dbos; j < dbitis; j++)
                                {
                                    tut = matrisim[i, j];
                                    strtut = i + "" + j;
                                    if (kontrol == false)
                                        for (int k = ybos; k < ybitis; k++)
                                            if (kontrol == false)
                                                for (int l = dbos; l < dbitis; l++)
                                                {
                                                    strkont = k + "" + l;
                                                    if (strtut != strkont)
                                                        if (tut == matrisim[k, l])
                                                        {
                                                            kontrol = true;
                                                            text = m + ". 9'lu içerisinde hata tespit edildi";
                                                            Form1.dogrumu = false;
                                                            break;
                                                        }
                                                }
                                }
                    tut = 0;
                    ybos += 3;
                    ybitis += 3;
                    if (m % 3 == 0)
                    {
                        ybos = 0;
                        ybitis = 3;
                        dbos += 0;
                        dbitis += 3;
                    }
                }
            }
        }
    }
}
