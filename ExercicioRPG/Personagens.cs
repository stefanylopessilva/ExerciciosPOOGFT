namespace ExercicioRPG
{
    public abstract class Personagens
    {
        private string nome;
        private int vida;
        private int mana;
        private float xp;
        private int inteligencia;
        private int forca;
        private int level;

        public Personagens(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
        }
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        public abstract void LvlUp();
    }
}