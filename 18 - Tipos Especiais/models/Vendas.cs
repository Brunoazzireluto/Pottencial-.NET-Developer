using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace _18___Tipos_Especiais.models
{
    public class Venda
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")] // atributos
        public string Produto { get; set; }
        public Decimal Preco { get; set; }
        public DateTime dataVenda { get; set; }
        public Decimal? Desconto { get; set; }

    }
}
