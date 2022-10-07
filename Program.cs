using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta; ");
            int NumeroConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o nome do Titular da conta; ");
            string Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n); ");
            char ValorInicial = char.Parse(Console.ReadLine());

            if (ValorInicial == 's' || ValorInicial == 'S') {
                Console.Write("Entre com o valor de depósito inicial: R$ ");
                double Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria (NumeroConta, Nome, Deposito);
            }
            else {
                conta = new ContaBancaria (NumeroConta, Nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o Valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o Valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta atualizados: ");
            Console.WriteLine(conta);





        }
    }
}
