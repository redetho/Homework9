using System;


namespace atividade.Entities
{
    public class Program
    {
        //apresenta o saldo da conta.
        static void Main(string[] args)
        {
            var ContaJuridicaConta = new ContaJuridica(8010, "LaraCroft", 100.0, 500.0);
            Console.WriteLine(ContaJuridicaConta.Saldo);
        }
    }
}