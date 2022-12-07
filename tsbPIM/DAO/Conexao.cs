using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsbPIM.DAL
{
    public class Conexao
    {
      
            SqlConnection con = new SqlConnection();
    
            public Conexao()
            {
            con.ConnectionString = @"Data Source=EVERY253;Initial Catalog=PIM4;Integrated Security=True";
            }
        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
        }
        
    
    }
}
