using System;
using System.Collections.Generic;
using System.Text;

namespace atividade.Entities
{
    //criação da classe conta
    public class Conta
    {
        //declarações e encapsulamento
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        //protected para alteração de valores entre classes
        public double Saldo { get; protected set; }
        //construtor padrão e construtor com parâmetros
        public Conta() { }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        //método de saque
        public void Saque(double saldoTotal)
        {
            Saldo -= saldoTotal;
        }
        //método de depósito
        public void Deposito(double SaldoTotal)
        {
            Saldo += SaldoTotal;
        }
        
    }
}
