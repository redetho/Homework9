using System;
using System.Collections.Generic;
using System.Text;

namespace atividade.Entities
{
    class ContaPoupança : Conta
    {
        //declaração de variáveis e encapsulamento
        public double TaxaJuros { get; set; }
        //construtor padrão
        public ContaPoupança() { }
        //construtor com parâmetros
        //valor dos juros:
        public ContaPoupança(int numero, string titular, double saldo, double taxaJuros)
            : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }
        //atualiza o saldo de acordo com os juros
        public void atualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }
        //sobreposição
        public override void Saque(double saldoTotal)
        {
            base.Saque(saldoTotal);
            Saldo -= 2.0;
        }
    }

}
