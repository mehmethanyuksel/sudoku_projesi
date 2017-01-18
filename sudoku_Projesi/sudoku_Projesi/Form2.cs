using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sudoku_Projesi
{
    public partial class Form2 : Form
    {
        sqlBaglanti sql = new sqlBaglanti();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataSet ds;
            sql.sc.Open();

            //DatagridView 1
            
            string sqlCmd = "select * from kistatistik where k_adi ='"+uye_girisi.k_adi+"' ORDER BY skor ASC";
            da = new SqlDataAdapter(sqlCmd, sql.sc);
            ds=new DataSet();
            da.Fill(ds,"kistatistik");
            if (ds.Tables[0].Rows.Count == 0)
                dataGridView2.Hide();
            else
            {
                dataGridView2.DataSource = ds.Tables["kistatistik"];
                dataGridView2.Columns[0].HeaderText = "Kullanıcı İD";
                dataGridView2.Columns[1].HeaderText = "Kullanıcı Adı";
                dataGridView2.Columns[2].HeaderText = "Skor";
            }

            //DatagirView 2
            sqlCmd = "select k_adi,skor from kistatistik ORDER BY skor ASC";
            da = new SqlDataAdapter(sqlCmd, sql.sc);
            ds = new DataSet();
            da.Fill(ds, "kistatistik");
            dataGridView1.DataSource = ds.Tables["kistatistik"];
            dataGridView1.Columns[0].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[1].HeaderText = "Skor";

            sql.sc.Close();

            dataGridView1.Rows[0].DefaultCellStyle.BackColor = SystemColors.Highlight;
            dataGridView1.Rows[0].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.Rows[1].DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Rows[2].DefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.Rows[2].DefaultCellStyle.ForeColor = Color.White;
            
        }
    }
}
