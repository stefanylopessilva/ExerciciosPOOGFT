using System;

namespace ExercicioLoja
{
    public class Livro : Produto, IImposto
    {
        private string autor;
        private string tema;
        private int qtdPag;
        public Livro() {}
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base(nome, preco, qtd)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdPag;
        }
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }
        public double calculaImposto()
        {
            if (Tema == "educativo")
            {
                return 0;
            }
            else
            {
                return Preco * 0.10;
            }
        }
    }
}