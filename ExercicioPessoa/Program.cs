using System;
using System.Collections.Generic;

namespace ExercicioPessoa
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa pessoa1 = new Pessoa("João", 15);
            Pessoa pessoa2 = new Pessoa("Leandro", 21);
            Pessoa pessoa3 = new Pessoa("Paulo", 17);
            Pessoa pessoa4 = new Pessoa("Jessica", 18);
            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            pessoas.Add(pessoa3);
            pessoas.Add(pessoa4);

            var pessoaMaisVelha = EncontraPessoaMaisVelha(pessoas);

            var listaPessoasMaiorDe18 = RetornaPessoasMaiorDe18(pessoas);

            Console.WriteLine("A pessoa mais velha é: " + pessoaMaisVelha);
            Console.WriteLine("A pessoa maiores de 18 anos são: ");
            foreach (var pessoa in listaPessoasMaiorDe18)
            {
                Console.WriteLine("Nome: " + pessoa.Nome + " Idade: " + pessoa.Idade);
            }

            foreach (var pessoa in listaPessoasMaiorDe18)
            {
                if (pessoa.Nome == "Jessica")
                {
                    Console.WriteLine("Encontrou Jéssica e sua idade é: " + pessoa.Idade);
                }
            }
        }

        private static List<Pessoa> RetornaPessoasMaiorDe18(List<Pessoa> pessoas)
        {
            List<Pessoa> pessoasMaior18 = new List<Pessoa>();

            foreach (var pessoa in pessoas)
            {
                if (pessoa.Idade >= 18)
                {
                    pessoasMaior18.Add(pessoa);
                }
            }
            return pessoasMaior18;
        }

        private static string EncontraPessoaMaisVelha(List<Pessoa> pessoas)
        {
            var maior = 0;
            var pessoaMaiorIdade = new Pessoa();
            foreach (var pessoa in pessoas)
            {
                if (maior < pessoa.Idade)
                {
                    maior = pessoa.Idade;
                    pessoaMaiorIdade = pessoa;
                }
            }
            return pessoaMaiorIdade.Nome;
        }
    }
}
