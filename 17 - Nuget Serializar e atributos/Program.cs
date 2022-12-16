using _17___Nuget_Serializar_e_atributos.models;
using Newtonsoft.Json;

// List<Venda> listaVenda = new List<Venda>();
// DateTime DataAtual = DateTime.Now;

// Venda v1 = new Venda(1, "Material de Escritorio", 25.00M, DataAtual);
// Venda v2 = new Venda(2, "Papel Higiencio", 35.00M, DataAtual);
// Venda v3 = new Venda(3, "Bolinha de gude", 12.35M, DataAtual);

// listaVenda.Add(v1);
// listaVenda.Add(v2);
// listaVenda.Add(v3);


// string serializado = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);


//deserialização

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<VendaImport> Listvenda = JsonConvert.DeserializeObject<List<VendaImport>>(conteudoArquivo);

foreach (VendaImport venda in Listvenda)
{
    Console.WriteLine($"id: {venda.Id}, produto: {venda.Produto}, " +
     $" preço: {venda.Preco}, Data: {venda.dataVenda.ToString("dd/MM/yyyy HH:mm")}");
}

// Atributos

// Olhar o arquvo VendasImport