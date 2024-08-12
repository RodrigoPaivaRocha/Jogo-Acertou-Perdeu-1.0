using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acertouPerdeuV1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroOculto;
            int minimo = 1;
            int maximo = 100;

            // Jogador neutro escolhe o número oculto
            Console.WriteLine("Jogador Neutro, escolha um número entre 1 e 100 (não revele para os outros jogadores):");
            numeroOculto = int.Parse(Console.ReadLine());

            // Limpa a tela para que os outros jogadores não vejam o número oculto
            Console.Clear();

            Console.WriteLine("Jogadores 1 e 2, tentem adivinhar o número escolhido pelo Jogador Neutro!");

            bool acertou = false;
            int palpite;
            int jogadorAtual = 1; // 1 para Jogador 1, 2 para Jogador 2

            while (!acertou)
            {
                Console.WriteLine($"Jogador {jogadorAtual}, faça um palpite (entre {minimo} e {maximo}):");
                palpite = int.Parse(Console.ReadLine());

                if (palpite < minimo || palpite > maximo)
                {
                    Console.WriteLine("Palpite fora do intervalo permitido. Tente novamente.");
                    continue;
                }

                if (palpite < numeroOculto)
                {
                    Console.WriteLine("O número oculto é maior.");
                    minimo = palpite + 1;
                }
                else if (palpite > numeroOculto)
                {
                    Console.WriteLine("O número oculto é menor.");
                    maximo = palpite - 1;
                }
                else
                {
                    Console.WriteLine($"Parabéns, Jogador {jogadorAtual}! Você perdeu!");
                    acertou = true;
                }

                // Alterna o jogador
                jogadorAtual = (jogadorAtual == 1) ? 2 : 1;
            }
                 Console.ReadKey();
        }
    }
}
