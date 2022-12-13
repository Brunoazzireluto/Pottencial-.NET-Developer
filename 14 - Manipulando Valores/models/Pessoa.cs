using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulando_Valores.models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;
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

        public string Sobrenome { get; set; }
        public string nomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {nomeCompleto} e tenho {Idade} anos");
        }
    }
}