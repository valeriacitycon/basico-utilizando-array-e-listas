using System;

class Program
{
    static void Main()
    {
        // Pergunta ao usuário quantos jogos deseja adicionar:
        int quantidadeJogos = int.Parse(Console.ReadLine());

        // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
       string[] nomesJogos = new string[quantidadeJogos];

        // TODO: Crei um Loop para adicionar jogos conforme a quantidade especificada:
       for(int i = 0; i < quantidadeJogos; i++)
       {
        //nomesJogos[i]  = Console.ReadLine();
       
         AdicionarJogo(i, nomesJogos);
       }

        //TODO: Chame a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:
       

        // Exibe o resumo da adição de jogos
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        // Entrada do nome do jogo
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        string texto = $"Foi adicionado '{quantidadeJogos}' jogos: ";
        
        for(int i = 0; i < nomes.Length; i++)
        {
          texto += $"{nomes[i]}, ";
        }
        
        texto += " ao catalogo.";
        int lastIndex = texto.LastIndexOf(",");
        string part1 = texto.Substring(0, lastIndex);
        
        lastIndex++;
        string part2 = texto.Substring(lastIndex, texto.Length - lastIndex);
        
        string message = part1 + part2;
        Console.Write(message);
    }
}
