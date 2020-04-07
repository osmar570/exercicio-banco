using System;

namespace exercicio_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome ?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o numero da sua conta ?");
            int nConta = int.Parse(Console.ReadLine());

            Conta conta = new Conta(nome, nConta);

            Console.WriteLine("Haverá depósito inicial ? (s/n)");
            char depositoInicial = char.Parse(Console.ReadLine());
            if (depositoInicial == 's')
            {
                Console.WriteLine("Qual será o valor do seu depósito ?");
                double valor = double.Parse(Console.ReadLine());
                conta.Depositar(valor);
            }


            Console.WriteLine(conta);

            Console.WriteLine("Quanto você gostaria de depositar ? ");
            conta.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta);

            Console.WriteLine("Quanto você gostaria de sacar ? ");
            conta.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta);


            

        }
    }
}
