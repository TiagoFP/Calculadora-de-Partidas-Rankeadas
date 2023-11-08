using CalculadoraPartirdasRankeadas.Models;

CalculadoraRanking calc = new CalculadoraRanking();

Console.WriteLine("Qual o número de vitórias do Herói? ");
calc.vitoria = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o número de derrotas do Herói? ");
calc.derrota = int.Parse(Console.ReadLine());

calc.CalcularRanking();
calc.CalcularNivel();
