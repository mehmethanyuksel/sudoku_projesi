using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sudoku_Projesi
{
    class sqlBaglanti
    {
        public SqlCommand komut;
        public SqlConnection sc;
        public SqlDataReader dr;
        public sqlBaglanti()
        {
            sc = new SqlConnection("server=PC;Initial Catalog=db_sudoku;Integrated Security=SSPI");
            komut = new SqlCommand();
            komut.Connection = sc;
        }
    }
}
