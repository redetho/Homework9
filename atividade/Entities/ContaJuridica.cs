using System;
using System.Collections.Generic;
using System.Text;

namespace atividade.Entities
{
    public class ContaJuridica : Conta
    {
        //declaração de variáveis e encapsulamento
        public double EmprestimoLimite { get; set; }
        //construtor padrão
        public ContaJuridica() { }
        //criação do construtor com parâmetros utilizando o da classe Conta
        public ContaJuridica(int numero, string titular, double saldo, double emprestimoLimite)
            : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimoLimite;
        }
        public void Emprestimo(double saldoTotal)
        {
            if (saldoTotal <= EmprestimoLimite)
            {
                Saldo += saldoTotal;
            }
        }

    }
}
