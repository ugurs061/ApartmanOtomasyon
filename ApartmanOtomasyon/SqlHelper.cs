using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmanOtomasyon
{
    class SqlHelper
    {
        private string ConnectingString { get; set; }
        public SqlConnection Connection { get; set; }

        public SqlHelper()//classı her çağırdığımızda sql ile bağlantı sağlaması için constructor oluşturuyoruz.
        {
            ConnectingString = @"Data Source=DESKTOP-9UN9R3H;Initial Catalog=Apartman;Integrated Security=True";
            Connection = new SqlConnection(ConnectingString);
        }

        //sqldeki proc ları çalıştımak için metod yazıyoruz.
        public void ExecuteProc(string procName,params SqlParameter[] ps) 
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;//komut tipini belirledik.
            command.CommandText = procName;
            command.Parameters.AddRange(ps);//sql parametrelerini eklemek için kullanıyoruz.
            command.Connection = Connection;
            Connection.Open();
            command.ExecuteNonQuery();//komut çalıştırır
            Connection.Close();
        }

        //verileri getirtmek için metod tanımlıyoruz.
        public DataTable GetTable(string query)
        { 
            SqlDataAdapter sda = new SqlDataAdapter(query,ConnectingString);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}
