using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proje.Business
{
    public class Business3
    {

        public DataTable GetDataTable(string sorgu)
        {
            DataAccess3 baglanti = new DataAccess3();
            DataTable dt = new DataTable();
            SqlDataAdapter da = baglanti.DataAdapter(sorgu);
            da.Fill(dt);
            baglanti.connectionkapa();
            return dt;

        }
        public DataTable GetList(string sorgu)
        {
            DataAccess3 baglanti = new DataAccess3();
            DataTable dt = new DataTable();
            SqlDataAdapter da = baglanti.DataAdapter(sorgu);
            da.Fill(dt);
            return dt;
        }

        public SqlDataReader GetDataReader(string sorgu)
        {
            DataAccess3 baglanti = new DataAccess3();
            baglanti.connectionac();
            SqlCommand com = baglanti.Db2Command(sorgu);
            SqlDataReader dr = com.ExecuteReader();
            return dr;
            baglanti.connectionkapa();

        }
    }
}
