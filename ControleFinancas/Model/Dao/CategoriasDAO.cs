using System;
using System.Data;
using ControleFinancas.Controller;
using System.Windows.Forms;
using ControleFinancas.Model.Bean;
using ControleFinancas.View;

namespace ControleFinancas.Model.Dao
{
    class CategoriasDAO
    {
            Conexao nConn;

        public DataTable ReadTable()
        {

            DataTable nDt = new DataTable();
            try
            {
                nConn = new Conexao();
                nConn.AbreConexao();

                nDt = nConn.nDataTable("SELECT ID, descricao, limite, saldo FROM categorias");

            }
            catch (Exception ex)
            {
                MessageError mErro = new MessageError("Erro ao buscar Cadastro de Categorias: " + ex.Message);
                mErro.ShowDialog();
            }

            return nDt;
        }

        public void inserir(CategoriasBEAN catBean)
        {
            try
            {
                nConn = new Conexao();
                nConn.AbreConexao();
                string sDescricao = catBean.Descricao.Replace("'", "''");
                string sSQL = "INSERT INTO categorias (descricao, limite) VALUES ('"+ catBean.Descricao +"','"+ catBean.Limite +"');";
                nConn.ExecutarSQL(sSQL);

            }
            catch (Exception ex)
            {
                MessageError mErro = new MessageError("Erro ao tentar Cadastrar: " + ex.Message);
                mErro.ShowDialog();
            }
            finally
            {
                nConn = null;
            }

        }

        public void Deletar(CategoriasBEAN catBean)
        {
            try
            {
                nConn = new Conexao();
                nConn.AbreConexao();
                string sSQL = "DELETE FROM categorias WHERE ID = "+ catBean.Id +";";
                nConn.ExecutarSQL(sSQL);

            }
            catch (Exception ex)
            {
                MessageError mErro = new MessageError("Erro ao tentar Excluir: " + ex.Message);
                mErro.ShowDialog();
            }
            finally
            {
                nConn = null;
            }

        }
    }
}
