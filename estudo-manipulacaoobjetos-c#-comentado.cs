using System;

class Pessoa // Aqui criei uma nova classe, um molde, como por exemplo, do que seria uma Pessoa.
{
    public string Nome; // Aqui temos uma variável string public, ou seja, ela pode ser chamada por todas as classes.
    public int Idade; // Variável para a idade.
    public string Profissao; // Variável para profissão.

    // Criei um método,que vai ser uma ação guardada aqui, não executa essas instruções sozinhas, apenas se eu chamar.
    public void Apresentar()
    {
        // Esse código é a ação executada, quando eu chamar, estou dizendo que quero executar esse código.
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou {Profissao}");
    }
}
// Então a classe program com o Main(), que é o código que vai ser executado de fato.
class Program
{
    static void Main()
    {
        // Aqui entra a parte da orientação a objetos. Criei o objeto p1 da classe Pessoa.
        Pessoa p1 = new Pessoa();
        // Atribuí ao objeto p1 que a variável Nome pra ele vale "Rômulo".
        p1.Nome = "Rômulo";
        // Idade pro objeto p1 vale 17.
        p1.Idade = 17;
        // Profissao pro objeto p1 vale "Dev Junior"
        p1.Profissao = "Dev Júnior";
        // Agora com todas os valores definidos pro objeto p1, posso invocar o método Apresentar() a ele e assim ele executará o código com os valores atribuidos a ele.
        p1.Apresentar();
        // Agora crio o objeto p2 da Classe Pessoa.
        Pessoa p2 = new Pessoa();
        // O valor pra variável Nome vale "Maria" apenas para o objeto p2.
        p2.Nome = "Maria";
        // Idade vale 20 apenas para objeto p2.
        p2.Idade = 20;
        // Profissao para objeto p2 vale "Designer"
        p2.Profissao = "Designer";
        // Chamo o método Apresentar() para o objeto p2, porém agora vai mostrar os valores definidos para ele, mesmo usando das mesmas variáveis.
        p2.Apresentar();
    }
}
// Aprendizado: A programação voltada a orientação de objetos permite um código limpo, usando de variáveis compartilhadas porém de valor individual para cada objeto.
// Vejo que seria útil para programação de funcionamento de botões para apps, programação de física compartilhada entre objetos e outras. Avanço significativo para meu aprendizado.