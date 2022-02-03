using System;

namespace ExerciciosPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Veiculo carro = new Veiculo("Hyundai","HB20","GFT 1S21","Preto", 100, false, 35, 80, 51500);
            
            carro.Ligar();
            carro.Acelerar();
            carro.Abastecer(20);
            carro.Abastecer(40);
            carro.Frear();
            carro.Pintar("Prata");
            carro.Desligar();
        }
    }
}
