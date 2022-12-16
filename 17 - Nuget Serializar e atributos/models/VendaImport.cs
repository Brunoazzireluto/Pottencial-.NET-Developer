using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace _17___Nuget_Serializar_e_atributos.models
{
    public class VendaImport
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")] // atributos
        public string Produto { get; set; }
        public Decimal Preco { get; set; }
        public DateTime dataVenda { get; set; }
    }
}