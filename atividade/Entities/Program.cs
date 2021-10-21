using System;
using System.Collections.Generic;
using System.Globalization;


namespace atividade.Entities
{
    public class Program
    {
        //apresenta o saldo da conta.
        static void Main(string[] args)
        {
            Conta acc = new Conta(1001, "Goku", 0.0);
            ContaJuridica bacc = new ContaJuridica(1002, "Goten", 0.0, 500.0);
            //UPCASTING
            Conta acc1 = bacc;
            Conta acc2 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);
            Conta acc3 = new ContaPoupança(1004, "Vegeta", 0.0, 0.01);
            //DOWNCASTING
            ContaJuridica acc4 = (ContaJuridica)acc2;
            acc4.Emprestimo(100.0);
            //faz um empréstimo!
            if (acc3 is ContaJuridica)
            {
                ContaJuridica acc5 = (ContaJuridica)acc3;
                acc5.Emprestimo(200.0);
                Console.WriteLine("Emprestimo!");
            }
            //atualiza saldo
            if (acc3 is ContaPoupança)
            {
                ContaPoupança acc5 = acc3 as ContaPoupança;
                acc5.atualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }
        }
    }
}