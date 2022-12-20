using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    public class Aluno : Pessoa
    {

        public Aluno(){}

        public Aluno(string nome) : base(nome){} // -> Construtor de herança 

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");

        }
    }
}