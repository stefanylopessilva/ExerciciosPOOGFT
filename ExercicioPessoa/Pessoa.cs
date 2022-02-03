using System;
using System.Collections.Generic;

namespace ExercicioPessoa
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        public Pessoa() {}
        public Pessoa(string nome, int idade) 
        {
            Nome = nome;
            Idade = idade;
        }
        public string Nome {get; set;}
        public int Idade { get; set; }
    }
}