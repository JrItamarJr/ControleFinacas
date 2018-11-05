using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancas.Model.Bean
{
    class UsuariosBEAN
    {
        private int id;
        private string nome;
        private double salario;
        private int data_pagamento;
        private double saldo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Salario { get => salario; set => salario = value; }
        public int Data_pagamento { get => data_pagamento; set => data_pagamento = value; }
        public double Saldo { get => saldo; set => saldo = value; }
    }
}
