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
            //contas, numero, nome, etc.
            List<Conta> list = new List<Conta>();
            list.Add(new ContaPoupança(1001, "Terry", 500.0, 0.01));
            list.Add(new ContaJuridica(1002,"Andy", 500.0, 400.0));
            list.Add(new ContaPoupança(1003,"Joe", 500, 0.01));
            list.Add(new ContaJuridica(1004,"Mae", 500, 400.0));
            double soma = 0.0;
            foreach(Conta acc in list)
            {
                soma += acc.Saldo;
            }
            //calcula o saldo de todas contas
            Console.WriteLine("Total do saldo de todas as contas: " +soma.ToString("F2", CultureInfo.InvariantCulture));
            foreach(Conta acc in list)
            {
                acc.Saque(10.0);
            }
            //saque e atualização das contas
            foreach(Conta acc in list)
            {
                Console.WriteLine("atualização do saldo das contas" +acc.Numero + ":" + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}