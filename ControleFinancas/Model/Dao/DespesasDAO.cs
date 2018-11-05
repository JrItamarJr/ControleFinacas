using System;
using System.Data;
using ControleFinancas.Controller;
using ControleFinancas.Model.Bean;
using ControleFinancas.View;

namespace ControleFinancas.Model.Dao
{
    class DespesasDAO
    {
        Conexao nConn;

        public DataTable ReadTable()
        {

            DataTable nDt = new DataTable();
            try
            {
                nConn = new Conexao();
                nConn.AbreConexao();

                nDt = nConn.nDataTable("SELECT DESPESAS.ID,DESPESA,VALOR_TOTAL,DATA_VENCIMENTO,PARCELAS,CAT.DESCRICAO,USE.NOME,VALOR_PARCELA,DATA_ENTRADA,OBSERVACAO,DESPESAS.DATA_PAGAMENTO FROM DESPESAS INNER JOIN USUARIOS AS USE ON DESPESAS.USUARIO = USE.ID INNER JOIN CATEGORIAS AS CAT ON CAT.ID = DESPESAS.CATEGORIA;");

            }
            catch (Exception ex)
            {
                MessageError mErro = new MessageError("Erro ao buscar Cadastro de Categorias: " + ex.Message);
                mErro.ShowDialog();
            }

            return nDt;
        }

        
        public void inserir(DespesasBEAN desBean)
        {
            try
            {
                nConn = new Conexao();
                nConn.AbreConexao();
                string sDescricao = desBean.Despesa.Replace("'", "''");
                string sSQL = "INSERT INTO despesas(despesa, categoria, usuario, data_entrada, data_vencimento, parcelas, valor_total, valor_parcela, observacao, data_pagamento)" +
                    "VALUES('"+desBean.Despesa+"', "+ desBean.Categoria+ ", "+ desBean.Usuario+ ", '"+ desBean.Data_entrada+ "', '"+ desBean.Data_vencimento+ "',"+ desBean.Parcelas+ ",'"+ desBean.Valor_total+ "', '"+ desBean.Valor_parcela+
                    "', '"+ desBean.Observacao+ "', '"+ desBean.Data_pagamento+ "');";
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

        public void Deletar(DespesasBEAN desBean)
        {
            try
            {
                nConn = new Conexao();
                nConn.AbreConexao();
                string sSQL = "DELETE FROM despesas WHERE ID = " + desBean.Id + ";";
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
