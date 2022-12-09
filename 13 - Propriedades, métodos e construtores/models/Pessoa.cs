using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedades_metodos_e_construtores.models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome 
        { 
            get =>  _nome.ToUpper();

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O Nome não pode ser vazio");
                }

                _nome = value;
            } 
            
        }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}