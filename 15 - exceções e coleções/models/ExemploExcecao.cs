using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exceções_e_coleções.models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            try
            {
                Metodo3();
            }catch(Exception ex)
            {
                Console.WriteLine("Excessão tratada" + ex.StackTrace);
            }
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }   
    }

}