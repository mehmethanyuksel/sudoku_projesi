using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku_Projesi
{
    class kontrolEt : Form1
    {
        public string text;
        public Boolean kontrol = false;
        private int tuty = 0, tutd = 0, tut;
        Form1 fm1;
        private int[,] matrisim = new int[9, 9];
        public kontrolEt(int[,] matris)
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    matrisim[i, j] = matris[i, j];


            satirsutun();
            dokuzluKontrol();
        }

        private void satirsutun()
        {

            if (kontrol == false)
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
                                        break;
                                        // frm.Controls["textbox" + i + j].BackColor = System.Drawing.SystemColors.ScrollBar;//textbox renklendirme işlemini hallet
                                    }
                            if (kontrol == false)
                                for (int k = j + 1; k < 9; k++)
                                    if (tutd == matrisim[k, i])
                                    {
                                        kontrol = true;
                                        text = (i + 1) + ". Sütunda hata tespit edildi";
                                        break;
                                    }
                        }
                }
        }

        private void dokuzluKontrol()
        {
            if (kontrol == false)
                for (int i = 0; i < 3; i++)
                    if (kontrol == false)
                        for (int j = 0; j < 3; j++)
                        {
                            tut = matris[i, j];
                            if (kontrol == false)
                                for (int k = j; k < 3; k++)
                                    if (kontrol == false)
                                        for (int l = 0; l < 3; l++)
                                            if (k != 0 || l != 0)
                                                if (tut == matris[k, l])
                                                {
                                                    kontrol = true;
                                                    text = "9'lu içerisinde hata tespit edildi";
                                                }
                        }
        }
    }
}
