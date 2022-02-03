using System;
using System.Collections.Generic;

namespace ExercicioLoja
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40.0, 50, "J.K. Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60.0, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20.0, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800.0, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000.0, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500.0, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> videoGames = new List<VideoGame>();
            videoGames.Add(ps4);
            videoGames.Add(ps4Usado);
            videoGames.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, videoGames);

            Console.WriteLine("Impostos:");
            Console.WriteLine("RS " + l2.calculaImposto() + " de imposto sobre o livro " + l2.Nome);
            Console.WriteLine("RS " + l3.calculaImposto() + " de imposto sobre o livro " + l3.Nome);
            Console.WriteLine("RS " + ps4Usado.calculaImposto() + " de imposto sobre o video game " + ps4Usado.Nome);
            Console.WriteLine("RS " + ps4.calculaImposto() + " de imposto sobre o video game " + ps4.Nome);
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("A loja "+ americanas.Nome + " possui esses livros para venda: ");
            americanas.listaLivros();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("A loja "+ americanas.Nome + " possui esses video games para venda: ");
            americanas.listaVideoGames();
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("O patrimônio da loja " + americanas.Nome+ " é de: ");
            Console.WriteLine(americanas.calculaPatrimonio());
            Console.ReadLine();
        }
    }
}
