namespace ExercicioBonificacao
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override void Bonificacao()
        {
            Salario += 10000.0;
        }
    }
}