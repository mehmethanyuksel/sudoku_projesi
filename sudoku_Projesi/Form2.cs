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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_sudokuDataSet2.kistatistik' table. You can move, or remove it, as needed.
            this.kistatistikTableAdapter.Fill(this.db_sudokuDataSet2.kistatistik);
            

        }
    }
}
