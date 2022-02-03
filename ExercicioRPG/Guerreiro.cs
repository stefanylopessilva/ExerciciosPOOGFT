using System;
using System.Collections.Generic;

namespace ExercicioRPG
{
    public class Guerreiro: Personagens
    {
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
        }

        private List<String> habilidade;
        public List<String> Habilidade {get; set;}

        public override void LvlUp()
        {
            Level += 1;
            Vida += 2;
            Forca += 3;
        }
        public int Attack() 
        {
            Random rnd = new Random();
            int numRandomico = rnd.Next(0, 300);

            return (Forca * Level) + numRandomico;
        }
        public void AprenderHabilidade(string nomeMagia)
        {
            Habilidade.Add(nomeMagia);
        }
    }
}