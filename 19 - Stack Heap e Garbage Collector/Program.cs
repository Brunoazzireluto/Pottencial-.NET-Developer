//Stack e Heap
/*
    stack armazena as variaveis na memoria ram
    Stack armazena variaveis 

    armazena o nome o e valor
    int a = 5; -> a = 5 no stack

    quando é uma classe ele armazena a referencia para o Heap que  armazena os objetos (ou mais complexos)

*/



//Limpeza de Memoria

/*
Garbage Collector -> GC

o C#  limpa a memoria stack automaticamente
agora com o Heap quem limpa é o GC
ele limpa todos os dados da memoria heap que estãos sem referencia na memoria stack

*/




//Tipos de Valor e Tipos de Referencia

/*
Tipo de valor é uma variavel que contem uma instancia do tipo, que é armazenado somente na memoria stack

tipo de Referencia é uma vatiavel que contem uma referencia a um endereço na memoria heap
*/

//Atribuições de Tipo

/*
No tipo de referencia se você copiar o objeto, quando alterar a copi ao original também vai ser alterado. 
pois ele é um tipo de refencia ou seja, ele não intancia um novo objeto, somente puxa a mesma referencia
quando fazemos tipos complexos 

Pessoa p1 = new Pessoa()
Pessoa p2 = p1 

Nós estamos passando as duas variaveis para a mesma referencia, alterou um, alterou o outro
*/