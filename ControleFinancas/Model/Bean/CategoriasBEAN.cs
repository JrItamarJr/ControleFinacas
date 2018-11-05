using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancas.Model.Bean
{
    class CategoriasBEAN
    {
        private int id;
        private string descricao;
        private string limite;
        private string saldo;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Limite { get => limite; set => limite = value; }
        public string Saldo { get => saldo; set => saldo = value; }
    }
}
