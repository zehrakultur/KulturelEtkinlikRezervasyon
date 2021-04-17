using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proje.Business
{
    public class DataAccess3
    {
        string baglanti;
        SqlConnection con;

        public DataAccess3()
        {
            baglanti = "Data Source=.;Initial Catalog=KulturelEtkinlik;Integrated Security=True";
            con = new SqlConnection(baglanti);
        }

        public void connectionac()
        {
            try
            {
                con = new SqlConnection(baglanti);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
            
        }

        public void connectionkapa()
        {
            try
            {
                if(con.State != ConnectionState.Closed)
                {
                    con.Dispose();
                    con.Close();
                }
            }
            catch(Exception e) 
            {
                e.Message.ToString();
            }
        }

        public SqlDataAdapter DataAdapter(String sorgu)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, con);
            return adapter;
        }

        public SqlCommand Db2Command(String sorgu)
        {
            SqlCommand command = new SqlCommand(sorgu, con);
            command.CommandTimeout = 3600;
            return command;
        }

    }
}
