using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab);

                    Console.WriteLine();
                    Console.Write("Origem:");
                    Posicao origem = Tela.LerPosicaoXadrex().ToPosicao();

                    bool[,] posicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tab, posicoesPossiveis);

                    Console.Write("Destino:");
                    Posicao destino = Tela.LerPosicaoXadrex().ToPosicao();

                    partida.ExecutarMovimento(origem, destino);
                }
               
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
