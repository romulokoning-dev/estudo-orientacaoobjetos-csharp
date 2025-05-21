using System;

class Pessoa
{
    public string Nome;
    public int Idade;
    public string Profissao;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou {Profissao}");
    }
}
class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Rômulo";
        p1.Idade = 17;
        p1.Profissao = "Dev Júnior";
        p1.Apresentar();
        Pessoa p2 = new Pessoa();
        p2.Nome = "Maria";
        p2.Idade = 20;
        p2.Profissao = "Designer";
        p2.Apresentar();
    }
}