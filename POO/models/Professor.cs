using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.models
{
    // public sealed class Professor : Pessoa -> Classe selada
    public class Professor : Pessoa

    {
        public Professor(){}

        public Professor(string nome) : base(nome){} // -> Construtor de herança 

        public decimal Salario { get; set; }

        public  override void Apresentar()
        // public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, tenho {Idade} anos e sou um professor que ganha {Salario.ToString("C")}");

        }
    }
}