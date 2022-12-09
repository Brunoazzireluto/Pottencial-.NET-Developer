using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comentarios_e_Boas_Praticas.models
{
    /// <summary>
    /// Representa uma pessoa fisica com idade e nome
    /// </summary>
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? NomeRepresentanteLegal {get; set;}

        /// <summary>
        /// Faz a Pessoa se aprensetar com nome é idade dela
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá Meu nome é {Nome}, \n e eu tenho {Idade} anos");
            // Console.WriteLine($"Olá Meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}