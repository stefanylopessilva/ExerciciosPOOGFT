namespace ExercicioBonificacao
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public override void Bonificacao()
        {
            Salario += 3000.0;
        }
    }
}