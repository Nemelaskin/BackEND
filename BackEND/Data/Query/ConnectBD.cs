using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BackEND.Data.Query
{
    public class ConnectBD
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=localhost;Initial Catalog=SecuritySystem;Integrated Security=True");

        private static DataSet doBD(string state, SqlConnection cnn)
        {
            cnn.Open();
            var dataAdapter = new SqlDataAdapter(state, cnn);
            var comBilder = new SqlCommandBuilder(dataAdapter);
            var bd = new DataSet();
            dataAdapter.Fill(bd);
            cnn.Close();
            return bd;
        }
        public DataSet requery(string _query)
        {
            var temp = doBD(_query, cnn);
            return temp;
        }
}
