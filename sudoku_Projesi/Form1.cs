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
            int x = 302, y = 30;

            for (int satir = 0; satir < 9; satir++)
            {
                for (int sutun = 0; sutun < 9; sutun++)
                {
                    TextBox text = new TextBox();
                    text.Name = "Text" + (sutun + 1);
                    text.Location = new System.Drawing.Point(x, y);
                    text.Multiline = true;
                    text.Size = new System.Drawing.Size(51, 51);
                    text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                    text.MaxLength = 1;
                    text.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    this.Controls.Add(text);
                    x += 52;
                    if (sutun % 3 == 2)
                        x += 10;
                }
                x = 302;
                y += 52;
                if (satir % 3 == 2)
                    y += 10;
                
            }
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
    
}
