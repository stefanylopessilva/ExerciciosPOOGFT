using System;

namespace ExercicioLoja
{
    public class VideoGame : Produto, IImposto
    {
        private string marca;
        private string modelo;
        private bool isUsado;
        public VideoGame() {}
        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsUsado { get; set; }
        public double calculaImposto()
        {
            if(IsUsado == true)
            {
                return Preco * 0.25;
            }
            else
            {
                return Preco * 0.45;
            }
        }
    }
}