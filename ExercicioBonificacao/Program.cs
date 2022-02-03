using System;

namespace ExercicioBonificacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Andreia", 45, 15000);
            Supervisor supervisor = new Supervisor("Marco", 32, 6000);
            Vendedor vendedor = new Vendedor("Luzia", 28, 2500);

            gerente.Bonificacao();
            supervisor.Bonificacao();
            vendedor.Bonificacao();

            Console.WriteLine("Gerente: " + gerente.Nome + " e sua bonificação é: " + gerente.Salario);
            Console.WriteLine("Supervisor: " + supervisor.Nome + " e sua bonificação é: " + supervisor.Salario);
            Console.WriteLine("Vendedor: " + vendedor.Nome + " e sua bonificação é: " + vendedor.Salario);

            Console.ReadLine();
        }
    }
}
