using Npgsql;
using System.Data;

namespace ControleFinancas.Controller
{
    class Conexao
    {
        public NpgsqlConnection nConn = new NpgsqlConnection();
        private NpgsqlCommand nCmd;
        private NpgsqlDataAdapter nDa;
        private NpgsqlDataReader nDr;
        private NpgsqlCommandBuilder nCb;
        private DataTable nDt;

        private string sConcexao;


        public void AbreConexao()
        {
            sConcexao = "Server=localhost;Port=5432;User Id=financas;Password=1526;Database=financas;";
            nConn.ConnectionString = sConcexao;
            nConn.Open();

        }
         
        public void ExecutarSQL(string sSQL)
        {
            nCmd = new NpgsqlCommand(sSQL, nConn);
            nCmd.ExecuteNonQuery();
            nConn.Close();
        }

        public DataTable nDataTable(string sSQL)
        {
            nDt = new DataTable();
            nDa = new NpgsqlDataAdapter(sSQL, nConn);
            nCb = new NpgsqlCommandBuilder(nDa);
            nDa.Fill(nDt);
            nConn.Close();
            return nDt;
        }

        public NpgsqlDataReader nDataRead(string sSQL)
        {
            nCmd = new NpgsqlCommand(sSQL, nConn);
            nDr = nCmd.ExecuteReader();
            nDr.Read();
            nConn.Close();
            return nDr;
        }
    }
}