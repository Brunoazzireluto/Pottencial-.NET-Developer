using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulando_Valores.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        /*
        Se o metódo não retorna nada ele é void (vazio) se irá retornar algo o método precisar ter
        o tipo de dado a ser retornado (int, string)
        */
        public void adicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "N° " + count + " - " + Alunos[count].nomeCompleto;
                int exibicao = count + 1;
                string texto = $"N° {exibicao} - {Alunos[count].nomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}