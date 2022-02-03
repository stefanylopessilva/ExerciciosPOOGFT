using System;
using System.Collections.Generic;

namespace ExercicioRPG
{
    public class Mago : Personagens
    {
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
        }

        private List<String> magia;
        public List<String> Magia {get; set;}

        public override void LvlUp()
        {
            Level += 1;
            Mana += 2;
            Inteligencia += 3;
        }
        public int Attack() 
        {
            Random rnd = new Random();
            int numRandomico = rnd.Next(0, 300);

            return (Inteligencia * Level) + numRandomico;
        }
        public void AprenderMagia(string nomeMagia)
        {
            Magia.Add(nomeMagia);
        }
    }
}