namespace ExercicioBonificacao
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override void Bonificacao()
        {
            Salario += 5000.0;
        }
    }
}