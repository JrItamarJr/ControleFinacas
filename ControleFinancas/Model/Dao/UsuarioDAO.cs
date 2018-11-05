using System;
using System.Windows.Forms;
using System.Data;
using ControleFinancas.Controller;
using ControleFinancas.Model.Bean;
using ControleFinancas.View;
using Npgsql;

namespace ControleFinancas.Model.Dao
{
    class UsuarioDAO
    {
        Conexao nConn;

        public DataTable ReadTable()
        {

            DataTable nDt = new DataTable();
            try
            {
                nConn = new Conexao();
                nConn.AbreConexao();

                nDt = nConn.nDataTable("SELECT ID, nome, salario, data_pagamento FROM usuarios");

            }
            catch (Exception ex)
            {
                MessageError mErro = new MessageError("Erro ao buscar Cadastro de Categorias: \n\n" + ex.Message);
                mErro.ShowDialog();
            }

            return nDt;
        }

        public void inserir(UsuariosBEAN userBean)
        {
            try
            {
                nConn = new Conexao();
                nConn.AbreConexao();

                string sDescricao = userBean.Nome.Replace("'", "''");
                string sSQL = "INSERT INTO usuarios (nome, salario, data_pagamento) VALUES ('" + userBean.Nome + "','" + userBean.Salario + "','"+userBean.Data_pagamento+"');";
                nConn.ExecutarSQL(sSQL);

            }
            catch (Exception ex)
            {
                MessageError mErro = new MessageError("Erro ao tentar Cadastrar: \n\n" + ex.Message);
                mErro.ShowDialog();
            }
            finally
            {
                nConn = null;
            }

        }


       
        public void Deletar(UsuariosBEAN userBean)
        {
            try
            {
                nConn = new Conexao();
                nConn.AbreConexao();
                string sSQL = "DELETE FROM usuarios WHERE ID = " + userBean.Id + ";";
                nConn.ExecutarSQL(sSQL);

            }
            catch (Exception ex)
            {
                MessageError mErro = new MessageError("Erro ao tentar Excluir: \n\n" + ex.Message);
                mErro.ShowDialog();
            }
            finally
            {
                nConn = null;
            }

        }
    }
}
