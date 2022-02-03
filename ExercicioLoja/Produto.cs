using System;

namespace ExercicioLoja
{
    public abstract class Produto
    {
        private string nome;
        private double preco;
        private int qtd;
        public Produto() {}
        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtd { get; set; }
    }
}