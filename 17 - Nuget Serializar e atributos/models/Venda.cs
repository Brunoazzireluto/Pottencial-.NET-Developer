using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _17___Nuget_Serializar_e_atributos.models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, DateTime data)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            dataVenda = data;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public Decimal Preco { get; set; }
        public DateTime dataVenda { get; set; }
    }
}