using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_e_identação.pessoacopia
{
    public class Pessoa
    {
        public string? Name { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Name}, e tenho {Idade} anos");
        }
    }
}