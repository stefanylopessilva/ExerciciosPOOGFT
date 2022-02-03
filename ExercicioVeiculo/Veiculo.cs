using System;

namespace ExerciciosPOO
{
    public class Veiculo
    {
        private string marca;
        private string modelo;
        private string placa;
        private string cor;
        private float km;
        private bool isLigado;
        private int litrosCombustivel;
        private int velocidade;
        private double preco;

        public Veiculo(string marca, string modelo, string placa, string cor, float km, bool isLigado, int litrosCombustivel, int velocidade, int preco)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Km = km;
            IsLigado = isLigado;
            LitrosCombustivel = litrosCombustivel;
            Velocidade = velocidade;
            Preco = preco;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool IsLigado { get; set; }
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public void Acelerar()
        {
            if (IsLigado == true)
            {
                Velocidade += 20;
                Console.WriteLine("Velocidade atual do veículo: " + Velocidade);
            }
            else
            {
                Console.WriteLine("Veículo está desligado, primeiro ligue-o para poder acelerar");
            } 
        }      
        public void Abastecer(int combustivel)
        {
            if (combustivel > 60)
            {
                Console.WriteLine("Não é possível abastecer um valor acima de 60 litros!");
            }
            else if (combustivel + LitrosCombustivel > 60)
            {
                Console.WriteLine("Não é possível abastecer esse valor, pois excederá os 60 litros!");
            }
            else
            {
                LitrosCombustivel += combustivel;
                Console.WriteLine("Veiculo foi abastecido. Quantidade de litros atual: " + LitrosCombustivel);
            }
        } 
        public void Frear()
        {
            if (IsLigado == true || Velocidade > 0)
            {
                velocidade -= 20;
                Console.WriteLine("Veículo foi freado, velocidade atual: " + Velocidade);
            }
        }
        public void Pintar(string cor)
        {
            Cor = cor;
            Console.WriteLine("Veiculo foi pintado de " + Cor);
        }
        public void Ligar()
        {
            if (IsLigado == false)
            { 
                IsLigado = true;
                Console.WriteLine("O veículo foi ligado!");
            }
            else
            {
                Console.WriteLine("O veículo já está ligado!");
            }
        }
        public void Desligar()
        {
            if (IsLigado == true && Velocidade == 0)
            {
                IsLigado = false;
                Console.WriteLine("O veículo foi desligado!");
            }
            else if (Velocidade > 0)
            {
                Console.WriteLine("O veículo não está parado, não é possível desligar!");
            }
            else
            {
                Console.WriteLine("O veículo já está desligado!");
            }
        }
    }
}