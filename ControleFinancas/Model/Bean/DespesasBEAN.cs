using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinancas.Model.Bean
{
    class DespesasBEAN
    {
        private int id;
        private string despesa;
        private int categoria;
        private int usuario;
        private DateTime data_entrada;
        private DateTime data_vencimento;
        private int parcelas;
        private double valor_total;
        private double valor_parcela;
        private string observacao;
        private DateTime data_pagamento;

        public int Id { get => id; set => id = value; }
        public string Despesa { get => despesa; set => despesa = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Usuario { get => usuario; set => usuario = value; }
        public DateTime Data_entrada { get => data_entrada; set => data_entrada = value; }
        public DateTime Data_vencimento { get => data_vencimento; set => data_vencimento = value; }
        public int Parcelas { get => parcelas; set => parcelas = value; }
        public double Valor_total { get => valor_total; set => valor_total = value; }
        public double Valor_parcela { get => valor_parcela; set => valor_parcela = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public DateTime Data_pagamento { get => data_pagamento; set => data_pagamento = value; }
    }
}
