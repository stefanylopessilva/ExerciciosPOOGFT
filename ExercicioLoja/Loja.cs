using System;
using System.Collections.Generic;

namespace ExercicioLoja
{
    public class Loja
    {
        private string nome;
        private string cnpj;
        
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }
        public Loja() {}
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            Livros = livros;
            VideoGames = videoGames;
        }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public void listaLivros()
        {
            if (Livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros no seu estoque");
            }
            else
            {
                foreach (Livro livro in Livros)
                {
                    Console.WriteLine("Título: " + livro.Nome + ", preço: " + livro.Preco + ", quantidade: " + livro.Qtd + " em estoque");
                }
            }
        }
        public void listaVideoGames()
        {
            foreach (VideoGame videoGame in VideoGames)
            {
                Console.WriteLine("Título: " + videoGame.Nome + ", preço: " + videoGame.Preco + ", quantidade: " + videoGame.Qtd + " em estoque");
            }
        }
        public double calculaPatrimonio()
        {
            double patrimonioTotal = 0;
            double patrimonioLivros = 0;
            double patrimonioVideoGame = 0;

            foreach (Livro livro in Livros)
            {
                patrimonioLivros += livro.Preco * livro.Qtd;
            }
            foreach (VideoGame videoGame in VideoGames)
            {
                patrimonioVideoGame += videoGame.Preco * videoGame.Qtd;
            }

            patrimonioTotal = patrimonioLivros + patrimonioVideoGame;

            return patrimonioTotal;
        }
    }
}