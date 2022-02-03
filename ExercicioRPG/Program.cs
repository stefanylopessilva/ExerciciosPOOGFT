using System;
using System.Collections.Generic;

namespace ExercicioRPG
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Guerreiro> guerreiros = new List<Guerreiro>();
            List<Mago> magos = new List<Mago>();
            Guerreiro guerreiro = new Guerreiro("Aragorn",100,20,500,40,80,5);
            Mago mago = new Mago("Merlim",60,80,460,90,20,6);

            mago.LvlUp();
            int attackMago = mago.Attack();
            guerreiro.LvlUp();
            int attackGuerreiro = guerreiro.Attack();

            guerreiros.Add(guerreiro);
            magos.Add(mago);
            
            int countGuerreiro = 0;
            foreach (Personagens item in guerreiros)
            {
                countGuerreiro++;
            }

            int countMago = 0;
            foreach (Personagens item in magos)
            {
                countMago++;
            }

            int totalCount = countGuerreiro + countMago;

            Console.WriteLine("Informações sobre os guerreiros:");
            Console.WriteLine("Nome do guerreiro:");
            Console.WriteLine(guerreiro.Nome);
            Console.WriteLine("Valor do ataque do guerreiro:");
            Console.WriteLine(attackGuerreiro);
            Console.WriteLine("Level do guerreiro");
            Console.WriteLine(guerreiro.Level);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Informações sobre os magos:");
            Console.WriteLine("Nome do mago:");
            Console.WriteLine(mago.Nome);
            Console.WriteLine("Valor do ataque do mago:");
            Console.WriteLine(attackMago);
            Console.WriteLine("Level do mago");
            Console.WriteLine(mago.Level);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Quantidade de personagens inseridos: ");
            Console.WriteLine(totalCount);
            Console.WriteLine("-------------------------------------------------------------");

        }
    }
}
