using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comentarios_e_Boas_Praticas.models
{
    public class Calculadora
    {
        /// <summary>
        /// Soma x e y e retorna o valor resultante    
        /// </summary>
        /// <param name="x"> um valor inteiro</param>
        /// <param name="y"> um valor inteiro</param>
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x}+{y} = {x+y}");
        }

        /// <summary>
        /// subtrai x e y
        /// </summary>
        /// <param name="x">primeiro valor inteiro</param>
        /// <param name="y">segundo valor inteiro</param>
        /// <returns> retorna a subtração dos valores x e y</returns>
        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x}-{y} = {x-y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x}x{y} = {x*y}");
        }

        public void Dividir(int x, int y)
        {
            Console.WriteLine($"{x}/{y} = {x/y}");
        }
        public void Potencia(int x, int y)
        {
            double potencia = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {potencia}");
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente, 4)}");
        }
         
        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}